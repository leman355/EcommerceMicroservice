using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Entities.Concrete
{
    public class Feature
    {
        public string FeatureKey { get; set; }
        public List<FeatureValue> FeatureValues { get; set; }
    }
}