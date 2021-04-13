using Employeemanagement.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.MVC.Filter;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement.MVC.Controllers
{
    [ResponseHeader]
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        // GET: EmployeeController
        [ResponseCache(Duration = 30)]
        public async Task<IActionResult> Index()
        {
            try
            {
                if (HttpContext.Session.GetString("Token") == null || HttpContext.Session.GetString("Token") == "")
                {
                    return RedirectToAction("Login", "Login");
                }
                using (HttpClient client = new HttpClient())
                {
                    var tc = "Bearer " + HttpContext.Session.GetString("Token");
                    client.DefaultRequestHeaders.Add("Authorization", tc);
                    using (var response = await client.GetAsync("https://localhost:44302/api/Employee/GetEmployees"))
                    {
                        var ApiResponse = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<List<EmployeeModel>>(ApiResponse);
                        return View(result);
                    }
                }
            }
            catch(Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return RedirectToAction("Error", "Employee");
            }
        }
        public async Task<ActionResult> List()
        {
            try
            {
                if (HttpContext.Session.GetString("Token") == null || HttpContext.Session.GetString("Token") == "")
                {
                    return RedirectToAction("Login", "Login");
                }
                using (HttpClient client = new HttpClient())
                {
                    var tc = "Bearer " + HttpContext.Session.GetString("Token");
                    client.DefaultRequestHeaders.Add("Authorization", tc);
                    using (var response = await client.GetAsync("https://localhost:44302/api/Employee/GetEmployees"))
                    {
                        var ApiResponse = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<List<EmployeeModel>>(ApiResponse);
                        return View(result);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return RedirectToAction("Error", "Employee");
            }
        }
        // GET: EmployeeController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            try
            {
                if (HttpContext.Session.GetString("Token") == null || HttpContext.Session.GetString("Token") == "")
                {
                    return RedirectToAction("Login", "Login");
                }
                using (HttpClient client = new HttpClient())
                {
                    var tc = "Bearer " + HttpContext.Session.GetString("Token");
                    client.DefaultRequestHeaders.Add("Authorization", tc);
                    using (var response = await client.GetAsync("https://localhost:44302/api/Employee/GetEmployeeById?id=" + id))
                    {
                        var ApiResponse = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<EmployeeModel>(ApiResponse);
                        return View(result);
                    }
                }
            }
            catch(Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return RedirectToAction("Error","Login");
            }
        }

        // GET: EmployeeController/Create
        public async Task<ActionResult> Create()
        {
            try
            {
                if (HttpContext.Session.GetString("Token") == null || HttpContext.Session.GetString("Token") == "")
                {
                    return RedirectToAction("Login", "Login");
                }
                using (HttpClient client = new HttpClient())
                {
                    var tc = "Bearer " + HttpContext.Session.GetString("Token");
                    client.DefaultRequestHeaders.Add("Authorization", tc);
                    using (var response = await client.GetAsync("https://localhost:44302/api/Employee/GetManagers"))
                    {
                        var ApiResponse = await response.Content.ReadAsStringAsync();
                        var res = JsonConvert.DeserializeObject<List<EmployeeModel>>(ApiResponse);
                        ViewBag.Managers = res;
                        return View();
                    }
                    
                }
                   
                }
            catch(Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return RedirectToAction("Error", "Login");
            }
           
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeModel model)
        {
            try
            {
                if (HttpContext.Session.GetString("Token") == null || HttpContext.Session.GetString("Token") == "")
                {
                    return RedirectToAction("Login", "Login");
                }
                using (HttpClient client = new HttpClient())
                {
                    var tc = "Bearer " + HttpContext.Session.GetString("Token");
                    client.DefaultRequestHeaders.Add("Authorization", tc);
                    StringContent stringContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8,"application/json");
                    using (var response = await client.PostAsync("https://localhost:44302/api/Employee/AddEmployee",(stringContent)))
                    {
                        return RedirectToAction("List");

                    }
                }
            }
            catch(Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return RedirectToAction("Error","Employee");
            }
        }
    
        [HttpGet,Route("Employee/Edit/{id}")]
        public async Task<ActionResult> Edit(int id)
        {
            try
            {
                if (HttpContext.Session.GetString("Token") == null || HttpContext.Session.GetString("Token") == "")
                {
                    return RedirectToAction("Login", "Login");
                }
                using (HttpClient client = new HttpClient())
                {
                    var tc = "Bearer " + HttpContext.Session.GetString("Token");
                    client.DefaultRequestHeaders.Add("Authorization", tc);
                    using (var response = await client.GetAsync("https://localhost:44302/api/Employee/GetManagers"))
                    {
                        var ApiResponse = await response.Content.ReadAsStringAsync();
                        var res = JsonConvert.DeserializeObject<List<EmployeeModel>>(ApiResponse);
                        ViewBag.Managers = res;
                    }
                    using (var response = await client.GetAsync("https://localhost:44302/api/Employee/GetEmployeeByID?id=" + id))
                    {
                        var ApiResponse = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<EmployeeModel>(ApiResponse);
                        return View(result);
                    }
                }
            }
            catch(Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return RedirectToAction("Error", "Employee");
            }
        }
        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EmployeeModel model)
        {
            try
            {
                if (HttpContext.Session.GetString("Token") == null || HttpContext.Session.GetString("Token") == "")
                {
                    return RedirectToAction("Login", "Login");
                }
                using (HttpClient client=new HttpClient())
                {
                    var tc = "Bearer " + HttpContext.Session.GetString("Token");
                    client.DefaultRequestHeaders.Add("Authorization", tc);
                    StringContent stringContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                    using (var response = await client.PutAsync("https://localhost:44302/api/Employee/UpdateEmployee?id=" + model.ID, stringContent))
                    {
                        return RedirectToAction("List");
                    }
                }
            }
            catch(Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return RedirectToAction("Error","Employee");
            }
        }
        
        // GET: EmployeeController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                if (HttpContext.Session.GetString("Token") == null || HttpContext.Session.GetString("Token") == "")
                {
                    return RedirectToAction("Login", "Login");
                }
                using (HttpClient client = new HttpClient())
                {
                    var tc = "Bearer " + HttpContext.Session.GetString("Token");
                    client.DefaultRequestHeaders.Add("Authorization", tc);
                    using (var response = await client.DeleteAsync("https://localhost:44302/api/Employee/DeleteEmployee?id=" + id))
                    {
                        return RedirectToAction("List");
                    }
                }
            }
            catch(Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return RedirectToAction("Error", "Employee");
            }
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                _logger.LogInformation(ex.Message);
                return View();
            }
        }
    }
}
