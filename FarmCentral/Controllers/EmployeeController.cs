using FarmCentral.Data;
using Microsoft.AspNetCore.Mvc;

namespace FarmCentral.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var objEmployeeList = _db.Employees;
            return View(objEmployeeList);
        }
        //Get Action Method
        //This method will allow the empoloyee to add a new farmer
        public IActionResult Create()
        {
            
            return View();
        }

    }
}
