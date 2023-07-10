using Gang_Of_Four_Eight_Design_Patterns.TestData.Builder_Pattern_Test_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gang_Of_Four_Eight_Design_Patterns.Creational_Design_Patterns.Builder_Design_Pattern
{
    public class CarBuilder
    {
        Car newCar = new();
        public CarBuilder addEngine(string Engine)
        {
            newCar.setEngine(Engine);
            return this;
        }
        public CarBuilder addName(string Name)
        {
            newCar.setName(Name);
            return this;
        }
        public CarBuilder addHp(string Hp)
        {
            newCar.setHp(Hp);
            return this;
        }
        public CarBuilder addColor(string Color)
        {
            newCar.setColor(Color);
            return this;
        }
        public Car build()
        {
            return newCar;
        }
    }
}
