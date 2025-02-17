using Microsoft.EntityFrameworkCore;

namespace DatoriumMerch.Models
{
    public class MerchContext : DbContext
    {
        public MerchContext(DbContextOptions<MerchContext> options) : base(options)
        {
            
        }

        public DbSet<Merch> Merches { get; set; } = null!;
    }
}
