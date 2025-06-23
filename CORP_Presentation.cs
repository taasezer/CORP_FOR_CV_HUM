using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// API Controller - Bu sinif, aboneliklerle ilgili HTTP isteklerini isler
[ApiController]
[Route("api/[controller]")]
public class AboneliklerController : ControllerBase
{
    private readonly IAbonelikServis _abonelikServis; // Abonelik servisi

    public AboneliklerController(IAbonelikServis abonelikServis)
    {
        _abonelikServis = abonelikServis; // Constructor ile abonelik servisi enjekte edilir
    }

    [HttpGet]
    public ActionResult<IEnumerable<Abonelik>> TumAbonelikleriGetir()
    {
        return Ok(_abonelikServis.TumAbonelikleriGetir()); // Tum abonelikleri getirir
    }

    [HttpGet("{id}")]
    public ActionResult<Abonelik> IdIleAbonelikGetir(int id)
    {
        var abonelik = _abonelikServis.IdIleAbonelikGetir(id); // Id ile abonelik getirir
        if (abonelik == null)
        {
            return NotFound(); // Abonelik bulunamazsa 404 doner
        }
        return Ok(abonelik); // Abonelik bulursa abonelik nesnesini doner
    }

    [HttpPost]
    public ActionResult AbonelikEkle(Abonelik abonelik)
    {
        _abonelikServis.AbonelikEkle(abonelik); // Yeni bir abonelik ekler
        return CreatedAtAction(nameof(IdIleAbonelikGetir), new { id = abonelik.Id }, abonelik); // Olusturulan aboneligi doner
    }
}