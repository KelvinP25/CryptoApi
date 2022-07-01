using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CryptoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoinstController : ControllerBase
{
    private readonly ILogger<CoinstController> _logger;
    private Contexto _contexto;

    public CoinstController(ILogger<CoinstController> logger, Contexto contexto)
    {
        _logger = logger;
        _contexto = contexto;
    }

    [HttpGet(Name = "GetCoins")]
    public IEnumerable<Coins> Get()
    {
        return _contexto.Conis.AsNoTracking().ToList();
    }

    [HttpPost]
    public async Task<ActionResult<Coins>> PostCoin(Coins coins)
    {
        _contexto.Conis.Add(coins);
        await _contexto.SaveChangesAsync();

        return CreatedAtAction(nameof(PostCoin), coins);
    }
}
