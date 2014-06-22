namespace Archer.Core.Logger
{
	using System;

	public class LogManager
	{
		private ILogger logger;

		public LogManager(ILogger logger)
		{
			this.logger = logger;
		}

		public void Log(LogEntry entry)
		{
			this.logger.Log(entry);
		}
	}
}