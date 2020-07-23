using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public Product(bool stock = true)
        {
            InStock = stock;
        }
        public string Name { get; set; }
        public string Kategory { get; set; } = "Watesport";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }
        public static Product[] GetProducts()
        {
            Product kayak = new Product()
            {
                Name = "Kayak",
                Kategory = "Craft sport",
                Price = 275M
            };
            Product liferjacket = new Product(false)
            {
                Name = "Lifejacket",
                Price = 48.95M
            };
            kayak.Related = liferjacket;
            return new Product[] { kayak, liferjacket, null };
        }
    }
}
