using System;

namespace Manager
{
    public class GetLocalTime : Command
    {
        public GetLocalTime() =>
            this.Keyword = "Сколько сейчас времени";

        public override string Execute() =>
            "Текущее время: " + DateTime.Now.ToString("HH:mm:ss");
    }
}
