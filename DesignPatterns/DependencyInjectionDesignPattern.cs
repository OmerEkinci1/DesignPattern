using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class DependencyInjectionDesignPattern
    {
        interface IProductDal
        {
            void Save();
        }
        class ProductDal : IProductDal
        {
            public void Save()
            {
                Console.WriteLine("Saved with EF");
            }
        }

        class ProductManage
        {
            private IProductDal _productDal;

            public ProductManage(IProductDal productDal)
            {
                _productDal = productDal;
            }

            public void Save()
            {
                _productDal.Save();
            }
        }
    }
}
