using LawyerWbSite.DAL;
using LawyerWbSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LawyerWbSite.DBL
{
    public class Document_BusinessLayer
    {
        public List<Document> GetDocuments()
        {
            DocumentContext_Test4 db = new DocumentContext_Test4();
            
            return db.Documents.ToList();

        }

        public Document SaveCase(Document Myobject)
        {
            DocumentContext_Test4 db = new DocumentContext_Test4();
            db.Documents.Add(Myobject);
            db.SaveChanges();
            return Myobject;
        }
    }
}