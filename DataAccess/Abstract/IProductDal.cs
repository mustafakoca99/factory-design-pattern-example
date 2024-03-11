using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        bool CheckProduct(string productName);
        string Execute();
    }
}
