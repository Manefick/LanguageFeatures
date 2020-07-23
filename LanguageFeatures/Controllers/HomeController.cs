using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index()
        {
            List<string> result = new List<string>();
            foreach(Product p in Product.GetProducts())
            {
                string name = p?.Name??"< No name>";
                decimal? price = p?.Price?? 0;
                string relatedName = p?.Related?.Name?? "<None>";
                result.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            }
            Product[] products = Product.GetProducts();
            products.FiltreByPice(180M);
            return View(result);
        }
    }
}
