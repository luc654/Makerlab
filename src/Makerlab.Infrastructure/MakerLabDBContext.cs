using Makerlab.Domain.Apparaten;
using Microsoft.EntityFrameworkCore;

namespace Makerlab.Infrastructure;
// https://dev.to/auyeungdavid_2847435260/step-by-step-guide-build-a-crud-blazor-app-with-entity-framework-and-postgresql-3ccj
public class MakerLabDBContext : DbContext
{
    public MakerLabDBContext(DbContextOptions<MakerLabDBContext> options) : base(options) { }

    public DbSet<Apparaat> Apparaten { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Register every device type, so EF stores all of them in the Apparaten table.
        // Test data is added by MainSeeder, not here.
        modelBuilder.Entity<Snijder>();
        modelBuilder.Entity<Printer>();
        modelBuilder.Entity<Soldeerstation>();
        modelBuilder.Entity<VRSet>();
    }
}
