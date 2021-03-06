﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SalaoNaWeb.Models;
using SalaoNaWeb.Migrations;

namespace SalaoNaWeb.Controllers
{
    public class AgendaController : Controller
    {
        private Contexto db = new Contexto();

        // GET: /Agenda/
        public ActionResult Index()
        {
            var agendas = db.Agendas.Include(a => a.Empresa).Include(a => a.Funcionario).Include(a => a.Servico);
            return View(agendas.ToList());
        }

        // GET: /Agenda/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agenda agenda = db.Agendas.Find(id);
            if (agenda == null)
            {
                return HttpNotFound();
            }
            return View(agenda);
        }

        // GET: /Agenda/Create
        public ActionResult Create()
        {
            ViewBag.empId = new SelectList(db.Empresas, "empId", "razSoc");
            ViewBag.funcId = new SelectList(db.Funcionarios, "funcId", "nomeFunc");
            ViewBag.servId = new SelectList(db.Servicos, "servId", "nomeServ");
            return View();
        }

        // POST: /Agenda/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ageId,empId,servId,valorServ,funcId,dataHoraInicio, dataHoraFim")] Agenda agenda)
        {
            if (ModelState.IsValid)
            {
                db.Agendas.Add(agenda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.empId = new SelectList(db.Empresas, "empId", "razSoc", agenda.empId);
            ViewBag.funcId = new SelectList(db.Funcionarios, "funcId", "nomeFunc", agenda.funcId);
            ViewBag.servId = new SelectList(db.Servicos, "servId", "nomeServ", agenda.servId);
            return View(agenda);
        }

        // GET: /Agenda/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agenda agenda = db.Agendas.Find(id);
            if (agenda == null)
            {
                return HttpNotFound();
            }
            ViewBag.empId = new SelectList(db.Empresas, "empId", "razSoc", agenda.empId);
            ViewBag.funcId = new SelectList(db.Funcionarios, "funcId", "nomeFunc", agenda.funcId);
            ViewBag.servId = new SelectList(db.Servicos, "servId", "nomeServ", agenda.servId);
            return View(agenda);
        }

        // POST: /Agenda/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ageId,empId,servId,valorServ,funcId,dataHoraInicio, dataHoraFim")] Agenda agenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agenda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.empId = new SelectList(db.Empresas, "empId", "razSoc", agenda.empId);
            ViewBag.funcId = new SelectList(db.Funcionarios, "funcId", "nomeFunc", agenda.funcId);
            ViewBag.servId = new SelectList(db.Servicos, "servId", "nomeServ", agenda.servId);
            return View(agenda);
        }

        // GET: /Agenda/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agenda agenda = db.Agendas.Find(id);
            if (agenda == null)
            {
                return HttpNotFound();
            }
            return View(agenda);
        }

        // POST: /Agenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Agenda agenda = db.Agendas.Find(id);
            db.Agendas.Remove(agenda);
            db.SaveChanges();
            return RedirectToAction("Index");
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
