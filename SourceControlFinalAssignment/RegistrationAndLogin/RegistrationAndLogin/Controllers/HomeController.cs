using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Mvc;
using RegistrationAndLogin.Models;
using System.Security.Cryptography;
using log4net;

namespace RegistrationAndLogin.Controllers
{
    public class HomeController : Controller
    {
        //Log4net 
        private static log4net.ILog Log { get; set; }

        ILog log = log4net.LogManager.GetLogger(typeof(HomeController));

        private DB_Entities _db = new DB_Entities();
        
        // GET: Home
        public ActionResult Index()
        {
            //log4net
            try
            {
                log.Debug("Debug Message");
                log.Warn("Warn Message");
                log.Error("Error Message");
                log.Fatal("Fatal Message");
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            finally
            { }

            //Login
            if (Session["idUser"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }

            
        }
        /*
         * REGISTER
         */
        public ActionResult Register()
        {
            return View();
        }

        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User _user)
        {
            if (ModelState.IsValid)
            {
                var check = _db.Users.FirstOrDefault(s => s.Email == _user.Email);
                if (check == null)
                {
                    _user.Password = GetMD5(_user.Password);
                    _db.Configuration.ValidateOnSaveEnabled = false;
                    _db.Users.Add(_user);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Email already exists";
                    return View();
                }


            }
            return View();


        }
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }

        /*
         LOGIN
         */
        public ActionResult Login() 
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Login(UserLogin userLogin)
        {
            if (ModelState.IsValid)
            {


                var f_password = GetMD5(userLogin.Password);
                var data = _db.Users.Where(s => s.Email.Equals(userLogin.Email) && s.Password.Equals(f_password)).ToList();
                if (data.Count() > 0)
                {
                    //add session
                    Session["FullName"] = data.FirstOrDefault().FirstName + " " + data.FirstOrDefault().LastName;
                    Session["Email"] = data.FirstOrDefault().Email;
                    Session["LastName"] = data.FirstOrDefault().LastName;
                    Session["Age"] = data.FirstOrDefault().Age;
                    Session["ContactNo"] = data.FirstOrDefault().ContactNo;
                    Session["idUser"] = data.FirstOrDefault().idUser;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Login");
                }
            }
            return View();
        }
        



        //Logout
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Login");
        }

        
    }
}