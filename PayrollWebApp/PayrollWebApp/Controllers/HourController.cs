using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PayrollWebApp.Models;

namespace PayrollWebApp.Controllers
{
    public class HourController : Controller
    {
        private PayrollEntities db = new PayrollEntities();

        // GET: Hour
        public ActionResult Index()
        {
            var hours = db.Hours.Include(h => h.Employee);
            return View(hours.ToList());
        }

        // GET: Hour/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hour hour = db.Hours.Find(id);
            if (hour == null)
            {
                return HttpNotFound();
            }
            return View(hour);
        }

        // GET: Hour/Create
        public ActionResult Create()
        {
            ViewBag.EmpID = new SelectList(db.Employees, "ID", "FirstName");
            return View();
        }

        // POST: Hour/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,EmpID,Regular_Hours,Overtime_Hours,Holiday,PTO,Vacation,DateTime")] Hour hour)
        {
            if (ModelState.IsValid)
            {
                db.Hours.Add(hour);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmpID = new SelectList(db.Employees, "ID", "FirstName", hour.EmpID);
            return View(hour);
        }

        // GET: Hour/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hour hour = db.Hours.Find(id);
            if (hour == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmpID = new SelectList(db.Employees, "ID", "FirstName", hour.EmpID);
            return View(hour);
        }

        // POST: Hour/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,EmpID,Regular_Hours,Overtime_Hours,Holiday,PTO,Vacation,DateTime")] Hour hour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmpID = new SelectList(db.Employees, "ID", "FirstName", hour.EmpID);
            return View(hour);
        }

        // GET: Hour/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hour hour = db.Hours.Find(id);
            if (hour == null)
            {
                return HttpNotFound();
            }
            return View(hour);
        }

        // POST: Hour/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hour hour = db.Hours.Find(id);
            db.Hours.Remove(hour);
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
