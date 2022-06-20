using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People // We removed the 'NameSpace_And_Class_Test' and made the People namespace, inside the People folder.
{
    public class Person
    {
        public string name;
        public int age;
        public bool hasPet;

        public void Greetings()
        {
            Console.WriteLine("Hello my name is {0} and i am {1} years old, and its {2} that i have a pet.", name, age, hasPet);
        }
    }
}
