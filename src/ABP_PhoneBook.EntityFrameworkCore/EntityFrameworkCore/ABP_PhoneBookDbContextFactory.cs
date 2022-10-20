using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ABP_PhoneBook.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ABP_PhoneBookDbContextFactory : IDesignTimeDbContextFactory<ABP_PhoneBookDbContext>
{
    public ABP_PhoneBookDbContext CreateDbContext(string[] args)
    {
        ABP_PhoneBookEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ABP_PhoneBookDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ABP_PhoneBookDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ABP_PhoneBook.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
