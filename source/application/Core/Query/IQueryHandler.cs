namespace Archer.Core.Query
{
	using System;

	public interface IQueryHandler<in TParameter, out TResult>
		where TResult : IQueryResult
		where TParameter : IQuery
	{
		TResult Retrieve(TParameter query);
	}
}