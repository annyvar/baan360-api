using Baan360.API.AggregateModels.PropertyAggregate;
using Baan360.API.AggregateModels.SharedAggregate;
using System;

namespace Baan360.API.Repositories
{
    public interface IPropertyRepository
    {
        CreateResponse CreateProperty(Property property);

        Property ReadProperty(Guid id);

        UpdateResponse UpdateProperty(Guid id, Property property);

        DeleteResponse DeleteProperty(Guid id);
    }
}
