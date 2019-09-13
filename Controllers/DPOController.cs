using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValuPat.Controllers
{
    public class DPOController : Controller
    {
        // GET: DPO
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddDPO()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDPO(C00_P01_DPO model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ValueDatabaseEntities context = new ValueDatabaseEntities();
                    context.C00_P01_DPO.Add(model);
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
