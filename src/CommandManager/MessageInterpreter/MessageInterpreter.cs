using System;

namespace Manager
{
    public class MessageInterpreter
    {
        public Command command;

        public Command Match(Message message)
        {
            foreach (var command in Command.Set)
                if (message.Text.ToLower().Equals(command.Keyword.ToLower()))
                    return command;

            throw new ArgumentException();
        }
    }
}
