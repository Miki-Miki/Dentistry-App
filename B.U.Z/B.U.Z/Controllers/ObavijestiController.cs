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
            List<Pacijent> p = db.Pacijenti.ToList();
            if (_userManager.FindByNameAsync(User.Identity.Name).Result.isStomatolog==true || _userManager.FindByNameAsync(User.Identity.Name).Result.isAsistent==true)
            {
                
                model = new ObavijestiVM
                {
                    Procitane = db.Obavijesti.Where(s => s.isProcitana == true && db.Pacijenti.Single(p=>p.Id==s.From)!=null).ToList(),
                    NeProcitane = db.Obavijesti.Where(s => s.isProcitana == false && db.Pacijenti.Single(p=>p.Id==s.From)!=null).ToList()
                };
                foreach (var o in obav)
                {
                    foreach(var pac in p)
                    {
                        if(o.From==pac.Id)
                        {
                            o.isProcitana = true;
                        }
                    }
                }
                db.SaveChanges();
                return View(model);
            }
            else
            {
                List<Asistent> a = db.Asistenti.ToList();
                List<Stomatolog> s = db.Stomatolozi.ToList();
                model = new ObavijestiVM
                {
                    Procitane = db.Obavijesti.Where(s => s.isProcitana == true && (db.Asistenti.Single(p=>p.Id==s.From) != null || db.Stomatolozi.Single(p=>p.Id==s.From) != null) && s.To == _userManager.FindByNameAsync(User.Identity.Name).Result.Id).ToList(),
                    NeProcitane = db.Obavijesti.Where(s => s.isProcitana == false && (db.Asistenti.Single(p => p.Id == s.From) != null || db.Stomatolozi.Single(p => p.Id == s.From) != null) && s.To == _userManager.FindByNameAsync(User.Identity.Name).Result.Id).ToList()
                };
                foreach (var o in obav)
                {
                    foreach (var aa in a)
                    {
                        foreach (var ss in s)
                        {
                            if ((o.From == aa.Id || o.From == ss.Id)&&(o.To==_userManager.FindByNameAsync(User.Identity.Name).Result.Id))
                            {
                                o.isProcitana = true;
                            }
                        }
                    }
                }
                db.SaveChanges();
                return View(model);
            };            
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
