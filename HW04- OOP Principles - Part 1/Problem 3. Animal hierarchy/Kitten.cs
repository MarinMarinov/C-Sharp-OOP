using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animal_hierarchy
{
    public class Kitten: Cat, ISound
    {
        public Gender Gender { get; private set; }
        
        public Kitten(string name, byte age, string breed)
            : base(name, age, breed)
        {
            this.Gender = Gender.Female;
        }

        public override void MakeSound()
        {
            Console.WriteLine("{0} says: \"Myauuuuuuu, myauuuuuu...\"", this.Name);
        }        
    }
}
