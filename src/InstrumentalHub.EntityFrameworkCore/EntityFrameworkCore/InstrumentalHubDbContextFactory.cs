using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace InstrumentalHub.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class InstrumentalHubDbContextFactory : IDesignTimeDbContextFactory<InstrumentalHubDbContext>
{
    public InstrumentalHubDbContext CreateDbContext(string[] args)
    {
        // https://www.npgsql.org/efcore/release-notes/6.0.html#opting-out-of-the-new-timestamp-mapping-logic
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        
        var configuration = BuildConfiguration();
        
        InstrumentalHubEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<InstrumentalHubDbContext>()
            .UseNpgsql(configuration.GetConnectionString("Default"));
        
        return new InstrumentalHubDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../InstrumentalHub.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
