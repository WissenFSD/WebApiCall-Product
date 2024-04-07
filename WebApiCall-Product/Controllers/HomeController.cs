using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApiCall_Product.Models;
using WebApiCall_Product.Service;

namespace WebApiCall_Product.Controllers
{
	public class HomeController : Controller
	{

		private IProductService _productService;

		public HomeController(IProductService productService)
		{
			_productService = productService;
		}
		public IActionResult Index()
		{

			var products = _productService.GetAllProduct().Select(s => new ProductViewModel()
			{
				Color = s.Color,
				ListPrice = s.ListPrice,
				Name = s.Name,
				ProductId = s.ProductId,


			}).ToList();
			return View(products);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
