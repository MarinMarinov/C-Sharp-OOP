using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animal_hierarchy
{
    public class Frog : Animal, ISound
    {
        public Gender Gender { get; private set; }
        
        public Frog(string name, byte age, Gender sex)
            : base(name, age )
        {
            this.Gender = sex;
        }

        public override void MakeSound()
        {
            Console.WriteLine("{0} says: \"Cruak, cruak...\"", this.Name);
        }
    }
}
