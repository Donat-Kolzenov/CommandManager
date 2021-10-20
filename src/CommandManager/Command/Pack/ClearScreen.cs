namespace Manager
{
    public class ClearScreen : Command
    {
        protected readonly IDisplayable _display;

        public ClearScreen(IDisplayable display)
        {
            _display = display;
            Command.Set.Add(this);
            this.Keyword = "очисти экран";
        }

        public override string Execute()
        {
            _display.ClearScreen();
            return "Display was clear";
        }
    }
}
