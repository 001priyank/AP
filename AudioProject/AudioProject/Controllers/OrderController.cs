using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AudioProject.Infrastructure.Services;
using AudioProject.Infrastructure.Services.Abstract;
using AudioProject.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authorization;
using AudioProject.Entities.OrderManagement;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AudioProject.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IAuthorizationService _authorizationService;
        ILoggingRepository _loggingRepository;
        IOrderService orderService;

        public OrderController(IAuthorizationService authorizationService, ILoggingRepository loggingRepository, IOrderService orderService)
        {
            this._authorizationService = authorizationService;
            this._loggingRepository = loggingRepository;
            this.orderService = orderService;
        }
        // GET: api/values
        [HttpGet]
        [Route("GetDefaultOrder")]
        public Orders GetDefaultOrder()
        {

            return orderService.GetDefaultOrder();
        }
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "value";
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
