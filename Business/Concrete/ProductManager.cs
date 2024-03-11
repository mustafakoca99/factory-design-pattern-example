using Business.Abstract;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IEnumerable<IProductDal> _product;
        public ProductManager(IEnumerable<IProductDal> product)
        {
            _product = product;
        }
        public string DoWork(string productName)
        {
            foreach (var service in _product)
            {
                if (service.CheckProduct(productName))
                {
                    return service.Execute();
                }
            }

            return string.Empty;
        }
    }
}
