using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        Database1Entities db = new Database1Entities();
        public ActionResult _Index()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(VMLogin login )
        {
            var user = db.Table.Where(u => u.account == login.Account && u.passeard == login.passeard).FirstOrDefault();
            var account = db.Table.Where(u => u.account == login.Account) .FirstOrDefault();
            var passeard = db.Table.Where(u => u.passeard == login.passeard).FirstOrDefault();
            if (account == null)
            {
                ViewBag.ErrMsg1 = "查無帳號";
                return View();
            }
            else {
                if (passeard == null)
                {
                    ViewBag.ErrMsg2 = "密碼錯誤";
                    return View();
                }
            }
            

            if (user == null)
            {
                ViewBag.ErrMsg = "輸入的格式有誤";
                return View();
            }

            Session["user"] = user;
            Session["acc"] = user.account;
            return RedirectToAction("_Index");
        }

        public ActionResult Logout()
        {
            Session["user"] = null;
            return RedirectToAction("/Home/Login");
        }


        public ActionResult Email()
        {
            

            return View();
        }
        [HttpPost]
        public ActionResult Email(VMMembers Members)
        {
            var email = db.Table.Where(u => u.email == Members.email).FirstOrDefault();
            var passeard = db.Table.Where(u => u.passeard == Members.passeard).FirstOrDefault();
            if (email == null)
            {
                TempData["message"] = "查無此資料";
                ViewBag.em = "123";
                return View("Email");
            }
            else
            {
                ViewBag.em = "456";
                TempData["message"] = email.passeard;
            }

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