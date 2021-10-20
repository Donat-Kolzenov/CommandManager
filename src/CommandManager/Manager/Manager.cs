using System.Diagnostics;

namespace Manager
{
    public abstract class Manager
    {
        public Stopwatch Stopwatch { get; protected set; }

        public string Answer { get; protected set; }

        public string Alias { get; protected set; }
    }
}
