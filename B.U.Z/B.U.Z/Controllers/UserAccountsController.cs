using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using B.U.Z.Areas.Identity.Pages.Account;
using B.U.Z.Data;
using B.U.Z.Models;
using B.U.Z.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using static B.U.Z.Areas.Identity.Pages.Account.ExternalLoginModel;

namespace B.U.Z.Controllers
{
    public class UserAccountsController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public UserAccountsController(
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
        public IActionResult UserAccounts()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<ApplicationUser> users = db.ApplicationUsers.ToList();
            return View(users);
        }
        //opens view SpasiNoviStomatolog
        public IActionResult NoviUserAccountStomatolog()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            StomatologRegistracijaVM model = new StomatologRegistracijaVM
            {
                spolovi = db.Spol.OrderBy(a => a.Naziv).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Naziv }).ToList(),
                gradovi = db.Grad.OrderBy(a => a.Naziv).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Naziv }).ToList(),
            };
            return View(model);
        }
        public async Task<IActionResult> SpasiNoviStomatolog(StomatologRegistracijaVM s,string returnUrl=null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new Stomatolog
                {
                    UserName = s.Email,
                    Email = s.Email,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    SpolId = s.SpolId,
                    GradId = s.GradId,
                    Specijalizacija=s.Specijalizacija,
                    Titula=s.Titula
                };
                var result = await _userManager.CreateAsync(user, s.PasswordHash);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Redirect("UserAccounts");
        }
        public IActionResult NoviUserAccountAsistent()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            AsistentRegistracijaVM model = new AsistentRegistracijaVM
            {
                spolovi = db.Spol.OrderBy(a => a.Naziv).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Naziv }).ToList(),
                gradovi = db.Grad.OrderBy(a => a.Naziv).Select(a => new SelectListItem { Value = a.Id.ToString(), Text = a.Naziv }).ToList(),
            };
            return View(model);
        }
        public async Task<IActionResult> SpasiNoviAsistent(AsistentRegistracijaVM s,string returnUrl= null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new Asistent
                {
                    UserName = s.Email,
                    Email = s.Email,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    SpolId = s.SpolId,
                    GradId = s.GradId,
                    Titula = s.Titula
                };
                var result = await _userManager.CreateAsync(user, s.PasswordHash);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Redirect("UserAccounts");
        }
    }
    
}
