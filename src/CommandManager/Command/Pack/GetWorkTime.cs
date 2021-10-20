namespace Manager
{
    public class GetWorkTime : Command
    {
        private readonly Manager _manager;

        public GetWorkTime(Manager manager)
        {
            _manager = manager;
            Command.Set.Add(this);
            this.Keyword = "сколько времени ты работаешь";
        }

        public override string Execute() => _manager.Stopwatch.ToString();
    }
}
