using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RealEstatePlace.Data;
using RealEstatePlace.Data.Entities;

namespace RealEstatePlace.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly IRealEstateRepository _repository;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IRealEstateRepository repository, ILogger<ProductsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<IEnumerable<Product>> Get()
        {
            try
            {
                return Ok(_repository.GetAllProducts());
            }
            catch (Exception e)
            {
                _logger.LogError($"Failed to get products: {e.Message}");
                return BadRequest("Failed to get products");
            }
            
        }

    }
}
