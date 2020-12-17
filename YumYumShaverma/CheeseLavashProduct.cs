using System;
using System.Collections.Generic;
using System.Text;

namespace YumYumShaverma
{
    public class CheeseLavashProduct : IProduct
    {
        public void AddProduct(Shaverma shavermochka)
        {
            shavermochka.Ingredients.Add("Cheese Lavash ");
            shavermochka.Price = 60;
        }
    }
}
