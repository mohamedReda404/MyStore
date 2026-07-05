using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AppStore.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AppStoreDbContextFactory : IDesignTimeDbContextFactory<AppStoreDbContext>
{
    public AppStoreDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        AppStoreEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<AppStoreDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new AppStoreDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AppStore.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables();

        return builder.Build();
    }
}
