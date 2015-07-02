using DHTMLX.Common;
using DHTMLX.Scheduler;
using DHTMLX.Scheduler.Controls;
using DHTMLX.Scheduler.Data;
using SalaoNaWeb.Migrations;
using SalaoNaWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalaoNaWeb.Controllers
{
    public class CalendarioController : Controller
    {
        public Contexto db = new Contexto();

        //
        // GET: /Home/
        public ActionResult Index()
        {
            var scheduler = new DHXScheduler(this);
            scheduler.Skin = DHXScheduler.Skins.Flat;

            var ano = new YearView();
            scheduler.Views.Add(ano);

            //var agendasemanal = new WeekAgendaView();
            //scheduler.Views.Add(agendasemanal);

            //var mapa = new MapView();
            //scheduler.Views.Add(mapa);

            
            scheduler.Config.first_hour = 6;
            scheduler.Config.last_hour = 20;
            scheduler.Lightbox.Add(new LightboxText("textEmpresa", "Informe o salão:"));
            scheduler.Lightbox.Add(new LightboxText("textServico", "Informe o tipo de serviço:"));
            scheduler.Lightbox.Add(new LightboxTime("textTempo", "Informe o horário desejado:"));
            
            scheduler.EnableDynamicLoading(SchedulerDataLoader.DynamicalLoadingMode.Week);
            scheduler.LoadData = true;
            scheduler.EnableDataprocessor = false;
            scheduler.Localization.Set(SchedulerLocalization.Localizations.Portuguese);

            
            return View(scheduler);
        }

        public ContentResult Data(DateTime from, DateTime to)
        {
            var apps = db.Calendario.Where(e => e.StartDate < to && e.EndDate >= from).ToList();
            return new SchedulerAjaxData(apps);
        }
        public ContentResult Save(int? id, FormCollection actionValues)
        {
            var action = new DataAction(actionValues);

            try
            {
                var changedEvent = DHXEventsHelper.Bind<Calendario>(actionValues, new System.Globalization.CultureInfo("pt-BR"));
                switch (action.Type)
                {
                    case DataActionTypes.Insert:
                        db.Calendario.Add(changedEvent);
                        break;
                    case DataActionTypes.Delete:
                        db.Entry(changedEvent).State = EntityState.Deleted;
                        break;
                    default:// "update"  
                        db.Entry(changedEvent).State = EntityState.Modified;
                        break;
                }
                db.SaveChanges();
                action.TargetId = changedEvent.Id;
            }
            catch (Exception a)
            {
                action.Type = DataActionTypes.Error;
            }

            return (new AjaxSaveResponse(action));
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}