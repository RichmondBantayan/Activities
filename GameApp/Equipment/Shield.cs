using GameApp.Libraries.Abstracts;//Import

    namespace GameApp.Equipment
    {
        public class Shield : GameItem //Inheritance
        {
           private int Defense;

            //Constructor of the Shield
            public Shield(String Name, int value) : base(Name)
            { 
                this.Defense = value;
            }

             //Overriding the UseItem Keyword to print
            public override void UseItem()
            {
               Console.WriteLine("You equipped " + this.Name + ". Defense increased by " + this.Defense + "!");
            }
        }
    }