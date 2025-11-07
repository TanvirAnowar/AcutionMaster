using Microsoft.EntityFrameworkCore;
using Auction.SVC.Entities;

namespace Auction.SVC.Data
{
    public class AuctionDbContext: DbContext
    {
        public AuctionDbContext(DbContextOptions<AuctionDbContext> options) : base(options)
        {
        }
        public DbSet<Entities.Auction> Auctions { get; set; }
        public DbSet<Entities.Item> Items { get; set; }
    }
}
