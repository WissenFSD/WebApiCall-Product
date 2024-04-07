using WebApiCall_Product.Models.DataModel;
using WebApiCall_Product.Repository;

namespace WebApiCall_Product.Service
{
	public interface IProductService
	{
		public List<ProductDMO> GetAllProduct();
		public ProductDMO GetProductById(int id);

	}
	public class ProductService:IProductService
	{
		private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
		public List<ProductDMO> GetAllProduct()
		{
			return _productRepository.GetAllProduct();
		}
		public ProductDMO GetProductById(int id)
		{
			return _productRepository.GetProductById(id);	
		}
	}
}
