using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gang_Of_Four_Eight_Design_Patterns.TestData.Builder_Pattern_Test_Data
{
    public class Car
    {
        private string _engine { get; set; }
        private string _name { get; set; }
        private string _hp { get; set; }
        private string _color { get; set; }

        // Builder Pattern Methods
        public Car setEngine(string engine)
        {
            _engine = engine;
            return this;
        }
        public Car setName(string name)
        {
            _name = name;
            return this;
        }
        public Car setHp(string hp)
        {
            _hp = hp;
            return this;
        }
        public Car setColor(string color)
        {
            _color = color;
            return this;
        }
        public void PrintCar()
        {
            Console.WriteLine("Car: " + _name + " " + _hp + " " + _color + " " + _engine);
        }
    }
}
