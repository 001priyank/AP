using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AudioProject.Infrastructure.Repositories;
using AudioProject.Infrastructure.Core;
using AudioProject.ViewModels;
using AudioProject.Infrastructure.Services;
using AudioProject.Infrastructure.Services.Abstract;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AudioProject.Controllers
{
    [Route("api/[controller]")]
    public class OrderTypeController : Controller
    {
        private readonly IAuthorizationService _authorizationService;
        ILoggingRepository _loggingRepository;
        IOrderTypeService orderTypeService;
        
        public OrderTypeController(IAuthorizationService authorizationService, ILoggingRepository loggingRepository, IOrderTypeService orderTypeService)
        {
            this._authorizationService = authorizationService;
            this._loggingRepository = loggingRepository;
            this.orderTypeService = orderTypeService;
        }

        [HttpGet]
        public OrderTypeViewModel Get()
        {
            var model = new OrderTypeViewModel();
            model.OrderTypeCategories = orderTypeService.GetAllOrderCategories();
            return model;
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
