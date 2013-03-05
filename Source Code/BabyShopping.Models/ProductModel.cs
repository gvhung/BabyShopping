namespace BabyShop.Models
{
    public class ProductModel
    {
        public int Id
        {
            get;
            set;
        }
        public int Code
        {
            get;
            set;
        }
        public int CategoryId
        {
            get;
            set;
        }
        public string CategoryName
        {
            get;
            set;
        }
        public decimal Price
        {
            get;
            set;
        }
        public string ImageURL
        {
            get;
            set;
        }
    }
}