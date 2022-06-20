using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using People; // By using this we can use the Person class inside the People namespace.
using BuildingToLiveIn; // Shows we do not have to make a folder to put a new namespace in.


namespace NameSpace_And_Class_Test
{
    class Program
    {
        static void Main()
        {
            Animal animal = new Animal();
            animal.isAlive = true;
            animal.MakeNoise();



            Person Jonny = new Person
            {
                name = "Jonny",
                age = 25,
                hasPet = true
            };
            Jonny.Greetings();



            House houseNumberOne = new House
            {
                rooms = 4
            };
            houseNumberOne.EnterHouse();


            Console.ReadKey();
        }

    }


    
}
