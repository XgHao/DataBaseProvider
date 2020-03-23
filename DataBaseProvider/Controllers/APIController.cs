using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataBaseProvider.Controllers
{
    public class APIController : Controller
    {
        // GET: API
        public ActionResult Customers()
        {
            return View();
        }
    }
}