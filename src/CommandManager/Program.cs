using Manager;

namespace CommandLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new ConsoleUser();
            var console = new Console();
            var manager = new CommandManager(
                    IManagerState.alias,
                    IManagerState.mood);

            var database = new Commandbase(manager);
            var interpreter = new MessageInterpreter(database);

            new Welcome(console).Execute();
            while (true)
            {
                user.EnterMessage();
                interpreter.Match(user.Message);
                manager.ExecuteCommand(interpreter.Command);
                console.ShowMessage(manager.Answer);

                if (interpreter.Command.GetType()
                    .Equals(new Terminate().GetType()))
                    break;
            }
        }

        interface IManagerState
        {
            static readonly string alias = "Алекс";

            static readonly string mood = "У меня всё отлично";
        }
    }
}
