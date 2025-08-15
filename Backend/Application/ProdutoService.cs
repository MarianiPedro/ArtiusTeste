
public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _repo;
    public ProdutoService(IProdutoRepository repo) => _repo = repo;

    public async Task<ProdutoReadDto> CreateAsync(ProdutoCreateDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Nome)) throw new ArgumentException("Name is required");
        if (dto.Preco < 0) throw new ArgumentException("Price must be non-negative");
        if (string.IsNullOrWhiteSpace(dto.Categoria)) throw new ArgumentException("Category is required");

        var saved = await _repo.AddAsync(new Produto { Nome = dto.Nome.Trim(), Preco = dto.Preco, Categoria = dto.Categoria.Trim() });
        return new ProdutoReadDto { Id = saved.Id, Nome = saved.Nome, Preco = saved.Preco, Categoria = saved.Categoria };
    }

    public async Task<IReadOnlyList<ProdutoReadDto>> GetAllAsync()
        => (await _repo.GetAllAsync()).Select(p => new ProdutoReadDto { Id = p.Id, Nome = p.Nome, Preco = p.Preco, Categoria = p.Categoria }).ToList();
}