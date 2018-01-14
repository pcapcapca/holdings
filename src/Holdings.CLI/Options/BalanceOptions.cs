using CommandLine;

namespace Holdings.CLI.Options
{

    [Verb("balance", HelpText = "Execute commands and queries associated with balances.")]
    public class BalanceOptions
    {
        [Option('s', "snapshot",
                HelpText = "Display latest balance snapshot from a store (or all stores).",
                SetName = nameof(BalanceOptions))]
        public string LatestSnapshot { get; set; }

        [Option('c', "current",
                HelpText = "Display current balance from a store (or all stores).",
                SetName = nameof(BalanceOptions))]
        public string CurrentBalance { get; set; }

        [Option('u', "update",
                HelpText = "Update balance snapshots from an exchange (or all exchanges).",
                SetName = nameof(BalanceOptions))]
        public string UpdateExchange { get; set; }
    }
}
