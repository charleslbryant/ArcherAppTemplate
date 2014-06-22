namespace Archer.Core.Command
{
	using System;
	using Ninject;

	public class CommandDispatcher : ICommandDispatcher
	{
		private readonly IKernel kernel;

		public CommandDispatcher(IKernel kernel)
		{
			if (kernel == null)
			{
				throw new ArgumentNullException("kernel");
			}

			this.kernel = kernel;
		}

		public void Dispatch<TCommand>(TCommand command) where TCommand : ICommand
		{
			var handler = this.kernel.Get<ICommandHandler<TCommand>>();
			handler.Execute(command);
		}
	}
}