namespace Realty.Application.InfrastructureContracts;

internal interface IQueryRepositoty<TEntity>
{
    IQueryable<TEntity> Query { get; }
}
