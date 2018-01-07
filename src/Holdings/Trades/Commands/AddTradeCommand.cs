using System;
namespace Holdings.Trades.Commands
{
    public class AddTradeCommand
    {
        public decimal Commission { get; set; }
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
