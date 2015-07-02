using SalaoNaWeb.Migrations;
using SalaoNaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalaoNaWeb.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        private Contexto db = new Contexto();

        // GET api/Event

        public ActionResult Index()
        {
            return View();
        }
        public IQueryable GetEvents()
        {
            return db.Events;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}