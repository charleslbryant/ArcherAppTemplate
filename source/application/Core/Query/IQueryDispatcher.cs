namespace Archer.Core.Query
{
	using System;

	public interface IQueryDispatcher
	{
		TResult Dispatch<TParameter, TResult>(TParameter query)
			where TParameter : IQuery
			where TResult : IQueryResult;
	}
}