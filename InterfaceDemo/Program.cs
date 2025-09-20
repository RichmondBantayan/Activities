using InterfaceDemo.Classes;
using InterfaceDemo.Interfaces; // <- Wala ko na butang ni, Sir. Na sanay ko sa Classes/Abstracts 😅

namespace InterfaceDemo {

     public class Program {

          public static void Main (string[] args) {

               IVehicle[] vehicle = new IVehicle[5]; // <- na stuck ko diri kay ang interface gali ang needed, Sir. Also, wla ko ka kita sang ga code ka sir kay wla ga screenshare sa computer ko 😅

               vehicle[0] = new Cars("Lamborgini");
               vehicle[1] = new Cars("Mustang");
               vehicle[2] = new Cars("Ferrari");

               vehicle[3] = new Trucks("Semi-Trailer Truck");

               vehicle[4] = new Bikes("Mountain Bike");

               for (int i = 0; i < 5; i++) {
                    
                    Console.WriteLine("--------------------");

                    Console.WriteLine("");

                    Console.WriteLine("Name: " + vehicle[i].GetVehicleName());

                    Console.WriteLine("");

                    vehicle[i].Start();
                    vehicle[i].Drive();
                    vehicle[i].Stop();

                    Console.WriteLine("");
               }
          }
     }
}