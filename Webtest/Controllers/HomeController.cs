using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webtest.Models;
namespace Webtest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Electronics()
        {
            return View();
        }
        public ActionResult Fashion()
        {
            return View();
        }
        public ActionResult Jewellery()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(tblRegistration obj)
        {
            if(ModelState.IsValid)
            {
                RegMVCEntities2 db = new RegMVCEntities2();
                db.tblRegistrations.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(tblRegistration obj)
        {
            if(ModelState.IsValid)
            {
                using (RegMVCEntities2 db = new RegMVCEntities2())
                {
                    var obj1 = db.tblRegistrations.Where(a => a.FName.Equals(obj.FName) && a.Password.Equals(obj.Password)).FirstOrDefault();
                    if(obj1 != null)
                    {
                    
                        return RedirectToAction("Index");

                    }
                }
            }
            return View(obj);
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact obj)
        {
            if (ModelState.IsValid)
            {
                RegMVCEntities3 db = new RegMVCEntities3();
                db.Contacts.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }

    }
 }