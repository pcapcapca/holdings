using CommandLine;

namespace Holdings.CLI.Options
{

    [Verb("balance", HelpText = "Execute commands and queries associated with balances.")]
    class BalanceOptions
    {
        [Option('s', "summary",
                HelpText = "Display a summary of your balances.",
                SetName = nameof(BalanceOptions))]
        public bool Summary { get; set; }

        [Option('u', "update",
                HelpText = "Update balance snapshots from an exchange (or all exchanges).",
                SetName = nameof(BalanceOptions))]
        public string UpdateExchange { get; set; }
    }
}
