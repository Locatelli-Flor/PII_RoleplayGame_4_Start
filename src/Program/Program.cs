using RoleplayGame.Scenarios;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            EscenarioParteVI scenario = new EscenarioParteVI();
            scenario.Setup();
            scenario.Run();
        }
    }
}
