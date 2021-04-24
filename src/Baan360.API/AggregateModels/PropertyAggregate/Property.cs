using Baan360.API.AggregateModels.SharedAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baan360.API.AggregateModels.PropertyAggregate
{
    public class Property : BaseEntity, IProperty
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime ExpiredOn { get; set; }

        public string Detail { get; set; }

        public List<string> Images { get; set; }
    }
}
