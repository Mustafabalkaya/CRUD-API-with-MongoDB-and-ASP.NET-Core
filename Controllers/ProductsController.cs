using System.Globalization;
using API_CRUD_MongoDB.DTO;
using API_CRUD_MongoDB.Models;
using API_CRUD_MongoDB.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD_MongoDB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
     private readonly ProductService _productService;

     public ProductsController(ProductService productService)
     {
        _productService=productService;
     }   
     
     [HttpGet]
     public async Task<ActionResult<List<Product>>> Get()=>
     await _productService.GetProducts();

    [HttpGet("{id:length(24)}", Name = "GetProduct")]
     public async Task<ActionResult<Product>> Get(string id)
     {
        var product = await _productService.GetProductById(id);
        if (product == null)
        {
            return NotFound();
        }

        return product;
     }

    [HttpPost]
     public async Task<ActionResult<Product>> Create (Product product)
     {
        var createProduct = await _productService.CreateProduct(product);

        return CreatedAtRoute("GetProduct", new {id = createProduct.Id}, createProduct);
     }

     [HttpPut ("{id:length(24)}")]
     public async Task<ActionResult> Update (string id, ProductDTO productDTO)
     {
        var product = await _productService.GetProductById(id);
        if (product == null)
        {
            return NotFound();
        }

        await _productService.UpdateProduct(id, productDTO);
        return NoContent();
     }
     [HttpDelete ("{id:length(24)}")]
     public async Task<ActionResult> Delete (string id)
     {
        var product = await _productService.GetProductById(id);
        if (product == null)
        {
            return NotFound();
        }

        await _productService.DeleteProduct(id);
        return NoContent();
     }
    }
}