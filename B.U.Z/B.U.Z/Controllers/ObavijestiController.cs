using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.U.Z.Data;
using B.U.Z.Models;
using B.U.Z.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace B.U.Z.Controllers
{

    public class ObavijestiController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public ObavijestiController(SignInManager<ApplicationUser> s, UserManager<ApplicationUser> u )
        {
            _signInManager = s;
            _userManager = u;
        }
        public IActionResult Obavijesti()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            ObavijestiVM model;
            List<Obavijesti> obav = db.Obavijesti.ToList();
            if (_userManager.FindByNameAsync(User.Identity.Name).Result.isStomatolog==true || _userManager.FindByNameAsync(User.Identity.Name).Result.isAsistent==true)
            {
                List<Pacijent> p = db.Pacijenti.ToList();
                model = new ObavijestiVM
                {
                    Procitane = db.Obavijesti.Where(s => s.isProcitana == true && db.Pacijenti.Find(s.From)!=null).ToList(),
                    NeProcitane = db.Obavijesti.Where(s => s.isProcitana == false).ToList()
                };
                foreach (var o in obav)
                {
                    o.isProcitana = true;
                }
                db.SaveChanges();
                return View(model);
            }
            else if(_userManager.FindByNameAsync(User.Identity.Name).Result.isPacijent==true)
            {
                List<Asistent> a = db.Asistenti.ToList();
                List<Stomatolog> s = db.Stomatolozi.ToList();
                model =new ObavijestiVM
                {
                    Procitane=db.Obavijesti.Where(s=>s.isProcitana==true &&(db.Asistenti.Find(s.From)!=null || db.Stomatolozi.Find(s.From)!=null)
                }
            };
            
           
            return View(model);
        }
        public IActionResult ProcitajObavijest(int ObavijestId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Obavijesti obavijesti = db.Obavijesti.Find(ObavijestId);
            obavijesti.isProcitana = true;
            db.SaveChanges();
            return View("ObavijestiOdabir", obavijesti);
        }
        public IActionResult ObrisiObavijest(int ObavijestId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Obavijesti obavijesti = db.Obavijesti.Find(ObavijestId);
            db.Obavijesti.Remove(obavijesti);
            db.SaveChanges();
            return Redirect("Obavijesti");
        }
    }
}
