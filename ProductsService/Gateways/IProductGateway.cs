using ProductsService.Models;

namespace ProductsService.Gateways
{
    public interface IProductGateway
    {
        IEnumerable<Product> GetProducts();        
    }
}
