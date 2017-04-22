using GedikOtomotiv.DAL.Repository;
using GedikOtomotiv.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GedikOtomotiv.Web.Controllers
{
    public class AracController : Controller
    {
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(VMArac model)
        {
            AracRepo.Add(model);
            return RedirectToAction("TumAraclar");
        }

        public ActionResult TumAraclar()
        {
            var result = AracRepo.GetAll();
            return View(result);
        }

        [HttpPost]
        public ActionResult TumAraclar(VMKira model)
        {
            AracRepo.Rent(model);
            return RedirectToAction("TumAraclar");
        }

        public ActionResult AracSil(int id)
        {
            AracRepo.Delete(id);
            return RedirectToAction("TumAraclar");
        }
    }
}