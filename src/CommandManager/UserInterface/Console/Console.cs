namespace Manager
{
    public class Console : IDisplayable
    {
        public void ShowMessage(string message) =>
            System.Console.WriteLine(message);

        public void ClearScreen() => System.Console.Clear();
    }
}
