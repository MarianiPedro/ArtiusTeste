public interface IProdutoRepository
{
    Task<Produto> AddAsync(Produto produto);
    Task<IReadOnlyList<Produto>> GetAllAsync();
}