using Manager;

namespace CommandLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.EnterMessage();

            var interpreter = new MessageInterpreter();

            string alias = "Boris";
            string mood = "Good";
            var manager = new CommandManager(alias, mood);

            Command command = interpreter.Match(user.Message);
            manager.ExecuteCommand(command);

            var console = new Console();
            console.ShowAnswer(manager);
        }
    }
}
