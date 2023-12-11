
using PayCore.Client.models;
using PayCore.Client.models.product;
using PayCore.Client.models.token;
using PayCore.Client.services;
using RestSharp;




Console.WriteLine("Lutfen bir email adresi giriniz");
string email = Console.ReadLine() ?? "";

Console.WriteLine("Lutfen bir sifre giriniz");
string password = Console.ReadLine() ?? "";

var requestModel = new LoginRequestModel();
requestModel.EMail = email;
requestModel.Password = password;

var tokenService = new TokenService();
var response = await tokenService.Login(requestModel);


var productService = new ProductService(response.accessToken);
var responseModel = await productService.GetAllProducts();


if(responseModel.IsSuccess)
{
    responseModel.Data.ForEach(item => Console.WriteLine(item.Name));
}

//var productRequestDto = new CreateProductRequestDto();

//Console.WriteLine("Lutfen urunun adini giriniz.");
//productRequestDto.Name = Console.ReadLine() ?? "";

//Console.WriteLine("Lutfen urunun fiyatini giriniz.");
//productRequestDto.UnitPrice = Convert.ToDecimal(Console.ReadLine() ?? "");

//Console.WriteLine("Lutfen urunun stok adedini giriniz.");
//productRequestDto.Stock = Convert.ToInt32(Console.ReadLine() ?? "");


//var responseProduct = await productService.Create(productRequestDto);

//Console.WriteLine("New product id: " + responseProduct.Data.Id);
//Console.Read();




//Silme operasyonu

//Console.WriteLine("Lutfen silinecek urunun id si giriniz");
//int productId = Convert.ToInt32(Console.ReadLine());

//var result = await productService.DeleteProductById(productId);

//Console.WriteLine(result.IsSuccess);
//Console.ReadLine();



Console.WriteLine("Lutfen detayini istediginiz urunun id sini giriniz");
int productId = Convert.ToInt32(Console.ReadLine());

var res = await productService.Get(productId);

if(res.StatusCode == 404)
{
    Console.WriteLine("Boyle bir urun bulunamadi!");
}
else
{
    Console.WriteLine(res.Data.Id);
    Console.WriteLine(res.Data.Name);
    Console.WriteLine(res.Data.UnitPrice);
    Console.WriteLine(res.Data.Stock);
}



Console.ReadLine(); 









