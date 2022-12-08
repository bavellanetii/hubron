using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
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
        private readonly IGenericRepository<LotNumber> _lotNumbersRepo;
        private readonly IGenericRepository<Packaging> _packagingRepo;
        private readonly IGenericRepository<Status> _statusesRepo;
        private readonly IMapper _mapper;

        public ProductsController(IGenericRepository<Product> productsRepo, IGenericRepository<Grade> gradesRepo, 
            IGenericRepository<Warehouse> warehousesRepo, IGenericRepository<LotNumber> lotNumbersRepo,
            IGenericRepository<Packaging> packagingRepo, IGenericRepository<Status> statusesRepo, IMapper mapper)
        {
            _mapper = mapper;
            _productsRepo = productsRepo;
            _warehousesRepo = warehousesRepo;
            _gradesRepo = gradesRepo;
            _lotNumbersRepo = lotNumbersRepo;
            _packagingRepo = packagingRepo;
            _statusesRepo = statusesRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Product>>> GetProducts()
        {
            var spec = new ProductsInFullSpecification();

            var products = await _productsRepo.ListAsync(spec);

            return Ok(_mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDto>>(products));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductToReturnDto>> GetProduct(int id)
        {
            var spec = new ProductsInFullSpecification(id);

            var product = await _productsRepo.GetEntityWithSpec(spec);

            return _mapper.Map<Product, ProductToReturnDto>(product);
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

        [HttpGet("lotnumbers")]
        public async Task<ActionResult<IReadOnlyList<LotNumber>>> GetLotNumbers()
        {
            return Ok(await _lotNumbersRepo.ListAllAsync());
        }

        [HttpGet("packaging")]
        public async Task<ActionResult<IReadOnlyList<Packaging>>> GetPackaging()
        {
            return Ok(await _packagingRepo.ListAllAsync());
        }

        [HttpGet("statuses")]
        public async Task<ActionResult<IReadOnlyList<Status>>> GetStatuses()
        {
            return Ok(await _statusesRepo.ListAllAsync());
        }

    }
}