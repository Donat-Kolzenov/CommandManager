namespace Manager
{
    public class GetCorrespondence : Command
    {
        public GetCorrespondence()
        {
            Command.Set.Add(this);
            this.Keyword = "покажи нашу переписку";
        }

        public override string Execute()
        {
            return null; // No implementation
        }
    }
}
