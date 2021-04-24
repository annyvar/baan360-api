using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baan360.API.AggregateModels.PropertyAggregate
{
    public interface IProperty
    {
        string Name { get; set; }

        string Description { get; set; }

        DateTime ExpiredOn { get; set; }

        string Detail { get; set; }

        List<string> Images { get; set; }
    }
}
