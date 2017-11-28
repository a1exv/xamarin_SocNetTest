using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SocNetLibrary;

namespace SocNetWeb.Controllers
{
    public class SocNetController : Controller
    {
        
        // GET: SocNet
        public ActionResult Index()
        {
            return View();
        }
    }
}