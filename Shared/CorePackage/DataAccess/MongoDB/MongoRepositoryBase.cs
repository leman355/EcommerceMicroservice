using CorePackage.DataAccess.MongoDB.MongoSettings;
using CorePackage.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CorePackage.DataAccess.MongoDB
{
    public class MongoRepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : class, IEntity, new()
    {
        private readonly IMongoCollection<TEntity> _collection;
        private protected string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType.GetCustomAttributes(
                typeof(BsonCollectionAttribute),
                true)
                .FirstOrDefault())?.CollectionName;
        }
        public MongoRepositoryBase(IDatabaseSettings databaseSettings)
        {
            var database = new MongoClient(databaseSettings.ConnectionString).GetDatabase(databaseSettings.DatabaseName);
            _collection = database.GetCollection<TEntity>(GetCollectionName(typeof(TEntity)));
        }
        public void Add(TEntity entity)
        {
            _collection.InsertOne(entity);
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            var result = _collection.Find<TEntity>(filter).FirstOrDefault();
            return (TEntity)result;
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            return filter == null 
                ? _collection.Find(x => true).ToList()
                : _collection.Find(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
