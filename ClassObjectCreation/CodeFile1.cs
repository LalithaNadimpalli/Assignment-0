using System;

namespace ClassObjectCreation

{ 
    class Car //Create a car class
{
    string color = "red"; //class members
    int maxSpeed = 200;
        

            static void Main(string[] args)
    {
        Car myObj = new Car();  //Assign an object to car class
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.maxSpeed);

        }
}
}
