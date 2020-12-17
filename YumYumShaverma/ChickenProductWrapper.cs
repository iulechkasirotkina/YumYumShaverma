using System;
using System.Collections.Generic;
using System.Text;

namespace YumYumShaverma
{
    public class ChickenProductWrapper : BaseProductWrapper
    {
        public ChickenProductWrapper(IProduct product) : base(product)
        {

        }

        public override void AddProduct(Shaverma shavermochka)
        {
            base.AddProduct(shavermochka);
            shavermochka.Ingredients.Add("Chicken ");
            shavermochka.Price += 65;
        }
    }
}
