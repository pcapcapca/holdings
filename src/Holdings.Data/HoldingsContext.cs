using Holdings.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Holdings.Data
{
    public class HoldingsContext : DbContext
    {
        public HoldingsContext(DbContextOptions<HoldingsContext> options)
            : base(options)
        {
        }

        public DbSet<BalanceSnapshot> BalanceSnapshots { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<FiatDeposit> FiatDeposits { get; set; }
        public DbSet<FiatWithdrawal> FiatWithdrawals { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Trade> Trades { get; set; }
    }
}
