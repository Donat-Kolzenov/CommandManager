using System.Collections;
using System.Collections.Generic;

namespace Manager
{
    public class MessageHistory : IEnumerable
    {
        private static readonly List<Message> List =
            new List<Message>();

        public static void Add(Message message) =>
            List.Add(message);

        public IEnumerator GetEnumerator()
        {
            foreach (var message in List)
                yield return message;
        }
    }
}
