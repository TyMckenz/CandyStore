using Microsoft.AspNetCore.Mvc;
using CandyStore.Models;

namespace CandyStore.Controllers
{
    public class StoreController : Controller
    {
        public List<Candy> candies;
        public StoreController()
        {
            candies = new List<Candy>
            {
                new Candy
                {
                    Name = "M&M",
                    Weight = 100.00,
                    Price = 2.50
                },
                  new Candy
                {
                    Name = "Skittles",
                    Weight = 120.00,
                    Price = 2.50
                },
                    new Candy
                {
                    Name = "Starburst",
                    Weight = 80.00,
                    Price = 2.50
                },
                      new Candy
                {
                    Name = "Smarties",
                    Weight = 120.00,
                    Price = 2.50
                }


            };

        }
        public IActionResult Candies()
        {
            return View(candies);
        }
    }
}
