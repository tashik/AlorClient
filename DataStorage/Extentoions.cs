﻿

using LiteDB;
using Microsoft.Extensions.DependencyInjection;

namespace DataStorage
{
    public static class Extentoions
    {
        public static IServiceCollection AddDataStorage(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ILiteDatabase>(x => new LiteDatabase(@"./DataStorage.db"));
            serviceCollection.AddScoped<IDataStorageWriter, DataStorageWriter>();
            serviceCollection.AddScoped<SecurityStorage>();
            return serviceCollection;
        }
    }
}
