using System;

namespace Constuctor_Example
{
    class Car
    {
        public string model; /*Access Modifiers Public,Private(If Public then can be used in other class)
                                                Private(within the class)*/
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
        }
    }
}

