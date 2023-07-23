using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _deptrep;
        public DepartmentController(IDepartmentRepository repo)
        {
            _deptrep = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var ldept = _deptrep.GetAllDepartment();
            return View(ldept);
        }
        [HttpGet]
        public IActionResult details(int id)
        {
            var Dept = _deptrep.GetDepartment(id);
            return View(Dept);
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Department dept)
        {
            if (ModelState.IsValid)
            {
                _deptrep.AddDept(dept);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
