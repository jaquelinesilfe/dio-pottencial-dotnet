using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.common.Models
{
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public void Show ( ) {
            Console.WriteLine ($"Olá meu nome é {Name} e tenho {Age} anos");
        }
    }
}