using ConsoleApp1.Creational_Design_Patterns.Factory_Design_Pattern;
using Gang_Of_Four_Eight_Design_Patterns.Behavioral_Design_Patterns.Observer_Design_Pattern;
using Gang_Of_Four_Eight_Design_Patterns.Creational_Design_Patterns.Builder_Design_Pattern;
using Gang_Of_Four_Eight_Design_Patterns.Creational_Design_Patterns.Singleton_Design_Pattern;

// Factory Pattern Use ------------------------------------------
/*
CarFactory myCarFactory = new();

myCarFactory.CreateCar("Honda").PrintCar();
myCarFactory.CreateMercedesCar().PrintCar();
myCarFactory.CreateUnnamedCar().PrintCar();
*/

// Builder Pattern Use -------------------------------------------
/*
CarBuilder myCarBuilder = new();

Gang_Of_Four_Eight_Design_Patterns.TestData.Builder_Pattern_Test_Data.Car car = myCarBuilder.addName("Honda")
            .addEngine("1.5 Engine")
            .addColor("White")
            .addHp("122")
            .build();

car.PrintCar();
*/

// Singleton Pattern Use -----------------------------------------
/* 
SingletonApplicationState myState1 = SingletonApplicationState.getAppState();
SingletonApplicationState myState2 = SingletonApplicationState.getAppState();

Console.WriteLine(myState1.TestVariable);
Console.WriteLine(myState2.TestVariable);

myState1.TestVariable = true;

Console.WriteLine(myState1.TestVariable);
Console.WriteLine(myState2.TestVariable);
*/

Publisher publisher = new Publisher("Publisher1");

Subscriber Sub1 = new Subscriber("Sub1");
Subscriber Sub2 = new Subscriber("Sub2");
Subscriber Sub3 = new Subscriber("Sub3");
Subscriber Sub4 = new Subscriber("Sub4");

publisher.Subscribe(Sub1);
publisher.Subscribe(Sub2);
publisher.Subscribe(Sub3);
publisher.Subscribe(Sub4);

publisher.Notify("New event!!!");