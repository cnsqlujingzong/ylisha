using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YiLiSha.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Login()
        {
            return View();
        }
        //后台首页
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductList()
        {
            return View();
        }
        public ActionResult ProductAdd()
        {
            return View();
        }
        public ActionResult AccountList()
        {
            return View();
        }
        public ActionResult AccountAdd()
        {
            return View();
        }
    }
}
