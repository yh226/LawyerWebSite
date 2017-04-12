using LawyerWbSite.DAL;
using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LawyerWbSite.Controllers
{
    public class UploadFileController : Controller
    {
        LawyerOfficeContext_test db = new LawyerOfficeContext_test();
        //       [HttpPost]
        [Authorize]
        public ActionResult Index()//[Bind(Include = "DocumentID,DocumentName,DocumentPath,LawyerUsername,CaseName")] Document document)
        {

            var getLawyer = db.Lawyers.ToList();
            SelectList LawyerList = new SelectList(getLawyer, "LawyerID", "Username");
            ViewBag.DropDownLawyerList = LawyerList;//new SelectList(new[] { "-" });

            var getCase = db.Cases.ToList();
            SelectList CaseList = new SelectList(getCase, "CaseID", "CaseName");
            ViewBag.DropDownCaseList = CaseList;//new SelectList(new[] { "-" });
            //foreach (string upload in Request.Files)
            //{
            //    if (Request.Files[upload].FileName != "")
            //    {
            //        string path = AppDomain.CurrentDomain.BaseDirectory + "/App_Data/uploads/";
            //        string filename = Path.GetFileName(Request.Files[upload].FileName);
            //        Request.Files[upload].SaveAs(Path.Combine(path, filename));

            //        //upload into sql
            //        Document document = new Document();

            //        document.DocumentPath = path;
            //        document.DocumentName = filename;


            //        db.Documents.Add(document);

            //        db.SaveChanges();
            //    }
            //}
            return View();// ("Upload");
        }


        public ActionResult Downloads()
        {
            var dir = new System.IO.DirectoryInfo(Server.MapPath("~/App_Data/files/"));
            System.IO.FileInfo[] fileNames = dir.GetFiles("*.*"); List<string> items = new List<string>();
            foreach (var file in fileNames)
            {
                items.Add(file.Name);
            }
            return View(items);
        }

        public FileResult Download(string ImageName)
        {
            var FileVirtualPath = "~/App_Data/files/" + ImageName;
            return File(FileVirtualPath, "application/force-download", Path.GetFileName(FileVirtualPath));
        }


        //// GET: UploadFile
        //public ActionResult Index(HttpPostedFileBase file)
        //{

        //    ViewBag.Message = "index";
        //    try
        //    {
        //        if (file.ContentLength > 0)
        //        {
        //            var fileName = Path.GetFileName(file.FileName);
        //            var path = Path.Combine(Server.MapPath("~/App_Data/files"), fileName);
        //            file.SaveAs(path);
        //        }
        //        ViewBag.message = "Upload successful";
        //        return View();
        //        //return RedirectToAction("Index", "UploadFile");
        //    }
        //    catch
        //    {

        //        ViewBag.Message = "Upload failed";
        //        return View();
        //        //return RedirectToAction("Index", "UploadFile");
        //    }


        //    //return View();
        //}



        [HttpPost]
        public ActionResult Index(Document document,HttpPostedFileBase file)//,[Bind(Include = "LawyerUsername,CaseName")] Document document)
        {
           
            //ViewBag.Message = "Upload";
            try
            {
                if (file.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(file.FileName);
                    string path = Path.Combine(Server.MapPath("~/App_Data/files"), fileName);
                         
                    document.DocumentName = file.FileName;
                    //get the lawyer username from dropdown list
                    string selectLawyerID = Request.Form["LawyerUsername_DropDown"].ToString();
                    var LawyerList = db.Lawyers.ToList();
                    for (int i=0;i< LawyerList.Count;i++)
                    {
                        if (LawyerList[i].LawyerID.ToString().Equals(selectLawyerID))
                        {
                            document.LawyerUsername = LawyerList[i].Username;
                            break;
                        }
                    }
                    //get the case name from dropdown list
                    string selectCaseID = Request.Form["Case_DropDow"].ToString();
                    var CaseList = db.Cases.ToList();
                    for (int i = 0; i < CaseList.Count; i++)
                    {
                        if (CaseList[i].CaseID.ToString().Equals(selectCaseID))
                        {
                            document.CaseName = CaseList[i].CaseName;
                            break;
                        }
                    }


                    db.Documents.Add(document);
                    db.SaveChanges();

                    file.SaveAs(path);

                }
               // ss = "Upload successful";
                ViewBag.message = "Upload successful";
                return RedirectToAction("Index", "Document");
            }
            catch
            {
               // ss = "Upload successful";
                ViewBag.Message = "Upload failed";
                return RedirectToAction("Index", "Document");
            }

            //return View("Upload");
        }



    }
}