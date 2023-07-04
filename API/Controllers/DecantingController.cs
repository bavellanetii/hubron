using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities;
using Core.Entities.Decanting;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class DecantingController : BaseApiController
    {
        private readonly IGenericRepository<Customer> _customersRepo;
        private readonly IGenericRepository<OrderDecant> _orderDecantsRepo;
        private readonly IGenericRepository<Grade> _gradesRepo;
        private readonly IGenericRepository<Packaging> _packagingRepo;
        private readonly IGenericRepository<Transport> _transportsRepo;
        private readonly IMapper _mapper;
        public DecantingController(
            IGenericRepository<OrderDecant> orderDecantsRepo, IGenericRepository<Grade> gradesRepo, 
            IGenericRepository<Customer> customersRepo, IGenericRepository<Packaging> packagingRepo, 
            IGenericRepository<Transport> transportsRepo, IMapper mapper)
        {
            _customersRepo = customersRepo;
            _orderDecantsRepo = orderDecantsRepo;
            _gradesRepo = gradesRepo;
            _packagingRepo = packagingRepo;
            _transportsRepo = transportsRepo;
            _mapper = mapper;
        }
    }

    // [HttpGet]
    // public async Task<ActionResult> GetOrderDecants()
    // {
        
    // }
}