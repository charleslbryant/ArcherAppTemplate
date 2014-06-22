namespace Archer.Core.Configuration
{
	using System;
	using Archer.Core.Cache;

	public class CacheManager
	{
		private ICache cache;

		public CacheManager(ICache cache)
		{
			this.cache = cache;
		}

		public T Get<T>(string key, T defaultValue = default(T), bool throwException = false)
		{
			return this.cache.Get<T>(key, defaultValue, throwException);
		}

		public void Set<T>(string key, T value)
		{
			this.cache.Set<T>(key, value);
		}
	}
}