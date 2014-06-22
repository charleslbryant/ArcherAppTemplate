namespace Archer.Core.Configuration
{
	using System;

	public interface IConfiguration
	{
		T Get<T>(string key, T defaultValue = default(T), bool throwException = false) where T : IConvertible;

		void Set<T>(string key, T value) where T : IConvertible;
	}
}