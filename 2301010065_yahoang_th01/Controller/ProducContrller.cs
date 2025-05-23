using _2301010065_yahoang_th01.modes.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _2301010065_yahoang_th01.Controller
{
    public class ProducContrller
    {

        private IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Shop()
        {
            return View(productRepository.GetAllProducts());
        }
    }
}
