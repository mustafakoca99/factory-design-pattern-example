using DataAccess.Abstract;

namespace DataAccess.Concrete
{
    public class ComputerProductDal : IProductDal
    {
        public bool CheckProduct(string productName)
        {
            return productName.ToLower() == "bilgisayar";
        }

        public string Execute()
        {
            return "Bilgisayar servisi çalıştı.";
        }
    }
}
