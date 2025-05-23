using _2301010065_yahoang_th01.models;

namespace _2301010065_yahoang_th01.modes.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetTrendingProducts();
        Product GetProductDetail(int id);
    }
}
