using System.Collections.Generic;

namespace Manager
{
    public abstract class Command
    {
        public static HashSet<Command> Set { get; protected set; } = 
            new HashSet<Command>();

        public string Keyword { get; protected set; }

        public abstract string Execute();
    }
}
