using System.Diagnostics;

namespace Manager
{
    public class CommandManager : Manager
    {
        public string Mood { get; protected set; }

        public CommandManager(string alias, string mood)
        {
            this.Stopwatch = Stopwatch.StartNew();
            this.Alias = alias;
            this.Mood = mood;
        }

        public void ExecuteCommand(Command command)
        {
            Answer = command.Execute();
        }
    }
}
