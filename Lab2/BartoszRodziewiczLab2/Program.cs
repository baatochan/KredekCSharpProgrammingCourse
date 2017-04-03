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

            Console.WriteLine(myCar.Move());
            Console.WriteLine("Mam "+ myCar.NumberOfWheels+ " koła.");
            Console.WriteLine();//pusta linia

            Console.WriteLine(myBike.Move());
            Console.WriteLine("Mam "+ myBike.NumberOfWheels+ " koła.");
            Console.WriteLine();//pusta linia

            myVehicle = myCar;
            Console.WriteLine(myVehicle.Move());
            Console.WriteLine("Mam "+ myVehicle.NumberOfWheels+ " koła.");
            Console.WriteLine();//pusta linia

            myVehicle = myBike;
            Console.WriteLine(myVehicle.Move());
            Console.WriteLine("Mam "+ myVehicle.NumberOfWheels+ " koła.");
            Console.WriteLine();//pusta linia

            Vehicle mySecondVehicle = new Car();
            Console.WriteLine(mySecondVehicle.Move());
            Console.WriteLine("Mam " + mySecondVehicle.NumberOfWheels + " koła.");
            Console.WriteLine();//pusta linia

            Vehicle myThirdVehicle = new Bicycle();
            Console.WriteLine(myThirdVehicle.Move());
            Console.WriteLine("Mam " + myThirdVehicle.NumberOfWheels + " koła.");
            Console.WriteLine();//pusta linia

            Console.ReadKey();//blokuje automatyczne zamkniecie konsoli
        }
    }
}
