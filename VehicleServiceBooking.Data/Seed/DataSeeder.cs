using Microsoft.EntityFrameworkCore;
using VehicleServiceBooking.Data.DbContexts;
using VehicleServiceBooking.Data.Models;

namespace VehicleServiceBooking.Data.Seed;

public static class DataSeeder
{
    public static async Task SeedAsync(DataContext context)
    {
        // if (!context.ServiceTypes.Any())
        // {
        //     // Seed data example
        //     var serviceTypes = new List<ServiceType>
        //     {
        //         new()
        //         {
        //             Name = "Oil Change",
        //             Description = "Full synthetic oil change with filter replacement",
        //         },
        //         new()
        //         {
        //             Name = "MOT Test",
        //             Description = "Standard annual MOT inspection",
        //         },
        //         new()
        //         {
        //             Name = "Brake Service",
        //             Description = "Brake pad and disc inspection and replacement",
        //         },
        //         new()
        //         {
        //             Name = "Full Service",
        //             Description = "Comprehensive vehicle health check and service",
        //         }
        //     };
        //
        //     context.ServiceTypes.AddRange(serviceTypes);
        // }
        
      
        await context.SaveChangesAsync();
    }
}