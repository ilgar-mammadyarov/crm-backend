using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    [HttpGet(Name = "GetWeatherForecast")]
    public List<Product> Get()
    {
        var product = new Product() {Name = "Anar"};
        productManager.Add(product);
        return productManager.GetAll();
    }
}
