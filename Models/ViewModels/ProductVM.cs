namespace MyShopingApp9._0.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; } = new Product();
        public IEnumerable<Product> products { get; set; } = new List<Product>();
    }
}
