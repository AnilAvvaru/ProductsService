using ProductsService.Models;

namespace ProductsService.Gateways
{
    public class ProductGateway : IProductGateway
    {        
        public IEnumerable<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product 
                { 
                    ProductId = Guid.NewGuid().ToString(),
                    ProductName = "OnePlus Nord CE 2 Lite 5G (Blue Tide, 6GB RAM, 128GB Storage)",
                    ProductDescription = "OnePlus Nord CE 2 Lite 5G (Blue Tide, 6GB RAM, 128GB Storage) Desc"
                },
                new Product
                {
                    ProductId = Guid.NewGuid().ToString(),
                    ProductName = "OnePlus Nord CE 3 Lite 5G (Chromatic Gray, 8GB RAM, 128GB Storage)",
                    ProductDescription = "OnePlus Nord CE 3 Lite 5G (Chromatic Gray, 8GB RAM, 128GB Storage) Desc"
                },
                new Product
                {
                    ProductId = Guid.NewGuid().ToString(),
                    ProductName = "realme narzo N55 (Prime Blue, 4GB+64GB) 33W Segment Fastest Charging | Super High-res 64MP Primary AI Camera",
                    ProductDescription = "realme narzo N55 (Prime Blue, 4GB+64GB) 33W Segment Fastest Charging | Super High-res 64MP Primary AI Camera Desc"
                },
            };

            return products;
        }
    }
}
