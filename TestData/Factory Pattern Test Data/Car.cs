namespace Gang_Of_Four_Eight_Design_Patterns.TestData.Factory_Pattern_Test_Data
{
    public class Car
    {
        private string _name { get; set; }
        private string[] _parts { get; set; }
        public Car() { }

        // Factory Pattern Constructor
        public Car(string[] Parts, string name = "Unnamed")
        {
            _parts = Parts;
            _name = name;
        }
        public void PrintCar()
        {
            Console.WriteLine(_name + " Car:");
            _parts.ToList().ForEach(Console.WriteLine);
            Console.WriteLine("\n");
        }
    }
}
