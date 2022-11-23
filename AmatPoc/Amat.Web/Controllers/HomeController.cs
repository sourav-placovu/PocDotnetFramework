using Amat.Core;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Amat.Web.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public async Task<ActionResult> Index()
        {
            var context = new AmatEntities();
            var data = await context.CatalogItems.ToListAsync();
            _log.Info("hey");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            _log.Info("hey");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            _log.Info("hey");
            return View();
        }
    }
}