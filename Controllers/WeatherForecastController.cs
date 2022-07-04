using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CryptoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoinstController : ControllerBase
{
    private Contexto _contexto;

    public CoinstController(Contexto contexto)
    {
        _contexto = contexto;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Coins>>> GetCoins(){
        var lista = await _contexto.Coins.ToListAsync();
        return lista;
    }

   [HttpPost]
    public async Task<ActionResult<Coins>> PostCoin(Coins coin){
        try{
            if (coin.MonedaId >= 0){
                if(CoinExiste(coin.MonedaId)){
                    _contexto.Entry(coin).State = EntityState.Modified;
                    await _contexto.SaveChangesAsync();
                    return Ok();
                }
                else{
                    _contexto.Coins.Add(coin);
                    await _contexto.SaveChangesAsync();
                    return CreatedAtAction("GetCoins", new {id = coin.MonedaId}, coin);
                }
            }
            else{
                return CreatedAtAction("PostAsync", coin);
            }
        }
        catch(Exception){
            throw;
        }
    }

    private bool CoinExiste(int id){
        var existe = _contexto.Coins.Any(x => x.MonedaId == id);
        return existe;
    }
}
