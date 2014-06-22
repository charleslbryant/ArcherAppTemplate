namespace Archer.Core.Command
{
	using System;

	public interface ICommandDispatcher
	{
		void Dispatch<TParameter>(TParameter command) where TParameter : ICommand;
	}
}