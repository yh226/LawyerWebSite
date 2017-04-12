using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LawyerWbSite.DAL;
using LawyerWbSite.Models;

namespace LawyerWbSite.Controllers
{
    public class LawyerController : Controller
    {
        private LawyerOfficeContext_test db = new LawyerOfficeContext_test();

        // GET: Lawyer
        [Authorize]
        public ActionResult Index()
        {
            return View(db.Lawyers.ToList());
        }

        // GET: Lawyer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lawyer lawyer = db.Lawyers.Find(id);
            if (lawyer == null)
            {
                return HttpNotFound();
            }
            return View(lawyer);
        }

        // GET: Lawyer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lawyer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LawyerID,LastName,FirstName,Username,Password")] Lawyer lawyer)
        {
            if (ModelState.IsValid)
            {
                db.Lawyers.Add(lawyer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lawyer);
        }

        // GET: Lawyer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lawyer lawyer = db.Lawyers.Find(id);
            if (lawyer == null)
            {
                return HttpNotFound();
            }
            return View(lawyer);
        }

        // POST: Lawyer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LawyerID,LastName,FirstName,Username,Password")] Lawyer lawyer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lawyer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lawyer);
        }

        // GET: Lawyer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lawyer lawyer = db.Lawyers.Find(id);
            if (lawyer == null)
            {
                return HttpNotFound();
            }
            return View(lawyer);
        }

        // POST: Lawyer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lawyer lawyer = db.Lawyers.Find(id);
            db.Lawyers.Remove(lawyer);
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
