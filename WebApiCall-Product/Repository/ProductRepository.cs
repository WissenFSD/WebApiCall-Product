using RestSharp;
using WebApiCall_Product.Models.DataModel;

namespace WebApiCall_Product.Repository
{

	public interface IProductRepository
	{

		public List<ProductDMO> GetAllProduct();
		public ProductDMO GetProductById(int id);


	}
	public class ProductRepository : IProductRepository
	{
		public List<ProductDMO> GetAllProduct()
		{
			RestSharp.RestClient cli = new RestSharp.RestClient("https://localhost:7253");
			RestSharp.RestRequest request = new RestSharp.RestRequest("wissen/product");
			request.Method = RestSharp.Method.Get;

			var result =cli.ExecuteGet(request);
			var jsonResult = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProductDMO>>(result.Content);


			return jsonResult;
		}
		public ProductDMO GetProductById(int id)
		{
			RestSharp.RestClient cli = new RestSharp.RestClient("https://localhost:7253");
			RestSharp.RestRequest request = new RestSharp.RestRequest("wissen/product/Detail?id="+id);
			request.Method = RestSharp.Method.Get;

			var result = cli.ExecuteGet(request);
			var jsonResult = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductDMO>(result.Content);


			return jsonResult;
		}

		
	}
}
