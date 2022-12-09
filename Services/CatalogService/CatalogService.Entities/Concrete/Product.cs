using CorePackage.DataAccess.MongoDB.MongoSettings;
using CorePackage.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogService.Entities.Concrete
{
    [BsonCollection("products")]
    public class Product : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }
        public string Description { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string SubCategoryId { get; set; }
        public List<Feature> Features { get; set; }
    }
}