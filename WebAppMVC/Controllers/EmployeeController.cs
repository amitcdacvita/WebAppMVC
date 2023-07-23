using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _emprep;
        public EmployeeController(IEmployeeRepository repo) 
        {
            _emprep=repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
           var lemp=_emprep.GetAllEmployee();
            return View(lemp);
        }
        [HttpGet]
        public IActionResult details(int id)
        {
            var Emp = _emprep.GetEmployee(id);
            return View(Emp);
        }
        [HttpGet]
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                _emprep.AddEmp(emp);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
