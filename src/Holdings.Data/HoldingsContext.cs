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

        public DbSet<Balance> Balances { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<Withdrawal> Withdrawals { get; set; }
    }
}
