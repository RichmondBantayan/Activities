using InterfaceDemo.Interfaces;

namespace InterfaceDemo.Classes {

     public class Cars : IVehicle {

          private string vehicleName;
          
          public Cars (string name) {

               this.vehicleName = name;
          }

          public string GetVehicleName () {

               return this.vehicleName;
          }

          public void Start () {

               Console.WriteLine("Starting the vehicle...");
          }

          public void Drive () {

               Console.WriteLine("The vehicle is currently driving.");
          }

          public void Stop () {

               Console.WriteLine("The vehicle stopped.");
          }
     }
}