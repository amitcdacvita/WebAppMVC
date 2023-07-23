using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            return View(_emprep.GetEmployee(id));
        }
        [HttpPost]
        public IActionResult Edit(int id, Employee empobj) 
        {
            if (ModelState.IsValid) 
                { 
                _emprep.UpdateEmployee(empobj);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_emprep.GetEmployee(id));
        }
        [HttpPost]
        public IActionResult Delete(int id, Employee empobj)
        {
            _emprep.Delete(id);
            return RedirectToAction(nameof(Index));
           
        }
        
    }
}
