using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdemo.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new calc());
        }
        [HttpPost]
        public ActionResult Index(calc c, string calculate)
        {
            if (calculate == "add")
            {
                c.total = c.no1 + c.no2;
            }
            else if (calculate == "min")
            {
                c.total = c.no1 - c.no2;
            }
            else if (calculate == "sub")
            {
                c.total = c.no1 * c.no2;
            }
            else
            {
                c.total = c.no1 / c.no2;
            }
            return View(c);

        }

    }
}