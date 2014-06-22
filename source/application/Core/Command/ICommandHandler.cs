namespace Archer.Core.Command
{
	using System;

	public interface ICommandHandler<in TParameter> where TParameter : ICommand
	{
		void Execute(TParameter command);
	}
}