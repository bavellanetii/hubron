using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProductsController : ControllerBase
    {
        private readonly IGenericRepository<Grade> _gradesRepo;
        private readonly IGenericRepository<Warehouse> _warehousesRepo;
        private readonly IGenericRepository<Product> _productsRepo;
 
        public ProductsController(IGenericRepository<Product> productsRepo, 
                                  IGenericRepository<Grade> gradesRepo, 
                                  IGenericRepository<Warehouse> warehousesRepo)
        {
            _warehousesRepo = warehousesRepo;
            _gradesRepo = gradesRepo;
            _productsRepo = productsRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            //this will be a list of products
            var products = await _productsRepo.ListAllAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            //this will be a single product
            return await _productsRepo.GetByIdAsync(id);
        }

        [HttpGet("grades")]
        public async Task<ActionResult<IReadOnlyList<Grade>>> GetGrades()
        {
            return Ok(await _gradesRepo.ListAllAsync());
        }

        [HttpGet("warehouses")]
        public async Task<ActionResult<IReadOnlyList<Warehouse>>> GetWarehouses()
        {
            return Ok(await _warehousesRepo.ListAllAsync());
        }

    }
}