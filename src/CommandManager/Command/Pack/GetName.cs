namespace Manager
{
    public class GetName : Command
    {
        private readonly Manager _manager;

        public GetName(Manager manager)
        {
            _manager = manager;
            Command.Set.Add(this);
            this.Keyword = "как тебя зовут";
        }

        public override string Execute() => $"My name is {_manager.Alias}";
    }
}