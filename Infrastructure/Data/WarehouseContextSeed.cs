using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class WarehouseContextSeed
    {
        public static async Task SeedAsync(WarehouseContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.Grades.Any())
                {
                    var gradesData = File.ReadAllText("../Infrastructure/Data/SeedData/Grades.json");

                    var grades = JsonSerializer.Deserialize<List<Grade>>(gradesData);

                    foreach (var item in grades)
                    {
                        context.Grades.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Warehouses.Any())
                {
                    var warehousesData = File.ReadAllText("../Infrastructure/Data/SeedData/Warehouses.json");

                    var warehouses = JsonSerializer.Deserialize<List<Warehouse>>(warehousesData);

                    foreach (var item in warehouses)
                    {
                        context.Warehouses.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.LotNumbers.Any())
                {
                    var lotNumberData = File.ReadAllText("../Infrastructure/Data/SeedData/LotNumbers.json");

                    var lotNumbers = JsonSerializer.Deserialize<List<LotNumber>>(lotNumberData);

                    foreach (var item in lotNumbers)
                    {
                        context.LotNumbers.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Packaging.Any())
                {
                    var packagingData = File.ReadAllText("../Infrastructure/Data/SeedData/Packaging.json");

                    var packaging = JsonSerializer.Deserialize<List<Packaging>>(packagingData);

                    foreach (var item in packaging)
                    {
                        context.Packaging.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                
                if (!context.Statuses.Any())
                {
                    var statusData = File.ReadAllText("../Infrastructure/Data/SeedData/Statuses.json");

                    var statuses = JsonSerializer.Deserialize<List<Status>>(statusData);

                    foreach (var item in statuses)
                    {
                        context.Statuses.Add(item);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Products.Any())
                {
                    var productsData = File.ReadAllText("../Infrastructure/Data/SeedData/Stock.json");

                    var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                    foreach (var item in products)
                    {
                        context.Products.Add(item);
                    }

                    await context.SaveChangesAsync();
                }


            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<WarehouseContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}