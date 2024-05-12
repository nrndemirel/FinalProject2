using Business.Abstract;
using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public string Get()
        {
            var result = _productService.GetAll();
            return result.Message;
        }
    }
}
