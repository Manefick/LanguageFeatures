using LanguageFeatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    public static class SuportFunctionClass
    {
        public static IEnumerable<Product> FiltreByPice(this IEnumerable<Product> products, decimal minPrice)
        {
            foreach(Product p in products)
            {
                if (p?.Price > minPrice)
                    yield return p;
            }
        }
    }
}
