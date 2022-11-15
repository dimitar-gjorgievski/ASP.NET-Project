using Microsoft.AspNetCore.Mvc;
using testproject.Models;

namespace testproject.Controllers
{
    public class TestController : Controller
    {

         private static List<TestViewModel> foodItems = new List<TestViewModel>();
        
        public IActionResult Index()
        {
            /*
            TestViewModel tempFood = new TestViewModel()
            { FoodItem = "Chicken"};
            */

            return View(foodItems);
        }

        public IActionResult ExtraPage()
        {
            return View();
        }

        public IActionResult AddFood()
        {
            var foodVm = new TestViewModel();
               
            return View(foodVm);
        }

        public IActionResult CreateFood(TestViewModel testviewmodel)
        {
            //return View("Index");
            foodItems.Add(testviewmodel);
            return RedirectToAction(nameof(Index));
        }

    }
}
