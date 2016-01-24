using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animal_hierarchy
{
    public class Tomcat : Cat, ISound
    {
        public Gender Gender { get; protected set; }
        
        public Tomcat(string name, byte age, string breed)
            : base(name, age, breed)
        {
            this.Gender = Gender.Male;
        }

        public override void MakeSound()
        {
            Console.WriteLine("{0} says: \"Mhrrrrrr, mhrrrrrr...\"", this.Name);
        } 
    }
}
