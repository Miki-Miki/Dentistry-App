using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using B.U.Z.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using B.U.Z.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Mail;
using System.Net;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace B.U.Z.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;     

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public static ApplicationDbContext _context = new ApplicationDbContext();
        public List<SelectListItem> spolovi = new List<SelectListItem>();
        public List<SelectListItem> gradovi = new List<SelectListItem>();

        public class InputModel
        {
            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [DataType(DataType.DateTime)]
            [Display(Name = "Godina Rodjenja")]
            public DateTime GodinaRodjenja { get; set; }

            [Required]
            [Display(Name = "Spol")]
            public int Spol { get; set; }

            [Required]
            [Display(Name = "Broj telefona")]
            public string BrojTelefona { get; set; }

            [Required]
            [Display(Name = "Autentifikacijski kod")]
            public string PhoneAuthCode { get; set; }

            [Required]
            [Display(Name = "Grad")]
            public int Grad { get; set; }
        }
     

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            //ApplicationDbContext _context = new ApplicationDbContext();

            spolovi = _context.Spol.OrderBy(a => a.Naziv).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Naziv
            }).ToList();

            gradovi = _context.Grad.OrderBy(a => a.Naziv).Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Naziv
            }).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new Pacijent 
                { 
                    UserName = Input.BrojTelefona, 
                    PhoneNumber=Input.BrojTelefona,
                    Email = Input.Email, 
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    GodinaRodjenja = Input.GodinaRodjenja,
                    SpolId = Input.Spol,
                    GradId = Input.Grad
                };

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var link = Url.Action("VerifyEmail", "Home", new { userID = user.Id, code }, Request.Scheme, Request.Host.ToString());
                    //await _emailService.SendAsync(Input.Email, "Confirm your email", $"<a href="{link}">Verify Email</a>", true);

                    var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                    var message = new MailMessage();
                    var email = this.Input.Email;
                    message.To.Add(new MailAddress(email.ToString()));
                    message.From = new MailAddress("buz.stomatologija@gmail.com");
                    message.Subject = "Verifikacija e-maila";
                    message.Body = string.Format(body, "B.U.Z", "buz.stomatologija@gmail.com", link);

                    message.IsBodyHtml = true;

                    using (var smtp = new SmtpClient())
                    {
                        var credential = new NetworkCredential
                        {
                            UserName = "buz.stomatologija@gmail.com",
                            Password = "vmhXPuAg2hTEdw3"
                        };
                        smtp.Credentials = credential;
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        await smtp.SendMailAsync(message);
                        return RedirectToAction("EmailVerification");
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
        

        public IActionResult OnGetSendCode(string code, string phoneNumber)
        {
            string accountSid = "AC1279df1aea6e0ac0945312ba31e89586";
            string authToken = "d3ef9890e2a3ebd27f396bf503240e7a";

            TwilioClient.Init(accountSid, authToken);


            var message = MessageResource.Create(
                body: "Vaš autentifikacijski kod je: " + code,
                from: new Twilio.Types.PhoneNumber("+12513195692"),
                to: new Twilio.Types.PhoneNumber(phoneNumber)
            );

            return Page();
        }
    }
}
