using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCproject.Models;

namespace MVCproject.Controllers
{
    public class TableBookingController : Controller
    {
        // GET: TableBooking
        //[HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TableRes tblres)
        {
            SqldbInterface sqldb = new SqldbInterface();
            if (sqldb.TableReservation(tblres))
            {
                Response.Redirect("/TableBooking");
            }

            return View();
        }
    }
}