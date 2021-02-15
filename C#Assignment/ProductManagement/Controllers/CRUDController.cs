using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductManagement.Models;
using System.Net.Http;
using System.IO;
using PagedList.Mvc;
using PagedList;
using System.Data.SqlClient;
using System.Configuration;
using AutoMapper;

namespace ProductManagement.Controllers
{
    
    public class CRUDController : Controller
    {

        ProductDBEntities pd = new ProductDBEntities();
        // GET: CRUD
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginClass lg)
        {
            if (ModelState.IsValid)
            {
                var data = pd.tblLogins.Where(s => s.EmailId.Equals(lg.EmailId) && s.Password.Equals(lg.Password)).ToList();
                if (data.Count() > 0)
                {
                    Session["Name"] = data.FirstOrDefault().Name;
                    Session["EmailId"] = data.FirstOrDefault().EmailId;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Login Failed";
                    return RedirectToAction("Login");
                }
            }
            return View();
        }

        [Route("ProductList")]
        public ActionResult ProductList(int? i)
        {
            List<tblProduct> listprd = pd.tblProducts.ToList();
            
            IEnumerable<tblProduct> productobj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44324/api/ProductCrud");


            var consumeapi = hc.GetAsync("ProductCrud");
            consumeapi.Wait();

            var readdata = consumeapi.Result;
            if (readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<IList<tblProduct>>();
                displaydata.Wait();

                productobj = displaydata.Result;
            }
            return View(productobj.ToList().ToPagedList(i ?? 1,3));
        }
        [HttpPost]
        [Route("ProductList")]
        public ActionResult ProductList(FormCollection formCollection)
        {
            string[] ids = formCollection["prdids"].Split(new char[] {','});
            foreach (string id in ids)
            {
                var product = this.pd.tblProducts.Find(int.Parse(id));
                this.pd.tblProducts.Remove(product);
                this.pd.SaveChanges();
            }
            return RedirectToAction("ProductList");
        }
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(HttpPostedFileBase file, HttpPostedFileBase file1, tblProduct insertprd)
        {
            string filename = Path.GetFileName(file.FileName);
            string _filename = DateTime.Now.ToString("yymmssfff") + filename;
            string extension = Path.GetExtension(file.FileName);
            string path = Path.Combine(Server.MapPath("~/Image/"), _filename);
            insertprd.SmallImage = "~/Image/" + _filename;

            string filename1 = Path.GetFileName(file1.FileName);
            string _filename1 = DateTime.Now.ToString("yymmssfff") + filename1;
            string extension1 = Path.GetExtension(file1.FileName);
            string path1 = Path.Combine(Server.MapPath("~/Image/"), _filename1);
            insertprd.LargeImage = "~/Image/" + _filename1;

            if ((extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png") && (extension1.ToLower() == ".jpg" || extension1.ToLower() == ".jpeg" || extension1.ToLower() == ".png"))
            {
                if (file.ContentLength <= 1000000 && file1.ContentLength <= 1000000)
                {
                    pd.tblProducts.Add(insertprd);
                    if (pd.SaveChanges() > 0)
                    {
                        file.SaveAs(path);
                        file1.SaveAs(path1);
                        ViewBag.msg = "Record Added";
                        ModelState.Clear();
                    }
                }
                else
                {
                    ViewBag.msg = "Size is not valid";
                }

            }
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44324/api/ProductCrud");

            var insertrecord = hc.PostAsJsonAsync<tblProduct>("ProductCrud", insertprd);
            insertrecord.Wait();

            var savedata = insertrecord.Result;
            
            ViewBag.tblProducts = new SelectList(pd.tblProducts,"Id","Name");


            if (savedata.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Saved SucessFully";
                return RedirectToAction("ProductList");
            }
            return View("ProductList");
        }
        [Route("Edit")]
        public ActionResult Edit(int id)
        {
            ProductClass prdobject = null;

            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44324/api/");

            var consumeapi = hc.GetAsync("ProductCrud?Id=" + id.ToString());
            consumeapi.Wait();

            var readdata = consumeapi.Result;
            if (readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<ProductClass>();
                displaydata.Wait();
                prdobject = displaydata.Result;
            }
            return View(prdobject);
        }
        [HttpPost]
        [Route("Edit")]
        public ActionResult Edit(ProductClass pc)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44324/api/ProductCrud");
            var insertrecord = hc.PutAsJsonAsync<ProductClass>("ProductCrud", pc);
            insertrecord.Wait();

            var savedata = insertrecord.Result;
            
            if (savedata.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Updated SucessFully";
                return RedirectToAction("ProductList");
            }
            else
            {
                ViewBag.message = "Product Record Not Updated... !";
            }

            return View(pc);
        }
        public ActionResult Delete(int id)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44324/api/ProductCrud");

            var delrecord = hc.DeleteAsync("ProductCrud/" + id.ToString());
            delrecord.Wait();

            var displaydata = delrecord.Result;
            
            if (displaydata.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Deleted SucessFully";
                return RedirectToAction("ProductList");
            }
            return View("ProductList");
        }

        [HttpPost]
        public ActionResult DeleteMul (FormCollection formCollection)
        {
            string[] ids = formCollection["ID"].Split(new char[] { ',' });
            foreach (string id in ids)
            {
                var employee = this.pd.tblProducts.Find(int.Parse(id));
                this.pd.tblProducts.Remove(employee);
                this.pd.SaveChanges();
            }
            return RedirectToAction("ProductList");
        }
        public ActionResult DelSelPrd(string[] prdids)
        {
            int[] getid = null;
            if (prdids != null)
            {
                getid = new int[prdids.Length];
                int j = 0;
                foreach (string i in prdids)
                {
                    int.TryParse(i, out getid[j++]);
                }
                List<tblProduct> getprdids = new List<tblProduct>();
                ProductDBEntities pd = new ProductDBEntities();
                getprdids = pd.tblProducts.Where(x=>getid.Contains(x.Id)).ToList();

                foreach (var s in getprdids)
                {
                    pd.tblProducts.Remove(s);
                }
                pd.SaveChanges();
            }
            return RedirectToAction("ProductList");
        }
        
        public ActionResult Search(string search)
        {
            IEnumerable<tblProduct> productobj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44324/api/ProductCrud");


            var consumeapi = hc.GetAsync("ProductCrud?search=" + search);
            consumeapi.Wait();

            var readdata = consumeapi.Result;
            if (readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<IList<tblProduct>>();
                displaydata.Wait();

                productobj = displaydata.Result;
            }
            return View(productobj);
        }

       
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Login");
        }

        
    }
}