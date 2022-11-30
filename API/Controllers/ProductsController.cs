using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            //this will be a list of products
            return "this will be a list of products";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            //this will be a single product
            return "this will be a single product";
        }
    }
}