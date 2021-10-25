namespace Manager
{
    public class ClearScreen : Command
    {
        private readonly IDisplayable _display;

        public ClearScreen(IDisplayable display)
        {
            _display = display;
            this.Keyword = "Очисти экран";
        }

        public override string Execute()
        {
            _display.ClearScreen();
            return "Экран очищен";
        }
    }
}
