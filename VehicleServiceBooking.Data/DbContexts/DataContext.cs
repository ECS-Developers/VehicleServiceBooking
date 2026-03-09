using Microsoft.EntityFrameworkCore;

namespace VehicleServiceBooking.Data.DbContexts;

public class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions opt) : base(opt)
    {
    }
}