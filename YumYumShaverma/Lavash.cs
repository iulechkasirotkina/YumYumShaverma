using System;
using System.Collections.Generic;
using System.Text;

namespace YumYumShaverma
{
    public class LavashProduct : IProduct
    {
        public void AddProduct(Shaverma shavermochka)
        {
            shavermochka.Ingredients.Add(" Just Lavash ");
            shavermochka.Price = 50;
        }

    }
}
