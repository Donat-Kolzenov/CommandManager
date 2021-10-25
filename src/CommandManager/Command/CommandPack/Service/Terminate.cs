namespace Manager
{
    public class Terminate : Command
    {
        public Terminate() =>
            this.Keyword = "Выход";

        public override string Execute() =>
            "Всего доброго! Буду рад новой встрече";
    }
}
