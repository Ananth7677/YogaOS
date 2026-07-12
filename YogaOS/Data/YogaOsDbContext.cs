using Microsoft.EntityFrameworkCore;

namespace YogaOS.Data;

public class YogaOsDbContext : DbContext
{
    public YogaOsDbContext(DbContextOptions<YogaOsDbContext> options)
        : base(options)
    {
    }

    // Add DbSet<T> properties for your entities here, e.g.:
    // public DbSet<Pose> Poses => Set<Pose>();
}
