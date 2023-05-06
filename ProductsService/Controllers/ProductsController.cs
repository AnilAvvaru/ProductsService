using Microsoft.AspNetCore.Mvc;
using ProductsService.Gateways;
using ProductsService.Models;

namespace ProductsService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductGateway _productGateway;

        public ProductsController(
            ILogger<ProductsController> logger,
            IProductGateway productGateway)
        {
            _logger = logger;
            _productGateway = productGateway;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Product> Products()
        {
            // Validate
            // Log
            // Mask

             return _productGateway.GetProducts();
        }
    }
}