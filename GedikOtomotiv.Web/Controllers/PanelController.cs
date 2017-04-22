using GedikOtomotiv.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GedikOtomotiv.Web.Controllers
{
    public class PanelController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ToplamArac = AracRepo.GetAll().Count;

            ViewBag.Kiralanmis = AracRepo.GetAll().
                Where(a => a.Kiralandimi == true).ToList().Count;

            ViewBag.Musteri = MusteriRepo.GetAll().Count;

            return View();
        }
    }
}