using Mapster;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using TravUpApi.Api.Models;
using TravUpApi.Domain;
using TravUpApi.Services;

namespace TravUpApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody] CustomerModelOutput model)
        {
            try
            {
                var domainModel = model.Adapt<Customer>();
                _customerService.Add(domainModel);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("addMany")]
        public IActionResult Add(IEnumerable<CustomerModelOutput> customersModelOutputs)
        {
            try
            {
                var domainModels = customersModelOutputs.Adapt<IEnumerable<Customer>>();
                _customerService.Add(domainModels);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpDelete("{id}")]
        [Route("delete")]
        public IActionResult Delete(int id)
        {
            try
            {
                _customerService.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet("{id}")]
        [Route("get")]
        public IActionResult Get(int id)
        {
            try
            {
                var model = _customerService.Get(id);
                var outputModel = model.Adapt<CustomerModelOutput>();

                return Ok(outputModel);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAll()
        {
            try
            {
                var models = _customerService.GetAll();
                var outputModels = models.Adapt<IEnumerable<CustomerModelOutput>>();

                return Ok(outputModels);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] ProductsModelOutput model)
        {
            try
            {
                var domainModel = model.Adapt<Customer>();
                _customerService.Update(domainModel); 

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPut]
        [Route("updateMany")]
        public IActionResult UpdateMany([FromBody] IEnumerable<CustomerModelOutput> models)
        {
            try
            {
                var domainModels = models.Adapt<IEnumerable<Customer>>();
                _customerService.Update(domainModels);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
