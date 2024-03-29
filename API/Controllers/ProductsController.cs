using API.Dtos;
using API.Errors;
using API.Helpers;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductsController : BaseApiController
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
        public async Task<ActionResult<Pagination<Product>>> GetProducts([FromQuery]ProductSpecParameters productParams)
        {
            var spec = new ProductsInFullSpecification(productParams);

            var countSpec = new ProductWithFiltersForCountSpecification(productParams);

            var totalItems = await _productsRepo.CountAsync(countSpec);

            var products = await _productsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturnDto>>(products);

            return Ok(new Pagination<ProductToReturnDto>(productParams.PageIndex, productParams.PageSize, totalItems, data));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductToReturnDto>> GetProduct(int id)
        {
            var spec = new ProductsInFullSpecification(id);

            var product = await _productsRepo.GetEntityWithSpec(spec);

            if(product == null) return NotFound(new ApiResponse(404));

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