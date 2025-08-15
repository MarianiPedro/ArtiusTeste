using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoService _service;
    public ProdutoController(IProdutoService service) => _service = service;

    [HttpPost] // POST 
    public async Task<ActionResult<ProdutoReadDto>> Create([FromBody] ProdutoCreateDto dto)
    {
        try { var created = await _service.CreateAsync(dto); return CreatedAtAction(nameof(GetAll), new { id = created.Id }, created); }
        catch (ArgumentException ex) { return BadRequest(new { error = ex.Message }); }
    }

    [HttpGet] // GET 
    public async Task<ActionResult<IEnumerable<ProdutoReadDto>>> GetAll()
        => Ok(await _service.GetAllAsync());
}