namespace GameApp
{
    public class ProgramBonus
    {
        public static void Bonus()
        {
            string name;
            string lastname;
            
            Console.WriteLine("");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your lastname: ");
            lastname = Console.ReadLine();

            Console.WriteLine("Welcome traveler, " + name + " " + lastname + "!");
        }
    }
}
