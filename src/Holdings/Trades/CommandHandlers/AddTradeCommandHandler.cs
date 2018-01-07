using Holdings.Commands;
using Holdings.Data;
using Holdings.Trades.Commands;
using System;

namespace Holdings.Trades.CommandHandlers
{
    public class AddTradeCommandHandler : ICommandHandler<AddTradeCommand>
    {
        private readonly HoldingsContext context;

        public AddTradeCommandHandler(HoldingsContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            this.context = context;
        }

        public void Handle(AddTradeCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}
