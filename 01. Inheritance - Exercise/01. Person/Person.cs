using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private int age;
        private string name;

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int Age 
        { get => age; 
            set 
            {
                if (value < 0)
                {
                    return;
                }

                age = value;
            } 
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
