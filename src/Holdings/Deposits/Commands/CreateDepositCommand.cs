using System;

namespace Holdings.Deposits.Commands
{
    public class CreateDepositCommand
    {
        public CreateDepositCommand()
        {
        }

        public string CurrencySymbol { get; set; }
        public decimal Value { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
