namespace Archer.Core.Cache
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface ICache
	{
		T Get<T>(string key, T defaultValue = default(T), bool throwException = false);
		void Set<T>(string key, T value);
	}
}
