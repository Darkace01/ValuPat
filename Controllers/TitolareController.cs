using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValuPat.Controllers
{
    public class TitolareController : Controller
    {
        // GET: Titolare
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddTitolare()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTitolare(C00_P02_Titolare model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ValueDatabaseEntities context = new ValueDatabaseEntities();
                    context.C00_P02_Titolare.Add(model);
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