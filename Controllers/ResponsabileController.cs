using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValuPat.Controllers
{
    public class ResponsabileController : Controller
    {
        // GET: Responsabile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddResponsabile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddResponsabile(C00_P04_Responsabile model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ValueDatabaseEntities context = new ValueDatabaseEntities();
                    context.C00_P04_Responsabile.Add(model);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            return View();
        }
    }
}