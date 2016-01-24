using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animal_hierarchy
{
    public abstract class Cat : Animal, ISound
    {
        public string Breed { get; private set; } //!!!!! protected or private

        public Cat(string name, byte age, string breed)
            : base(name, age )
        {
            this.Breed = breed;
        }
    }
}
