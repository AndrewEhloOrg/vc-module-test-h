using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using AndrewEhloOrg.TestH.Data.Repositories;

namespace AndrewEhloOrg.TestH.Data.SqlServer;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TestHDbContext>
{
    public TestHDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<TestHDbContext>();
        var connectionString = args.Length != 0 ? args[0] : "Server=(local);User=virto;Password=virto;Database=VirtoCommerce3;";

        builder.UseSqlServer(
            connectionString,
            options => options.MigrationsAssembly(typeof(SqlServerDataAssemblyMarker).Assembly.GetName().Name));

        return new TestHDbContext(builder.Options);
    }
}
