using GameApp.Libraries.Interfaces;//Import

    namespace GameApp.Libraries.Abstracts
    {
        public abstract class GameItem : IGameItem //Inherits the interface.
        {
            public string Name; 
            //Item Name
            public GameItem(String Name)
            {
                this.Name = Name;
            }   

            //Show Info for The item
            public void ShowInfo()
            {
                Console.WriteLine("Item: " + this.Name);
                
            }
                //to override Item
            public abstract void UseItem();
        
        }
    }