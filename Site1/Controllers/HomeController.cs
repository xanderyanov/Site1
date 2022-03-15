using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Site1.Models;
using System.Diagnostics;

namespace Site1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var productsCollection = Program.DB.GetCollection<Product>("products");
            BsonDocument filter = new();
            List<Product> products = productsCollection.Find(filter).ToList();

            return View(products);
        }

        public IActionResult ProductsList()
        {
            var productsCollection = Program.DB.GetCollection<Product>("products");
            BsonDocument filter = new("ProductID", new BsonDocument("$lt", 5));
            List<Product> products = productsCollection.Find(filter).ToList();

            return View(products);
        }
        
    }
}