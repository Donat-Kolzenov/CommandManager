using System;

namespace Manager
{
    public class GetLocalTime : Command
    {
        public GetLocalTime()
        {
            Command.Set.Add(this);
            this.Keyword = "сколько сейчас времени";
        }

        public override string Execute() => DateTime.Now.ToString();
    }
}
