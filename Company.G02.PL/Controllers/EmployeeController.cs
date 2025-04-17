using Company.G02.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Company.G02.PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeerepository;

        public EmployeeController(IEmployeeRepository employeerepository)
        {
           _employeerepository = employeerepository;
        }
        public IActionResult Index()
        {
            var employees = _employeerepository.GetAll();

            return View(employees);
        }
    }
}
