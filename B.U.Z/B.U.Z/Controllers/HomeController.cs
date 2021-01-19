using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using B.U.Z.Models;
using Microsoft.AspNetCore.Identity;
using B.U.Z.ViewModels;

namespace B.U.Z.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> VerifyEmail(string userID, string code)
        {
            var user = await _userManager.FindByIdAsync(userID);

            if (user == null) return BadRequest();

            var result = await _userManager.ConfirmEmailAsync(user, code);

            if (result.Succeeded)
            {
                return View("VerifyEmail");
            }

            return BadRequest();
        }
        public IActionResult EmailVerification()
        {
            return View();
        }
        public IActionResult ResetPassword(string code, string email)
        {


            return View("ResetPassword");
        }


        public async Task<IActionResult> ResetujPassword(ResetPassVM resetPassVM)
        {

            var user = await _userManager.FindByEmailAsync(resetPassVM.Email);
            if (user == null)
                RedirectToAction("/Identity/Account/Login");
            var resetPassResult = await _userManager.ResetPasswordAsync(user, resetPassVM.Code, resetPassVM.Password);
            if (!resetPassResult.Succeeded)
            {
                foreach (var error in resetPassResult.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return Redirect("/Identity/Account/Login");
            }
            return RedirectToAction("ResetPasswordConfirmation");
        }

        public IActionResult ResetPasswordConfirmation() { return View(); }
    }
}
