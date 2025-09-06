using GameApp.Equipment;
using GameApp.Libraries.Abstracts;
    namespace GameApp
    {
        public class Program 
        {
            public static void Main(String [] args)
            {
                GameItem sld = new Shield("Iron Shield", 25);
                GameItem pot = new Potion("Potion", 70);
                Bonus bonus = new Bonus();

                sld.ShowInfo();
                sld.UseItem();
                pot.ShowInfo();
                pot.UseItem();
            }
        }
    }
