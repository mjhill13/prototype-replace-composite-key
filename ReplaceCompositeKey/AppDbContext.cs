using Bogus;
using Microsoft.EntityFrameworkCore;

namespace ReplaceCompositeKey;

public sealed class AppDbContext : DbContext
{
    public DbSet<MyEntity> Entities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=postgres;Port=5432;Database=mydatabase;Username=myuser;Password=mypassword");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<MyEntity>()
            .HasKey(x => new { x.Prop1, x.Prop2 });
        
        // This was used to seed data for the migration
        // Seed(modelBuilder);
    }

    private static void Seed(ModelBuilder modelBuilder)
    {
        var faker = new Faker();
        var generatedKeys = new HashSet<(string, string)>();
        var fakeData = new List<MyEntity>();
        int count = 100; // Generate 100 fake entities
        
        while (fakeData.Count < count)
        {
            var prop1 = faker.Random.AlphaNumeric(8);
            var prop2 = faker.Random.AlphaNumeric(8);
        
            if (generatedKeys.Add((prop1, prop2)))
            {
                fakeData.Add(new MyEntity
                {
                    Prop1 = prop1,
                    Prop2 = prop2,
                    OtherProp = faker.Lorem.Sentence()
                });
            }
        }
        
        modelBuilder.Entity<MyEntity>()
            .HasData(fakeData);
    }
}