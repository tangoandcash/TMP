using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NIPQuest.DAL;
using NIPQuest.Models;
using System.Web.Script.Serialization;



namespace NIPQuest.Controllers
{
    public class CompanyController : Controller
    {
        private CompanyContext db = new CompanyContext();

        // GET: Company
        public ActionResult Index()
        {
            return View(db.CompanyTable.ToList());
        }

        // GET: Company/Details/5
        [HttpGet]
        public ActionResult Details(string id)
        {
            ////Wpis do bazy 
            LogInfo NewRow = new LogInfo();
            NewRow.NumberNIP = id;
            NewRow.logDate = DateTime.Now.Date.ToString();
            NewRow.Connection =  Request.Headers[0].ToString();
            NewRow.Accept = Request.Headers[1].ToString();
            NewRow.Accept_Encoding = Request.Headers[2].ToString();
            NewRow.Accept_Language = Request.Headers[3].ToString();
            NewRow.Cookie =  Request.Headers[4].ToString();
            NewRow.Host = Request.Headers[5].ToString();
            NewRow.Referer = Request.Headers[6].ToString();
            NewRow.User_Agent = Request.Headers[7].ToString();
            db.LogInfoTable.Add(NewRow);
            db.SaveChanges();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //// Szukanie wiersza z danym numerem NIP i sparsowanie ustalonego formatu
            string parsedNIP = NIPQuest.HelpModule.ValidatorClass.GetNIP(id);
            Company company =
                    db.CompanyTable.FirstOrDefault(x => x.NIP == parsedNIP); 
            if (company == null)
            {
                     return Json("brak info", JsonRequestBehavior.AllowGet);
            }

            return Json(company, JsonRequestBehavior.AllowGet);
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
