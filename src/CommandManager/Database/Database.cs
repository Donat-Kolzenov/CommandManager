using System.Collections;

namespace Manager
{
    public abstract class Database : IEnumerable
    {
        public Manager Manager { get; protected set; }

        public abstract IEnumerator GetEnumerator();
    }
}
