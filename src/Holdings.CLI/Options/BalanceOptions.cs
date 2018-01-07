using CommandLine;

namespace Holdings.CLI.Options
{

    [Verb("balance", HelpText = "Execute commands and queries associated with balances.")]
    class BalanceOptions
    {
        [Option('s', "summary",
                HelpText = "Display a summary of your balances.")]
        public bool Summary { get; set; }

        [Option('u', "update",
                HelpText = "Update balance snapshots from an exchange. (All exchanges if no value is provided)",
                Default = "all")]
        public string UpdateExchange { get; set; }
    }
}
