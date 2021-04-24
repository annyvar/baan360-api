using Baan360.API.AggregateModels.PropertyAggregate;
using Baan360.API.AggregateModels.SharedAggregate;
using System;

namespace Baan360.API.DomainServices
{
    public interface IPropertyService
    {
        CreateResponse CreateProperty(CreatePropertyRequest createPropertyRequest);

        // Get data with pagination format
        //PropertiesDataSourceResponse ReadPropertiesDataSource(PropertiesDataSourceRequest propertiesDataSourceRequest);

        ReadPropertyResponse ReadProperty(Guid id);

        UpdateResponse UpdateProperty(Guid id, UpdatePropertyRequest updatePropertyRequest);

        DeleteResponse DeleteProperty(Guid id);
    }
}
