namespace Archer.Infrastructure.Data
{
	using System;
	using Archer.Core.Configuration;
	using Archer.Core.Entity;
	using Archer.Core.Repository;
	using Archer.Infrastructure.Data.MongoDb;

	public class MongoWriteRepository<TEntity> : MongoBase<TEntity>,
		IWriteRepository<TEntity> where TEntity : EntityBase
	{
		public MongoWriteRepository(IConfiguration config)
			: base(config)
		{
		}

		public bool Delete(TEntity entity)
		{
			return this.Collection.Remove(MongoDB.Driver.Builders.Query.EQ("_id", entity.Id)).DocumentsAffected > 0;
		}

		public bool Insert(TEntity entity)
		{
			if (string.IsNullOrWhiteSpace(entity.Id))
			{
				entity.Id = Guid.NewGuid().ToString("N");
			}

			return this.Collection.Insert(entity).Ok;
		}

		public bool Update(TEntity entity)
		{
			if (entity.Id == null)
			{
				return this.Insert(entity);
			}

			return this.Collection.Save(entity).DocumentsAffected > 0;
		}
	}
}