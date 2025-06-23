using System.Collections.Generic;

// Service implementation - Bu sinif, IAbonelikServis arayuzunu uygular
public class AbonelikServis : IAbonelikServis
{
    private readonly IAbonelikRepository _abonelikRepository; // Abonelik deposu arayuzu

    public AbonelikServis(IAbonelikRepository abonelikRepository)
    {
        _abonelikRepository = abonelikRepository; // Constructor ile abonelik deposu enjekte edilir
    }

    public IEnumerable<Abonelik> TumAbonelikleriGetir()
    {
        return _abonelikRepository.TumunuGetir(); // Tum abonelikleri getirir
    }

    public Abonelik IdIleAbonelikGetir(int id)
    {
        return _abonelikRepository.IdIleGetir(id); // Id ile abonelik getirir
    }

    public void AbonelikEkle(Abonelik abonelik)
    {
        _abonelikRepository.Ekle(abonelik); // Yeni bir abonelik ekler
    }
}