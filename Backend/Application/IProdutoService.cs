public interface IProdutoService
{
    Task<ProdutoReadDto> CreateAsync(ProdutoCreateDto dto);
    Task<IReadOnlyList<ProdutoReadDto>> GetAllAsync();
}
