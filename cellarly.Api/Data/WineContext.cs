using Microsoft.EntityFrameworkCore;
using cellarly.Api.Models;

namespace cellarly.Api.Data
{
    public class WineContext : DbContext
    {
        public WineContext(DbContextOptions<WineContext> options)
            : base(options)
        {

        }

        public DbSet<Wine> Wines { get; set; } = null!;
    }
}
