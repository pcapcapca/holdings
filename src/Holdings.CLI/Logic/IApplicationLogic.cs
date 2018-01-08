namespace Holdings.CLI.Logic
{
    interface IApplicationLogic<TOptions>
    {
        int Run(TOptions options);
    }
}
