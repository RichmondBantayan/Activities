using InterfaceDemo.Interfaces;

namespace InterfaceDemo.Classes {

     public class Trucks : IVehicle {

          private string vehicleName;
          
          public Trucks (string name) {

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