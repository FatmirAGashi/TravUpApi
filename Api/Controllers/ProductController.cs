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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody] ProductsModelOutput model)
        {
            try
            {
                var domainModel = model.Adapt<Product>();
                _productService.Add(domainModel);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("addMany")]
        public IActionResult Add(IEnumerable<ProductsModelOutput> productsModelOutputs)
        {
            try
            {
                var domainModels = productsModelOutputs.Adapt<IEnumerable<Product>>();
                _productService.Add(domainModels);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _productService.Delete(id);

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
                var model = _productService.Get(id);
                var outputModel = model.Adapt<ProductsModelOutput>();

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
                var models = _productService.GetAll();
                var outputModels = models.Adapt<IEnumerable<ProductsModelOutput>>();

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
                var domainModel = model.Adapt<Product>();
                _productService.Update(domainModel); 

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPut]
        [Route("updateMany")]
        public IActionResult UpdateMany([FromBody] IEnumerable<ProductsModelOutput> models)
        {
            try
            {
                var domainModels = models.Adapt<IEnumerable<Product>>();
                _productService.Update(domainModels);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
