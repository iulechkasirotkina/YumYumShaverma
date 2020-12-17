using System;
using System.Collections.Generic;
using System.Text;

namespace YumYumShaverma
{
    public class PitaProduct : IProduct
    {
        public void AddProduct(Shaverma shavermochka)
        {
            shavermochka.Ingredients.Add("Pita ");
            shavermochka.Price = 45;
        }
    }
}
