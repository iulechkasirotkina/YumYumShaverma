using System;
using System.Collections.Generic;
using System.Text;

namespace YumYumShaverma
{
    public class SauceProductWrapper : BaseProductWrapper
    {
        public SauceProductWrapper(IProduct product) : base(product)
        { }

        public override void AddProduct(Shaverma shavermochka)
        {
            base.AddProduct(shavermochka);
            shavermochka.Ingredients.Add("Sause ");
            shavermochka.Price += 30;
        }
    }
}
