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
using System.Text.RegularExpressions;

namespace LawyerWbSite.Controllers
{
    public class CaseController : Controller
    {
        private LawyerOfficeContext_test db = new LawyerOfficeContext_test();

        // GET: Case
        public ActionResult Index()
        {
            var getLawyer = db.Lawyers.ToList();
            SelectList LawyerList = new SelectList(getLawyer, "LawyerID", "Username");
            ViewBag.DropDownLawyerList = LawyerList;//new SelectList(new[] { "-" });

            return View(db.Cases.ToList());
        }

        // GET: Case/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Case @case = db.Cases.Find(id);
            if (@case == null)
            {
                return HttpNotFound();
            }
            return View(@case);
        }

        // GET: Case/Create
        public ActionResult Create()
        {
            var getLawyer = db.Lawyers.ToList();
            SelectList LawyerList = new SelectList(getLawyer, "LawyerID", "Username");
            ViewBag.DropDownLawyerList = LawyerList;//new SelectList(new[] { "-" });

            var getCustomer = db.Customers.ToList();
            SelectList CustomerList = new SelectList(getCustomer, "CustomerID", "LastName");
            ViewBag.DropDown_CustomerList = CustomerList;//new SelectList(new[] { "-" });

            return View();
        }

        // POST: Case/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CaseID,CaseName,Describe,StartDate,EndDate,LawyerName,CustomerName")] Case @case)
        {
            if (ModelState.IsValid)
            {
                //get the lawyer username from dropdown list
                string selectLawyerID = Request.Form["LawyerUsername_DropDown"].ToString();
                var LawyerList = db.Lawyers.ToList();
                for (int i = 0; i < LawyerList.Count; i++)
                {
                    if (LawyerList[i].LawyerID.ToString().Equals(selectLawyerID))
                    {
                        @case.LawyerName = LawyerList[i].Username;
                        break;
                    }
                }

                //get the case name from dropdown list
                string selectCustomerID = Request.Form["Customer_DropDown"].ToString();
                var CustomerList = db.Customers.ToList();
                for (int i = 0; i < CustomerList.Count; i++)
                {
                    if (CustomerList[i].CustomerID.ToString().Equals(selectCustomerID))
                    {
                        @case.CustomerName = CustomerList[i].LastName;
                        break;
                    }
                }



                db.Cases.Add(@case);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(@case);
        }

        // GET: Case/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Case @case = db.Cases.Find(id);
            if (@case == null)
            {
                return HttpNotFound();
            }
            return View(@case);
        }

        // POST: Case/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CaseID,CaseName,Describe,StartDate,EndDate,LawyerName,CustomerName")] Case @case)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@case).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(@case);
        }

        // GET: Case/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Case @case = db.Cases.Find(id);
            if (@case == null)
            {
                return HttpNotFound();
            }
            return View(@case);
        }

        // POST: Case/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Case @case = db.Cases.Find(id);
            db.Cases.Remove(@case);
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

        public ActionResult LawyerName(string firstName)
        {
            List<Case> Cases = db.Cases.Where(s => s.LawyerName == firstName).ToList();
           // return RedirectToAction("Details", "Lawyer",new { @FirstName = firstName });
            return View(Cases);
        }

        public ActionResult CustomerName(string firstName)
        {
  
            List<Case> Cases = db.Cases.Where(s => s.CustomerName == firstName).ToList();
            // return RedirectToAction("Details", "Lawyer",new { @FirstName = firstName });
            return View(Cases);
        }
    }
}
