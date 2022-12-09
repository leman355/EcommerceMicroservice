using CorePackage.DataAccess.MongoDB.MongoSettings;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorePackage.Entities;

namespace CatalogService.Entities.Concrete
{
    [BsonCollection("subcategories")]
    public class SubCategory : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string SubCategoryName { get; set; }
    }
}
