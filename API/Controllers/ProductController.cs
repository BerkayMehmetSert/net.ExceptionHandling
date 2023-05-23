using API.Exceptions.Type;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private static List<string> GetProducts()
    {
        return new List<string> { "Product 1", "Product 2", "Product 3" };
    }

    [HttpGet("success")]
    public IActionResult Get()
    {
        return Ok(GetProducts());
    }
    
    [HttpGet("business-error")]
    public IActionResult GetProductsWithBusinessException()
    {
        var products = GetProducts();

        return products.Count > 0 ? throw new BusinessException("Too many products") : Ok(products);
    }
    
    [HttpGet("not-found-error")]
    public IActionResult GetProductsWithNotFoundException()
    {
        var products = GetProducts();

        return products.Count > 0 ? throw new NotFoundException("Too many products") : Ok(products);
    }
}