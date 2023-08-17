using EmployeeApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EmployeeApplication.Controllers
{
    public class EmployeeController : Controller
    {
        HttpClient client = new HttpClient();
        public IActionResult Index()
        {
            List<Employee> Employee = new List<Employee>();
            client.BaseAddress = new Uri("https://localhost:7078/api/Employee");
            var response = client.GetAsync("Employee");
            response.Wait();
            var test = response.Result;

            if (test.IsSuccessStatusCode)
            {
                string display = test.Content.ReadAsStringAsync().Result;
                Employee = JsonConvert.DeserializeObject<List<Employee>>(display);
            }
            return View(Employee);
        }
    }
}
