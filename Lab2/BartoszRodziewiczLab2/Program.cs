using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartoszRodziewiczLab2 {
    class Program {
        static void Main(string[] args) {
            Car myCar = new Car();
            Bicycle myBike = new Bicycle();
            Vehicle myVehicle;

            myCar.Move();
            Console.WriteLine("Mam "+ myCar.NumberOfWheels+ " koła.");
            Console.WriteLine();//pusta linia

            myBike.Move();
            Console.WriteLine("Mam "+ myBike.NumberOfWheels+ " koła.");
            Console.WriteLine();//pusta linia

            myVehicle = myCar;
            myVehicle.Move();
            Console.WriteLine("Mam "+ myVehicle.NumberOfWheels+ " koła.");
            Console.WriteLine();//pusta linia

            myVehicle = myBike;
            myVehicle.Move();
            Console.WriteLine("Mam "+ myVehicle.NumberOfWheels+ " koła.");
            Console.WriteLine();//pusta linia

            Console.ReadKey();//blokuje automatyczne zamkniecie konsoli
        }
    }
}
