using PayCore.Client.models.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PayCore.Client.models.general;
using PayCore.Client.models;

namespace PayCore.Client.services
{
    public class ProductService : BaseService
    {
        public ProductService(string token) : base(token)
        {

        }

        public async Task<ResponseModel<List<GetAllProductsResponseDto>>> GetAllProducts()
        {
            var responseModel = new ResponseModel<List<GetAllProductsResponseDto>>();

            var response = await httpClient.GetAsync("/api/product");
            var products = await response.Content.ReadAsAsync<List<GetAllProductsResponseDto>>();


            responseModel.StatusCode = Convert.ToInt32(response.StatusCode);
            responseModel.Data = products;
            responseModel.ErrorMessage = "";
            responseModel.IsSuccess = response.IsSuccessStatusCode;

            return responseModel;
        }

        public async Task<ResponseModel<string>> DeleteProductById(int id)
        {
            var responseModel = new ResponseModel<string>();

            var response = await httpClient.DeleteAsync("/api/product/" + id);


            responseModel.StatusCode = Convert.ToInt32(response.StatusCode);
            responseModel.Data = "";
            responseModel.ErrorMessage = "";
            responseModel.IsSuccess = response.IsSuccessStatusCode;

            return responseModel;


        }

        public async Task<ResponseModel<CreateProductResponseDto>> Create(CreateProductRequestDto request)
        {
            var responseModel = new ResponseModel<CreateProductResponseDto>();

            HttpResponseMessage response = await httpClient.PostAsJsonAsync("/api/product", request);
            var product = await response.Content.ReadAsAsync<CreateProductResponseDto>();

            responseModel.StatusCode = Convert.ToInt32(response.StatusCode);
            responseModel.Data = product;
            responseModel.ErrorMessage = "";
            responseModel.IsSuccess = response.IsSuccessStatusCode;

            return responseModel;

        }


        public async Task<ResponseModel<GetProductByIdResonseDto>> Get(int id)
        {
            var responseModel = new ResponseModel<GetProductByIdResonseDto>();

            var response = await httpClient.GetAsync("/api/product/" + id);

            var product = new GetProductByIdResonseDto();

            if (response.IsSuccessStatusCode)
            {
                await response.Content.ReadAsAsync<GetProductByIdResonseDto>();
            }
            responseModel.StatusCode = Convert.ToInt32(response.StatusCode);
            responseModel.Data = product;
            responseModel.ErrorMessage = "";
            responseModel.IsSuccess = response.IsSuccessStatusCode;


            return responseModel;



        }

    }
}
