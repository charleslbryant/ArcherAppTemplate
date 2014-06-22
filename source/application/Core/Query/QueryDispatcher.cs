namespace Archer.Core.Query
{
	using System;
	using Ninject;

	public class QueryDispatcher : IQueryDispatcher
	{
		private readonly IKernel kernel;

		public QueryDispatcher(IKernel kernel)
		{
			if (kernel == null)
			{
				throw new ArgumentNullException("kernel");
			}
			this.kernel = kernel;
		}

		public TResult Dispatch<TParameter, TResult>(TParameter query)
			where TParameter : IQuery
			where TResult : IQueryResult
		{
			var handler = this.kernel.Get<IQueryHandler<TParameter, TResult>>();
			return handler.Retrieve(query);
		}
	}
}