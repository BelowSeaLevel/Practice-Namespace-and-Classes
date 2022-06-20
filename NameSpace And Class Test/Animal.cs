using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpace_And_Class_Test
{
    public class Animal
    {
        public string name;
        public int age;
        public bool isAlive;

        public void MakeNoise()
        {
            Console.WriteLine($"Animal is alive: {isAlive}");
            Console.WriteLine("Animal makes noise");
        }
    }
}
