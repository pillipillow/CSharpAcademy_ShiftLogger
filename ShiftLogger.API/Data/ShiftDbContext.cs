using Microsoft.EntityFrameworkCore;
using ShiftLogger.API.Models;

namespace ShiftLogger.API.Data;

public class ShiftDbContext : DbContext
{
    public ShiftDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Shift> Shifts { get; set; }
}
