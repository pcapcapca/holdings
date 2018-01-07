using CommandLine;

namespace Holdings.CLI.Options
{
    [Verb("trade", HelpText = "Execute commands and queries associated with trades.")]
    public class TradeOptions
    {
        [Option('s', "summary",
                HelpText = "Display a summary of your trades.")]
        public bool Summary { get; set; }

        [Option('u', "update",
                HelpText = "Update trades from an exchange. (All exchanges if no value is provided)",
                Default = "all")]
        public string UpdateExchange { get; set; }
    }
}
