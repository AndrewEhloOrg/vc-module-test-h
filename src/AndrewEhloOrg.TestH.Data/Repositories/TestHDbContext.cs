using System.Reflection;
using Microsoft.EntityFrameworkCore;
using VirtoCommerce.Platform.Data.Infrastructure;

namespace AndrewEhloOrg.TestH.Data.Repositories;

public class TestHDbContext : DbContextBase
{
    public TestHDbContext(DbContextOptions<TestHDbContext> options)
        : base(options)
    {
    }

    protected TestHDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<TestHEntity>().ToTable("TestH").HasKey(x => x.Id);
        //modelBuilder.Entity<TestHEntity>().Property(x => x.Id).HasMaxLength(IdLength).ValueGeneratedOnAdd();

        switch (Database.ProviderName)
        {
            case "Pomelo.EntityFrameworkCore.MySql":
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("AndrewEhloOrg.TestH.Data.MySql"));
                break;
            case "Npgsql.EntityFrameworkCore.PostgreSQL":
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("AndrewEhloOrg.TestH.Data.PostgreSql"));
                break;
            case "Microsoft.EntityFrameworkCore.SqlServer":
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("AndrewEhloOrg.TestH.Data.SqlServer"));
                break;
        }
    }
}
