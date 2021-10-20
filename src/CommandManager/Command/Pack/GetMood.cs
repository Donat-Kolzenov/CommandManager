namespace Manager
{
    public class GetMood : Command
    {
        private readonly CommandManager _manager;

        public GetMood(CommandManager manager)
        {
            _manager = manager;
            Command.Set.Add(this);
            this.Keyword = "как дела";
        }

        public override string Execute() => $"I'm {_manager.Mood}";
    }
}
