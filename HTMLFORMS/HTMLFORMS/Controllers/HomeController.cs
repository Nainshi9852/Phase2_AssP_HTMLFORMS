using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Xml.Linq;

namespace HTMLFORMS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FormGet()
        {
            ViewData["name"] = Request.QueryString["name"].ToString();
            ViewData["email"] = Request.QueryString["email"].ToString();
            ViewData["class"] = Request.QueryString["class"].ToString();
            ViewData["address"] = Request.QueryString["address"].ToString();
            return View();
        }
        [HttpPost]
        public ActionResult FormPost(string name, string address, string email, string whichclass)
        {
            ViewData["name"] = name;
            ViewData["email"] = email;
            ViewData["class"] = whichclass;
            ViewData["address"] = address;
            return View();
        }
    }
}