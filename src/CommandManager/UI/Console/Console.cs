namespace Manager
{
    public class Console : IDisplayable
    {
        public void ShowAnswer(CommandManager manager)
        {
            System.Console.WriteLine(manager.Answer);
        }

        public void ClearScreen() => System.Console.Clear();
    }
}
