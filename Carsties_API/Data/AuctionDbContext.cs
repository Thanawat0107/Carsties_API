using Carsties_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Carsties_API.Data
{
    public class AuctionDbContext : DbContext
    {
        public AuctionDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Auction> Auctions { get; set; }
    }
}
