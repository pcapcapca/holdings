using Holdings.Commands;
using Holdings.Data;
using Holdings.Deposits.Commands;

namespace Holdings.Deposits.CommandHandlers
{
    public class CreateDepositCommandHandler : ICommandHandler<CreateDepositCommand>
    {
        // TODO: Dekorator z kontekstem plus atrybut
        private readonly HoldingsContext context;
        
        public CreateDepositCommandHandler(HoldingsContext context)
        {
            this.context = context;
        }

        public void Handle(CreateDepositCommand command)
        {
            
        }
    }
}
