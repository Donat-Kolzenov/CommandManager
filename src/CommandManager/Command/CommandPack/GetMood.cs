namespace Manager
{
    public class GetMood : Command
    {
        private readonly CommandManager _manager;

        public GetMood(CommandManager manager)
        {
            _manager = manager;
            this.Keyword = "Как дела";
        }

        public override string Execute() =>
            _manager.Mood;
    }
}
