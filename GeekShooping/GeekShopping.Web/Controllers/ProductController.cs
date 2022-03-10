using GeekShopping.Web.Models;
using GeekShopping.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GeekShopping.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.FindAll();

            return View(products);
        } 

        public async Task<IActionResult> CreateProduct()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.Create(model);

                if (response != null) return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        public async Task<IActionResult> ProductUpdate(long id)
        {
            var product = await _productService.FindById(id);

            if (product == null) return NotFound();

            return View(product);
        }


        [HttpPost]
        public async Task<IActionResult> ProductUpdate(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.Update(model);

                if (response != null) return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        public async Task<IActionResult> ProductDelete(long id)
        {
            var model = await _productService.FindById(id);

            if (model != null) return View(model);

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ProductDelete(ProductViewModel model)
        {
            var response = await _productService.Delete(model.Id);

            if (response) return RedirectToAction(nameof(Index));

            return View(model);
        }

    }
}
