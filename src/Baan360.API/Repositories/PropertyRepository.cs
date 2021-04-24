using Baan360.API.AggregateModels.PropertyAggregate;
using Baan360.API.AggregateModels.SharedAggregate;
using Baan360.API.DBContexts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Baan360.API.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly DBContext _dbContext;

        public PropertyRepository(DBContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public CreateResponse CreateProperty(Property property)
        {
            _dbContext.Properties.Add(property);
            _dbContext.SaveChanges();

            return new CreateResponse
            {
                Id = property.Id
            };
        }

        public Property ReadProperty(Guid id)
        {
            var propertyDB = _dbContext.Properties.FirstOrDefault(m => m.Id == id && !m.DeletedOn.HasValue);

            if (propertyDB is null) throw new KeyNotFoundException();

            return propertyDB;
        }

        public UpdateResponse UpdateProperty(Guid id, Property property)
        {
            var propertyDB = _dbContext.Properties.FirstOrDefault(m => m.Id == id && !m.DeletedOn.HasValue);

            if (propertyDB is null) throw new KeyNotFoundException();

            propertyDB.Name = property.Name;
            propertyDB.Description = property.Description;
            propertyDB.Detail = property.Detail;
            propertyDB.Images = property.Images;

            _dbContext.SaveChanges();

            return new UpdateResponse
            {
                Id = propertyDB.Id
            };
        }

        public DeleteResponse DeleteProperty(Guid id)
        {
            var propertyDB = _dbContext.Properties.FirstOrDefault(m => m.Id == id && !m.DeletedOn.HasValue);

            if (propertyDB is null) throw new KeyNotFoundException();

            propertyDB.DeletedOn = DateTime.UtcNow;

            _dbContext.SaveChanges();

            return new DeleteResponse
            {
                Id = propertyDB.Id
            };
        }
    }
}
