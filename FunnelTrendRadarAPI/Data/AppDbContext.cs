using Microsoft.EntityFrameworkCore;
using FunnelTrendRadarAPI.Models.Entities;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Trend> Trend { get; set; }
}
