using System;
using System.Collections.Generic;
using System.Text;

namespace YumYumShaverma
{
    public class BaseProductWrapper : IProduct
    {
        private IProduct _product;
        public BaseProductWrapper(IProduct product)
        {
            _product = product;
        }

        public virtual void AddProduct(Shaverma shavermochka)
        {
            _product.AddProduct(shavermochka);
        }
    }
}
