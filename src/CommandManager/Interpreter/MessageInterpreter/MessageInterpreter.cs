namespace Manager
{
    public class MessageInterpreter
    {
        public Command Command { get; private set; }

        private readonly Database _database;

        public MessageInterpreter(Database database) =>
            _database = database;

        public void Match(Message message)
        {
            MessageHistory.Add(new Message(message.Text));
            this.Command = new Mistake(message);

            foreach (Command command in _database)
                if (message.Text.ToLower().Equals(command.Keyword.ToLower()))
                {
                    this.Command = command;
                    break;
                }
        }
    }
}
