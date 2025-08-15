public class ProdutoCreateDto
{
    public string Nome { get; set; } = "";
    public decimal Preco { get; set; }
    public string Categoria { get; set; } = "";
}
public class ProdutoReadDto {
    public Guid Id { get; set; } 
    public string Nome { get; set; } = ""; 
    public decimal Preco { get; set; } 
    public string Categoria { get; set; } = ""; 
}
