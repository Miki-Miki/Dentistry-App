using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastReport.Web;
using System.Text;
using System.Data;
using FastReport.Data;
using FastReport.Utils;
using FastReport;
using System.Drawing;
using B.U.Z.Models;
using B.U.Z.Data;
using B.U.Z.ViewModels;

namespace B.U.Z.Controllers
{
    public class RacunController : Controller
    {
        public IActionResult ZavrsiUslugu(int _sesijaId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Sesija sesija = db.Sesija.Find(_sesijaId);

            TerapijaNaSesiji tns = db.TerapijaNaSesiji.Where(a => a.SesijaId == sesija.Id).FirstOrDefault();

            DijagnozaNaSesiji dns = db.DijagnozaNaSesiji.Where(a => a.SesijaId == sesija.Id).FirstOrDefault();

            LijekNaSesiji lns = db.LijekNaSesiji.Where(a => a.SesijaId == sesija.Id).FirstOrDefault();

            Termini termin = db.Termini.Find(sesija.TerminId);
            ZakazanaUsluga zakazanaUsluga = db.ZakazanaUsluga.Where(a => a.TerminId == termin.Id).FirstOrDefault();
            Usluga usluga = db.Usluga.Find(zakazanaUsluga.UslugaId);


            RacunVM racunVm = new RacunVM();

            if (dns != null)
                racunVm.dijagnozaId = dns.DijagnozaId;
            if (tns != null)
            {
                racunVm.terapijaId = tns.TerapijaId;
                racunVm.Datum = termin.TerminStart;
            }
            if (lns != null)
                racunVm.LijekId = lns.LijekId;
            if (zakazanaUsluga != null)
            {
                racunVm.Usluga = zakazanaUsluga.UslugaId;
                racunVm.cijena = usluga.Cijena;
            }
            racunVm.SesijaId = _sesijaId;


            //var controller = DependencyResolver.Current.GetService<RacunController>();
            //controller.ControllerContext = new ControllerContext(this.Request.RequestContext, controller);

        //    return RedirectToAction("Racun", racunVm);

        //}

        //public IActionResult Racun(RacunVM racunVm)
        //{
         //   ApplicationDbContext db = new ApplicationDbContext();
            //Sesija sesija = db.Sesija.Find(racunVm.SesijaId);
            Racun racun = new Racun
            {
                Datum = racunVm.Datum,
                SesijaId = racunVm.SesijaId,
                Sesija = sesija
            };
            db.Racun.Add(racun);
            db.SaveChanges();

            //return RedirectToAction("Report",racunVm);
        //}

        //public IActionResult Report(RacunVM racunVM) {

 
            //Usluga usluga = db.Usluga.Find(racunVm.Usluga);

            WebReport report = new WebReport();

            ReportPage page = new ReportPage();
            page.CreateUniqueName();
            page.TopMargin = 10.0f;
            page.LeftMargin = 10.0f;
            page.RightMargin = 10.0f;
            page.BottomMargin = 10.0f;
            report.Report.Pages.Add(page);

            /////////////////////////////////// T I T L E ////////////////////////////////////////////

            page.ReportTitle = new ReportTitleBand();
            page.ReportTitle.CreateUniqueName();
            page.ReportTitle.Height = 4.0f * Units.Centimeters;
            page.ReportTitle.FillColor = Color.Red;

            //Usluga _usluga = db.Usluga.Find(usluga);

            TextObject titleText = new TextObject();
            titleText.CreateUniqueName();
            //titleText.Left = 1.0f * Units.Centimeters;
            //titleText.Top = 1.0f * Units.Centimeters;
            //titleText.Width = 17.0f * Units.Centimeters;
            //titleText.Height = 2.0f * Units.Centimeters;
            titleText.Bounds = new RectangleF(1.0f * Units.Centimeters, 1.0f * Units.Centimeters, 17.0f * Units.Centimeters, 2.0f * Units.Centimeters);
            titleText.HorzAlign = HorzAlign.Center;
            titleText.VertAlign = VertAlign.Center;
            titleText.Border.Lines = BorderLines.All;
            //titleText.Font = new Font("Chiller", 32.0f, FontStyle.Bold);
            //titleText.TextColor = Color.DarkGreen;
            //titleText.FillColor = Color.DarkOrange;
            //titleText.Border.Color = Color.DarkOrchid;
            //titleText.Border.Lines = BorderLines.All;
            //titleText.Border.Width = 4.0f;
            titleText.Text = usluga.Naziv;
            page.ReportTitle.Objects.Add(titleText);

            /////////////////////////////////////////////////////////////////////////////////////////

            //TextObject headerText = new TextObject();
            //headerText.CreateUniqueName();
            //headerText.Bounds = new RectangleF(0.0f, 0.5f * Units.Centimeters, 19.0f * Units.Centimeters, 1.0f * Units.Centimeters);
            //headerText.HorzAlign = HorzAlign.Center;
            //headerText.VertAlign = VertAlign.Center;
            //headerText.Font = new Font("Book Antique", 16.0f, FontStyle.Bold | FontStyle.Italic);
            //headerText.TextColor = Color.Teal;
            //headerText.FillColor = Color.YellowGreen;
            //headerText.Border.Lines = BorderLines.All;
            //headerText.Border.TopLine.Color = Color.Indigo;
            //headerText.Border.LeftLine.Color = Color.Gold;
            //headerText.Border.RightLine.Color = Color.Gold;
            //headerText.Border.BottomLine.Color = Color.Indigo;
            //headerText.Border.TopLine.Width = 3.0f;
            //headerText.Border.LeftLine.Width = 2.0f;
            //headerText.Border.RightLine.Width = 2.0f;
            //headerText.Border.BottomLine.Width = 3.0f;
            //headerText.Text = "Table text";
            ////page.PageHeader.Objects.Add(headerText);



            DataBand band = new DataBand();
            page.Bands.Add(band);
            band.CreateUniqueName();
            //band.DataSource = report.Report.GetDataSource("Lijekovi");
            band.Height = 0.5f * Units.Centimeters;
            band.FillColor = Color.Yellow;


            TextObject bandText = new TextObject();
            bandText.CreateUniqueName();
            bandText.HorzAlign = HorzAlign.Center;
            bandText.Bounds = new RectangleF(0.0f * Units.Centimeters, 0.0f * Units.Centimeters, 2.5f * Units.Centimeters, 0.5f * Units.Centimeters);
            bandText.Border.Lines = BorderLines.All;
            bandText.Text = "NEKI TEXT ";//"[Lijekovi.Id]";
            band.AddChild(bandText);

    
            bandText.Parent = band;



            //////////////////////////////////////////////// F O O T E R ////////////////////////////////////////////////////

            page.PageFooter = new PageFooterBand();
            page.PageFooter.CreateUniqueName();
            page.PageFooter.Height = 1.5f * Units.Centimeters;
            page.PageFooter.FillColor = Color.Blue;

            TextObject footerText = new TextObject();
            footerText.CreateUniqueName();
            footerText.HorzAlign = HorzAlign.Center;
            footerText.VertAlign = VertAlign.Center;
            footerText.Bounds = new RectangleF(0.0f, 0.0f, 19.0f * Units.Centimeters, 0.5f * Units.Centimeters);
            //footerText.TextColor = Color.Teal;
            //footerText.FillColor = Color.YellowGreen;
            //footerText.Border.Lines = BorderLines.All;
            //footerText.Border.TopLine.Color = Color.Indigo;
            //footerText.Border.LeftLine.Color = Color.Gold;
            //footerText.Border.RightLine.Color = Color.Gold;
            //footerText.Border.BottomLine.Color = Color.Indigo;
            //footerText.Border.TopLine.Width = 3.0f;
            //footerText.Border.LeftLine.Width = 2.0f;
            //footerText.Border.RightLine.Width = 2.0f;
            //footerText.Border.BottomLine.Width = 3.0f;
            footerText.Border.Lines = BorderLines.All;
            footerText.Text = "FOOTER TEXT";
            page.PageFooter.Objects.Add(footerText);


            ViewBag.Report = report;

            return View("Report");
        }
    }
}
