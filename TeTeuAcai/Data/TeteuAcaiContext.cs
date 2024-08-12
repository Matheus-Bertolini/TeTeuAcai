using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeTeuAcai.Models;

namespace TeTeuAcai.Data;

public class TeteuAcaiContext : IdentityDbContext
{
    public TeteuAcaiContext(DbContextOptions<TeteuAcaiContext> options) : base(options)
    {
    }

    public DbSet<Acai> Acais { get; set; }
    public DbSet<Calda> Caldas { get; set; }
    public DbSet<Complemento> Complementos { get; set; }
    public DbSet<Sabor> Sabores { get; set; }
    public DbSet<AcaiComplemento> AcaiComplementos { get; set; }

     protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<AcaiComplemento>()
            .HasKey(ac => new { ac.AcaiId, ac.ComplementoId });
    }
}
