
using PayCore.Client.models;
using PayCore.Client.models.product;
using RestSharp;


HttpClient client = new HttpClient();
client.BaseAddress = new Uri("https://localhost:44381");

//var response = await client.GetAsync("/api/product");
//var products = await response.Content.ReadAsAsync<List<GetAllProductsResponseDto>>();

var response = await client.DeleteAsync("/api/product/1");





//var product = new CreateProductRequestDto();
//product.Name = "Huawei";
//product.UnitPrice = 3000;

//HttpResponseMessage response = await client.PostAsJsonAsync(
//               "/api/product", product);







//RestClient client = new RestClient("https://localhost:7185/api/");
//RestRequest request = new RestRequest("Product", Method.Get);


//var response = client.Execute<List<Product>>(request);

//Console.WriteLine(response.StatusCode);


//foreach (var item in response.Data)
//{
//    Console.WriteLine(item.Name);
//}

Console.ReadLine();









