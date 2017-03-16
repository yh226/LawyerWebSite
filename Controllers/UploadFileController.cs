using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace LawyerWbSite.Controllers
{
    public class UploadFileController : Controller
    {
      
        public ActionResult Index()
        {
            foreach (string upload in Request.Files)
            {
                if (Request.Files[upload].FileName != "")
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + "/App_Data/uploads/";
                    string filename = Path.GetFileName(Request.Files[upload].FileName);
                    Request.Files[upload].SaveAs(Path.Combine(path, filename));
                }
            }
            return View("Upload");
        }


        public ActionResult Downloads()
        {
            var dir = new System.IO.DirectoryInfo(Server.MapPath("~/App_Data/uploads/"));
            System.IO.FileInfo[] fileNames = dir.GetFiles("*.*"); List<string> items = new List<string>();
            foreach (var file in fileNames)
            {
                items.Add(file.Name);
            }
            return View(items);
        }

        public FileResult Download(string ImageName)
        {
            var FileVirtualPath = "~/App_Data/uploads/" + ImageName;
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



        //[HttpPost]
        //public ActionResult Upload(HttpPostedFileBase file)
        //{
        //    string ss;
        //    //ViewBag.Message = "Upload";
        //    try
        //    {
        //        if (file.ContentLength > 0)
        //        {
        //            var fileName = Path.GetFileName(file.FileName);
        //            var path = Path.Combine(Server.MapPath("~/App_Data/files"), fileName);
        //            file.SaveAs(path);
        //        }
        //        ss= "Upload successful";
        //        ViewBag.message = "Upload successful";
        //        return RedirectToAction("Index","UploadFile",ss);
        //    }
        //    catch
        //    {
        //        ss = "Upload successful";
        //        ViewBag.Message = "Upload failed";
        //        return RedirectToAction("Index", "UploadFile",ss);
        //    }
        //}



    }
}