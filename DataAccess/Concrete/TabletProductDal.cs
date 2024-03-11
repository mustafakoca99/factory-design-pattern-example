using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class TabletProductDal : IProductDal
    {
        public bool CheckProduct(string productName)
        {
            return productName.ToLower() == "tablet";
        }

        public string Execute()
        {
            return "tablet servisi çalıştı.";
        }
    }
}
