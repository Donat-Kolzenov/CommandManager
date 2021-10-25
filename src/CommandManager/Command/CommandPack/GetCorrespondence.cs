namespace Manager
{
    public class GetCorrespondence : Command
    {
        public GetCorrespondence() =>
            this.Keyword = "Покажи нашу переписку";

        public override string Execute()
        {
            string history = "Начало переписки:\n";

            foreach (Message message in new MessageHistory())
                history += $"> {message.SendTime}: {message.Text}\n";

            return history + "Конец переписки";
        }
    }
}
