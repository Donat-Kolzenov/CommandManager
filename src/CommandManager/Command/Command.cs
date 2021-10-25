namespace Manager
{
    public abstract class Command
    {
        public string Keyword { get; protected set; }

        public abstract string Execute();
    }
}
