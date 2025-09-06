using GameApp.Libraries.Abstracts;

    namespace GameApp.Equipment
    {
        public class Potion : GameItem //Inheritance
        {
            private int HealAmount;

            //constructor of the potion
            public Potion(String Name, int value) : base(Name) 
            {   
                this.HealAmount = value;
            }

            //Overriding the UseItem Keyword to print
            public override void UseItem()
            {
                Console.WriteLine("You drank " + this.Name + ". Restored " + this.HealAmount + " HP!");
            }
        }
    }