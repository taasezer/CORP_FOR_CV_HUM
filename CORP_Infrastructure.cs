using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

// Database Context
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Abonelik> Abonelikler { get; set; }
}

// Repository interface - Bu arayuz, abonelik deposunun yapmasi gereken islemleri tanimlar
public interface IAbonelikRepository
{
    IEnumerable<Abonelik> TumunuGetir(); // Tum abonelikleri getirir
    Abonelik IdIleGetir(int id); // Id ile abonelik getirir
    void Ekle(Abonelik abonelik); // Yeni bir abonelik ekler
}

// Repository implementation - Bu sinif, IAbonelikRepository arayuzunu uygular
public class AbonelikRepository : IAbonelikRepository
{
    private readonly ApplicationDbContext _context; // Veritabani baglami

    public AbonelikRepository(ApplicationDbContext context)
    {
        _context = context; // Constructor ile veritabani baglami enjekte edilir
    }

    public IEnumerable<Abonelik> TumunuGetir()
    {
        return _context.Abonelikler.ToList(); // Tum abonelikleri liste olarak getirir
    }

    public Abonelik IdIleGetir(int id)
    {
        return _context.Abonelikler.Find(id); // Id ile abonelik getirir
    }

    public void Ekle(Abonelik abonelik)
    {
        _context.Abonelikler.Add(abonelik); // Yeni bir abonelik ekler
        _context.SaveChanges(); // Degisiklikleri kaydeder
    }
}