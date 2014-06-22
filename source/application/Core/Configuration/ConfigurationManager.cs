namespace Archer.Core.Configuration
{
	using System;

	public class ConfigurationManager
	{
		private IConfiguration configuration;

		public ConfigurationManager(IConfiguration configuration)
		{
			this.configuration = configuration;
		}

		public T Get<T>(string key, T defaultValue = default(T), bool throwException = false) where T : IConvertible
		{
			return this.configuration.Get<T>(key, defaultValue, throwException);
		}

		public void Set<T>(string key, T value) where T : IConvertible
		{
			this.configuration.Set<T>(key, value);
		}
	}
}