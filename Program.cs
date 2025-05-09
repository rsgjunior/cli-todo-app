// See https://aka.ms/new-console-template for more information
using System.CommandLine;

var rootCommand = new RootCommand("Todo tasks manager");

rootCommand.AddCommand(CreateCommand.GetCommand());

return await rootCommand.InvokeAsync(args);