using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RetailBankingSystemClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RetailBankingSystemClient.Controllers
{
    public class SignUpController : Controller
    {
        // GET: CustomerController
        private readonly HttpClient client = null;

        private string employeesApiUrl = "";
        

        public SignUpController(HttpClient client, IConfiguration config)             //dependency injection
        {
            this.client = client;

            employeesApiUrl = config.GetValue<string>("AppSettings:EmployeesApiUrl");

            
        }
        public async Task<IActionResult> Details()
        {

            HttpResponseMessage response = await client.GetAsync(employeesApiUrl);

            string stringData = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            List<CustomerDetails> data = System.Text.Json.JsonSerializer.Deserialize<List<CustomerDetails>>(stringData, options);

            TempData.Keep();        //To display the messages stored in the delete action after redirecting from the delete action

            return View(data);
        }
        public async Task<IActionResult> DetailsById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{employeesApiUrl}/{id}");  //api/employees/id

            string stringData = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            CustomerDetails model = System.Text.Json.JsonSerializer.Deserialize<CustomerDetails>(stringData, options);
            return View(model);
        }
        public async Task<ActionResult> Create(CustomerDetails model)
        {         
            
                string stringData = System.Text.Json.JsonSerializer.Serialize(model);            //model is serialized to json now

                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(employeesApiUrl, contentData);

                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = "Customer details inserted successfully";
                }
                else
                {
                    ViewBag.Message = "Error while calling  Customer Web API";
                }
                string Data = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                CustomerDetails data = System.Text.Json.JsonSerializer.Deserialize<CustomerDetails>(Data, options);    
                return View(data);          
            
        }
        public ActionResult Index()
        {
            return View();
        }
      
       


    }
}
