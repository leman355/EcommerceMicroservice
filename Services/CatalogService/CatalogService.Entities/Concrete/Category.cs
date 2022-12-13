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
    [BsonCollection("categories")]
    public class Category : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string CategoryName { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public List<string> SubCategoryId { get; set; }       //id string
    }
}