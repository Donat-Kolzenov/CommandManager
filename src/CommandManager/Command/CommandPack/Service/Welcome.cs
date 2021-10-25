namespace Manager
{
    public class Welcome
    {
        private readonly IDisplayable _display;

        public Welcome(IDisplayable display) =>
            _display = display;

        public void Execute()
        {
            _display.ShowMessage("Привет! Давай пообщаемся");
            _display.ShowMessage($"\"{new Help().Keyword}\" " + 
                "для полной справки");
        }
    }
}
