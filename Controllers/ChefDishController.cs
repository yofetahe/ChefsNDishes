using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefNDishes.Controllers
{
    public class ChefDishController : Controller
    {
        private ChefNDishesContext dbContext;

        public ChefDishController(ChefNDishesContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            List<Chef> chefs = dbContext.Chefs
            .Include(d => d.Dishes)
            .ToList();
            
            return View(chefs);
        }

        [HttpGet("GetChefAddForm")]
        public IActionResult GetChefAddForm()
        {
            return View("ChefAddForm");
        }

        [HttpPost("AddChef")]
        public IActionResult AddChef(Chef chef)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(chef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("ChefAddForm");
            }
        }

        [HttpGet("GetDishesList")]
        public IActionResult GetDishesList()
        {
            List<Dish> dishes = dbContext.Dishes
            .Include(c => c.PreparedBy)
            .ToList();
            return View("DishesList", dishes);
        }

        [HttpGet("GetDishAddForm")]
        public IActionResult GetDishAddForm()
        {
            List<Chef> chefs = dbContext.Chefs.ToList();
            ViewBag.Chefs = chefs;
            return View("DishAddForm");
        }

        [HttpPost("AddDishes")]
        public IActionResult AddDishes(Dish dish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("GetDishesList");
            }
            else
            {
                List<Chef> chefs = dbContext.Chefs.ToList();
                ViewBag.Chefs = chefs;
                return View("DishAddForm");                
            }
        }
    }
}
