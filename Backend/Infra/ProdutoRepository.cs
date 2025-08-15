using Microsoft.EntityFrameworkCore;

public class ProdutoRepository : IProdutoRepository
{
    private readonly AppDbContext _ctx;
    public ProdutoRepository(AppDbContext ctx) => _ctx = ctx;

    public async Task<Produto> AddAsync(Produto produto)
    {
        _ctx.Produtos.Add(produto);
        await _ctx.SaveChangesAsync();
        return produto;
    }

    public async Task<IReadOnlyList<Produto>> GetAllAsync()
        => await _ctx.Produtos.AsNoTracking().ToListAsync();
}