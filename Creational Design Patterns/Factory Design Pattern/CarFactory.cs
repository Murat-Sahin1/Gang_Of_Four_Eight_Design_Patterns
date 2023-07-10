using Gang_Of_Four_Eight_Design_Patterns.TestData.Factory_Pattern_Test_Data;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1.Creational_Design_Patterns.Factory_Design_Pattern
{
    public class CarFactory
    {
        public Car CreateCar(string name)
        {
            string[] parts = {"Engine 1.5", "Red Paint", "120hp"};
            return new Car(parts, name);
        }

        public Car CreateMercedesCar()
        {
            string[] parts = { "Engine 2.0", "Gray Paint", "255hp" };
            return new Car(parts, "Mercedes");
        }
        public Car CreateUnnamedCar()
        {
            string[] parts = { "Engine X", "X Paint", "Xhp" };
            return new Car(parts);
        }
    }
}
