﻿using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data.Contracts
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> products { get; }
    }
}
