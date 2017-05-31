using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FancyOrder.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Order/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Order/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        

        public ActionResult List(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                value = DateTime.Now.ToString("yyyy-MM-dd");

            }
            var list = FancyOrder.Models.fancyOrder.GetListByProperty(a => a.OrderTime, value);
            return View(list);
        }

        public ActionResult Confirm()
        {
            return View();
        }
        
    }
}
