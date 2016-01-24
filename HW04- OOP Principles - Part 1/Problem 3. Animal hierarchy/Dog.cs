using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animal_hierarchy
{
    public class Dog : Animal, ISound
    {
        public string Breed { get; private set; }
        public Gender Gender { get; private set; }

        public Dog(string name, byte age, Gender sex, string breed)
            : base(name, age)
        {
            this.Breed = breed;
            this.Gender = sex;
        }

        public override void MakeSound()
        {
            Console.WriteLine("{0} says: \"Bau, bau, bau...\"", this.Name);
        }

    }
}
