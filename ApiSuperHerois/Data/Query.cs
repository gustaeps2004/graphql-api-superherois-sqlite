using ApiSuperHerois.Entities;

namespace ApiSuperHerois.Data;

public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<SuperHeroi> GetSuperherois([Service] AppDbContext context) =>
        context.SuperHerois;

	[UseProjection]
	[UseFiltering]
	[UseSorting]
	public IQueryable<Filme> GetFilmes([Service] AppDbContext context) =>
	context.Filmes;
}
