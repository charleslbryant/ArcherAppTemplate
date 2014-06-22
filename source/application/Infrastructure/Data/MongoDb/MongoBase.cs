namespace Archer.Infrastructure.Data.MongoDb
{
	using System;
	using Archer.Core.Configuration;
	using Archer.Core.Entity;
	using MongoDB.Driver;

	public abstract class MongoBase<TEntity> where TEntity : EntityBase
	{
		protected MongoBase(IConfiguration config)
		{
			this.GetDatabase();
			this.GetCollection();
			this.Config = config;
		}

		protected MongoCollection<TEntity> Collection { get; set; }

		protected IConfiguration Config { get; set; }

		protected MongoDatabase Database { get; set; }

		protected void GetCollection()
		{
			this.Collection = this.Database.GetCollection<TEntity>(typeof(TEntity).Name);
		}

		protected string GetConnectionString()
		{
			return this.Config.Get<string>("MongoDbConnectionString").Replace("{DB_NAME}", this.GetDatabaseName());
		}

		protected void GetDatabase()
		{
			var client = new MongoClient(this.GetConnectionString());
			var server = client.GetServer();

			this.Database = server.GetDatabase(this.GetDatabaseName());
		}

		protected string GetDatabaseName()
		{
			return this.Config.Get<string>("MongoDbDatabaseName");
		}
	}
}