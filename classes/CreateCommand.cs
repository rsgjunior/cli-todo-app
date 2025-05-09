using System.CommandLine;

class CreateCommand : ITodoCommand
{
    public static Command GetCommand()
    {
        var createCommand = new Command("create", "Create a new todo");

        var titleOption = new Option<string>("--title", "Todo title") { IsRequired = true };
        titleOption.AddAlias("-t");

        var messageOption = new Option<string>("--message", "Todo message") { IsRequired = true };
        messageOption.AddAlias("-m");

        createCommand.AddOption(titleOption);
        createCommand.AddOption(messageOption);

        createCommand.SetHandler((title, message) =>
        {
            Console.WriteLine($"Creating todo: {title} - {message}");
        }, titleOption, messageOption);

        return createCommand;
    }
}