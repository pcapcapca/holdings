using System;
using Holdings.Commands;
using Holdings.Data;
using Holdings.Trades.Commands;
using Holdings.ApiClients.Binance.Services;

namespace Holdings.Trades.CommandHandlers
{
    /*
    public class UpdateBinanceTradesCommandHandler : ICommandHandler<UpdateBinanceTradesCommand>
    {
        private readonly HoldingsContext context;
        private readonly ITradeService tradeService;

        public UpdateBinanceTradesCommandHandler(HoldingsContext context, ITradeService tradeService)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            if (tradeService == null)
                throw new ArgumentNullException(nameof(tradeService));
            
            this.context = context;
            this.tradeService = tradeService;
        }

        public void Handle(UpdateBinanceTradesCommand command)
        {
            throw new NotImplementedException();
        }
    }
    */
}
