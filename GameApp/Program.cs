using GameApp.Equipment;
using GameApp.Libraries.Abstracts;

namespace GameApp
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            GameItem sld = new Shield("Iron Shield", 25);
            GameItem pot = new Potion("Potion", 70);

            sld.ShowInfo();
            sld.UseItem();
            pot.ShowInfo();
            pot.UseItem();

            ProgramBonus.Bonus();
        }
    }
}