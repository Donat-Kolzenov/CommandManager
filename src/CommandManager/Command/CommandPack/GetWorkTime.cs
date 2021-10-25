namespace Manager
{
    public class GetWorkTime : Command
    {
        private readonly Manager _manager;

        public GetWorkTime(Manager manager)
        {
            _manager = manager;
            this.Keyword = "Сколько времени ты работаешь";
        }

        public override string Execute() =>
            "Время работы: " + _manager.Stopwatch.Elapsed.ToString();
    }
}
