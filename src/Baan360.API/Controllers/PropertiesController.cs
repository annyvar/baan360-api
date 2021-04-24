using Baan360.API.AggregateModels.PropertyAggregate;
using Baan360.API.DomainServices;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Baan360.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {

        private readonly IPropertyService _propertyService;

        public PropertiesController(IPropertyService propertyService)
        {
            _propertyService = propertyService ?? throw new ArgumentNullException(nameof(propertyService));
        }

        [HttpPost]
        public IActionResult CreateProperty(CreatePropertyRequest createPropertyRequest)
        {
            var response = _propertyService.CreateProperty(createPropertyRequest);

            return Ok(response);
        }


        [HttpGet("{id}")]
        public IActionResult ReadProperty(Guid id)
        {
            var response = _propertyService.ReadProperty(id);

            return Ok(response);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProperty(Guid id, UpdatePropertyRequest updatePropertyRequest)
        {
            var response = _propertyService.UpdateProperty(id, updatePropertyRequest);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProperty(Guid id)
        {
            var response = _propertyService.DeleteProperty(id);

            return Ok(response);
        }
    }
}
