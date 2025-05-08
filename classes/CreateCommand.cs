using System.CommandLine;

class CreateCommand : ITodoCommand
{
    public static Command GetCommand()
    {
        var createCommand = new Command("create", "Cria um novo todo");

        var titleOption = new Option<string>("--title", "Título do todo") { IsRequired = true };
        titleOption.AddAlias("-t");

        var messageOption = new Option<string>("--message", "Mensagem do todo") { IsRequired = true };
        messageOption.AddAlias("-m");

        createCommand.AddOption(titleOption);
        createCommand.AddOption(messageOption);

        createCommand.SetHandler((title, message) =>
        {
            Console.WriteLine($"Criando todo: {title} - {message}");
        }, titleOption, messageOption);

        return createCommand;
    }
}