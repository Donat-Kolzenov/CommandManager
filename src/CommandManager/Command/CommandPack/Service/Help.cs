using System.Collections.Generic;

namespace Manager
{
    public class Help : Command
    {
        public static List<string> List { get; private set; } =
            new List<string>();

        public Help() => this.Keyword = "Помощь";

        public override string Execute()
        {
            string message = "Доступные команды:\n";

            foreach (var keyword in List)
                message += "> " + keyword + "\n";

            return message;
        }
    }
}
