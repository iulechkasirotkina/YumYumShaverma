using System;
using System.Collections.Generic;
using System.Text;

namespace YumYumShaverma
{
   public class VegetablesProductWrapper :BaseProductWrapper
    {
        public VegetablesProductWrapper(IProduct product) : base(product)
        {

        }

        public override void AddProduct(Shaverma shavermochka)
        {
            base.AddProduct(shavermochka);
            shavermochka.Ingredients.Add("Vegetables ");
            shavermochka.Price += 40;
        }

    }
}
