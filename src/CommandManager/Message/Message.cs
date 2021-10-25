using System;

namespace Manager
{
    public class Message
    {
        public string Text { get; set; }

        public string SendTime { get; }

        public Message() =>
            this.SendTime = DateTime.Now.ToString("HH:mm:ss");

        public Message(string text) : this() =>
            this.Text = text;
    }
}
