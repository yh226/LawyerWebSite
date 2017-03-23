
using LawyerWbSite.DAL;
using LawyerWbSite.DBL;
using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LawyerWbSite.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
          
            //Case_BusinessLayer caseBAL = new Case_BusinessLayer();
            //Customer_BusinessLayer customerBAL = new Customer_BusinessLayer();
            //Document_BusinessLayer documentBAL= new Document_BusinessLayer();
            //Administrator_BusinessLayer administratorBAL = new Administrator_BusinessLayer();
            //Lawyer_BusinessLayer lawyerBAL = new Lawyer_BusinessLayer();

            ////
            //List<Administrator> assignmentList = administratorBAL.GetAdministrators();
            //List<Customer> customeList = customerBAL.GetCustomers();
            //List<Document> socumenttList = documentBAL.GetDocuments();
            //List<Case> caseList = caseBAL.GetCases();
            //List<Lawyer> lawyerList = lawyerBAL.GetLawyers();

            //CaseContext_Test4 db = new CaseContext_Test4();
            //var gg = db.Cases.Include(b => b.);


            //caseBusinessLayer.GetCases();
            //customerBusinessLayer.GetCustomers();
            //documentBusinessLayer.GetDocuments();
            //administratorBusinessLayer.GetAdministrators();
            //lawyerBusinessLayer.GetLawyers();
            // var myAdministrators = db.Administrators.ToList();



            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}