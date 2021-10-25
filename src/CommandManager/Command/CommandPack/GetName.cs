namespace Manager
{
    public class GetName : Command
    {
        private readonly Manager _manager;

        public GetName(Manager manager)
        {
            _manager = manager;
            this.Keyword = "Как тебя зовут";
        }

        public override string Execute() =>
            "Меня зовут " + _manager.Alias;
    }
}