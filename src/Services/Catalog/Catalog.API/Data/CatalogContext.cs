using Catalog.API.Settings;
using Catalog.API.Data.Contracts;
using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public IMongoCollection<Product> products { get; }

        public CatalogContext(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            products = database.GetCollection<Product>(settings.ProductCollection);
            CatalogContextSeed.SeedData(products);
        }
    }
}
