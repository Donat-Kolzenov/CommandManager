namespace Manager
{
    public class ConsoleUser : User
    {
        public ConsoleUser() =>
            this.Message = new Message();

        public void EnterMessage()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            System.Console.Write(">> ");
            System.Console.ForegroundColor = System.ConsoleColor.Gray;
            Message.Text = System.Console.ReadLine();
        }
    }
}
