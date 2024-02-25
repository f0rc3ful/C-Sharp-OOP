namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SoulMaster wizardDrived = new SoulMaster("masterOfNothing", 0);
            System.Console.WriteLine(wizardDrived);

            BladeKnight knoit = new BladeKnight("galaxyKeeper", 5);
            System.Console.WriteLine(knoit);
        }
    }
}