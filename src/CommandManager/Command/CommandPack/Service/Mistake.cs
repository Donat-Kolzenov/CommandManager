namespace Manager
{
    public class Mistake : Command
    {
        public Mistake(Message message) =>
            this.Keyword = message.Text;

        public override string Execute() =>
            $"\"{this.Keyword}\" не является командой\n" +
            $"\"{new Help().Keyword}\" для полной справки";
    }
}
