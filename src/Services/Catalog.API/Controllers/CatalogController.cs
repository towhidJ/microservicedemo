﻿using System.Net;
using Catalog.API.Interfaces.Manager;
using Catalog.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private IProductManager _productManager;

        public CatalogController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Product>),(int)HttpStatusCode.OK)]
        public IActionResult GetProduct()
        {
            var products = _productManager.GetAll();
            return Ok(products);
        }
    }
}
