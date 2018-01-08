using CommandLine;

namespace Holdings.CLI.Options
{

    [Verb("balance", HelpText = "Execute commands and queries associated with balances.")]
    public class BalanceOptions
    {
        [Option('l', "list",
                HelpText = "Display latest balances from a store (or all stores).",
                SetName = nameof(BalanceOptions))]
        public string ListStore { get; set; }

        [Option('u', "update",
                HelpText = "Update balance snapshots from an exchange (or all exchanges).",
                SetName = nameof(BalanceOptions))]
        public string UpdateExchange { get; set; }
    }
}
