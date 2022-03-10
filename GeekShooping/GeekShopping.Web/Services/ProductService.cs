using GeekShopping.Web.Models;
using GeekShopping.Web.Services.Interfaces;
using GeekShopping.Web.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace GeekShopping.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/product";

        public ProductService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<ProductViewModel>> FindAll()
        {
            var respone = await _client.GetAsync(BasePath);

            return await respone.ReadContentAs<IList<ProductViewModel>>();
        }

        public async Task<ProductViewModel> FindById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");

            return await response.ReadContentAs<ProductViewModel>();
        }

        public async Task<ProductViewModel> Create(ProductViewModel model)
        {
            var response = await _client.PostAsJson(BasePath, model);

            if (!response.IsSuccessStatusCode) 
                throw new Exception("Something went wrong when calling API");

            return await response.ReadContentAs<ProductViewModel>();
        }

        public async Task<ProductViewModel> Update(ProductViewModel model)
        {
            var response = await _client.PutAsJson(BasePath, model);

            if (!response.IsSuccessStatusCode)
                throw new Exception("Something went wrong when calling API");

            return await response.ReadContentAs<ProductViewModel>();
        }

        public async Task<bool> Delete(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");
            
            if (!response.IsSuccessStatusCode)
                throw new Exception("Something went wrong when calling API");

            return await response.ReadContentAs<bool>();
        }
    }
}
