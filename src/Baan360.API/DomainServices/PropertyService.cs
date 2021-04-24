using Baan360.API.AggregateModels.PropertyAggregate;
using Baan360.API.AggregateModels.SharedAggregate;
using Baan360.API.Repositories;
using System;

namespace Baan360.API.DomainServices
{
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository _propertyRepository;

        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository ?? throw new ArgumentNullException(nameof(propertyRepository));
        }

        public CreateResponse CreateProperty(CreatePropertyRequest createPropertyRequest)
        {
            var dateTimeNow = DateTime.UtcNow;

            var property = new Property
            {
                Name = createPropertyRequest.Name,
                Description = createPropertyRequest.Description,
                Detail = createPropertyRequest.Detail,
                Images = createPropertyRequest.Images,
                CreatedOn = dateTimeNow,
                ModifiedOn = dateTimeNow
            };

            return _propertyRepository.CreateProperty(property);
        }

        public ReadPropertyResponse ReadProperty(Guid id)
        {
            var property = _propertyRepository.ReadProperty(id);

            var result = new ReadPropertyResponse
            {
                Name = property.Name,
                Description = property.Description,
                Detail = property.Detail,
                Images = property.Images
            };

            return result;
        }

        public UpdateResponse UpdateProperty(Guid id, UpdatePropertyRequest updatePropertyRequest)
        {
            var dateTimeNow = DateTime.UtcNow;

            var property = new Property
            {
                Name = updatePropertyRequest.Name,
                Description = updatePropertyRequest.Description,
                Detail = updatePropertyRequest.Detail,
                Images = updatePropertyRequest.Images,
                ModifiedOn = dateTimeNow
            };

            return _propertyRepository.UpdateProperty(id, property);
        }

        public DeleteResponse DeleteProperty(Guid id)
        {
            return _propertyRepository.DeleteProperty(id);
        }
    }
}
