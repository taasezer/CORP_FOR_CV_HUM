using System;
using System.Collections.Generic;

// Domain model - Bu sinif, abonelik nesnesinin temel yapisini tanimlar
public class Abonelik
{
    public int Id { get; set; } // Abonelik kimligi
    public string Ad { get; set; } // Abonelik adi
    public decimal Fiyat { get; set; } // Abonelik fiyati
    public string Aciklama { get; set; } // Abonelik aciklamasi
}

// Service interface - Bu arayuz, abonelik servislerinin yapmasi gereken islemleri tanimlar
public interface IAbonelikServis
{
    IEnumerable<Abonelik> TumAbonelikleriGetir(); // Tum abonelikleri getirir
    Abonelik IdIleAbonelikGetir(int id); // Id ile abonelik getirir
    void AbonelikEkle(Abonelik abonelik); // Yeni bir abonelik ekler
}