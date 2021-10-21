using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EXP_2_Views.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult List()
        {
            // db den tüm kategorileri çek view'a gönder.
            return View();
        }
        public ActionResult Index()
        {
            // db den tüm kategorileri çek view'a gönder.
            return View("List");
        }
    }
}