using FarmCentral.Data;
using FarmCentral.Models;
using Microsoft.AspNetCore.Mvc;

namespace FarmCentral.Controllers
{
    public class FarmerController : Controller
    {
        private readonly ApplicationDbContext _db;
        public FarmerController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objFarmerList = _db.Farmers;
            return View(objFarmerList);
        }

        //Get Action Method
        public IActionResult Create()
        {

            return View();
        }
        //Post: This will add a new farmer to the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Farmer obj)
        {
            if (ModelState.IsValid)
            {
                _db.Farmers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
           
        }

    }
}
