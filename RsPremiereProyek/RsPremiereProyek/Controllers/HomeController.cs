using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RsPremiereProyek.Models;
namespace RsPremiereProyek.Controllers
{
    public class HomeController : Controller
    {
        DbproyekteknetEntities1 db = new DbproyekteknetEntities1();

        // GET: Home
        public ActionResult Index()
        {
            /* if (Session["IdUsSS"] != null)
             {
                 return View(db.TBLPesertaInfoes.ToList());
             }
             else
             {
                 return RedirectToAction("login", "Home");
             }*/
            /*return View(db.TBLPesertaInfoes.ToList());*/
            /*return RedirectToAction("login", "Home");*/
            return View(db.TBLUserInfoes.ToList());
        }
        public ActionResult Singup()
        {
            return View();
        }

        public ActionResult Awal()
        {
            return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        public ActionResult Singup(TBLUserInfo tblUserInfo)
        {
            if (db.TBLUserInfoes.Any(x => x.UsernameUs == tblUserInfo.UsernameUs))
            {
                ViewBag.Notification = "This Account has Already existed";
                return View();
            }
            else
            {
                db.TBLUserInfoes.Add(tblUserInfo);
                db.SaveChanges();

                Session["IdUsSS"] = tblUserInfo.IdUs.ToString();
                Session["UsernameSS"] = tblUserInfo.UsernameUs.ToString();
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult logout()
        {
            Session.Clear();
            return RedirectToAction("login", "Home");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(TBLUserInfo tblUserInfo)
        {
            var checkLogin = db.TBLUserInfoes.Where(x => x.UsernameUs.Equals(tblUserInfo.UsernameUs) && x.PasswordUs.Equals(tblUserInfo.PasswordUs)).FirstOrDefault();
            if (checkLogin != null)
            {
                Session["IduSS"] = tblUserInfo.IdUs.ToString();
                Session["UsernameSS"] = tblUserInfo.UsernameUs.ToString();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Notification = "Wrong Username or Password";
            }
            return View();
        }

    }
}