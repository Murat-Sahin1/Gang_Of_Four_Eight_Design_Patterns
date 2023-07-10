using ConsoleApp1.Creational_Design_Patterns.Factory_Design_Pattern;
using Gang_Of_Four_Eight_Design_Patterns.Creational_Design_Patterns.Builder_Design_Pattern;

// Factory Pattern Use
/*
CarFactory myCarFactory = new();

myCarFactory.CreateCar("Honda").PrintCar();
myCarFactory.CreateMercedesCar().PrintCar();
myCarFactory.CreateUnnamedCar().PrintCar();
*/

// Builder Pattern Use
CarBuilder myCarBuilder = new();

Gang_Of_Four_Eight_Design_Patterns.TestData.Builder_Pattern_Test_Data.Car car = myCarBuilder.addName("Honda")
            .addEngine("1.5 Engine")
            .addColor("White")
            .addHp("122")
            .build();

car.PrintCar();