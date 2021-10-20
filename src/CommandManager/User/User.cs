namespace Manager
{
    class User
    {
        public Message Message { get; private set; }

        public User()
        {
            Message = new Message();
        }

        public void EnterMessage()
        {
            Message.Text = System.Console.ReadLine();
        }
    }
}
