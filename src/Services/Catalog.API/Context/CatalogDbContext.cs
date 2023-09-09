using MongoRepo.Context;

namespace Catalog.API.Context;

public class CatalogDbContext:ApplicationDbContext
{
    private static IConfiguration configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true)
        .Build();
    public static string? connectionString = configuration.GetConnectionString("Catalog.API");
    public static string? databaseName = configuration.GetValue<string>("DatabaseName");

    public CatalogDbContext() : base(connectionString, databaseName)
    {

    }
}