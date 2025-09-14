using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prezi_beispiel
{
    internal class Person
    {
        //fields
        private string name;
        private string role;

        //constructor
        public Person(string name, string role) {
            this.name = name;
            this.role = role;
        }

        //methode
        public void SayHi()
        {
            Console.WriteLine($"hello, my name is {name} and im {role}");

        }
        

    }
}
