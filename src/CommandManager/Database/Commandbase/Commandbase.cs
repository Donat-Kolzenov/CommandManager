using System.Collections;

namespace Manager
{
    public class Commandbase : Database
    {
        public Commandbase(Manager manager)
        {
            this.Manager = manager;
            foreach (Command command in this)
                Help.List.Add(command.Keyword);
        }

        public override IEnumerator GetEnumerator()
        {
            yield return new GetLocalTime();
            yield return new GetName(Manager);
            yield return new GetMood((CommandManager)Manager);
            yield return new GetWorkTime(Manager);
            yield return new GetCorrespondence();
            yield return new ClearScreen(new Console());
            yield return new Terminate();
            yield return new Help();
        }
    }
}
