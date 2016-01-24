using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animal_hierarchy
{
    public abstract class Animal : ISound
    {
        public string Name { get; private set; }
        public byte Age { get; private set; }        

        public Animal(string name, byte age )
        {
            this.Name = name;
            this.Age = age;                    
        }

        public abstract void MakeSound();
    }
}
