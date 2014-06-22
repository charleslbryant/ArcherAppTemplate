namespace Archer.Core.Logger
{
	using System;

	public interface ILogger
	{
		void Log(LogEntry entry);
	}
}