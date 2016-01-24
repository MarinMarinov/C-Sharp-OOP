namespace Problem_3.Animal_hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class TheMain
    {
        static void Main()
        {
            Tomcat tomCat = new Tomcat("Tom", 4, "Siam");
            Console.WriteLine(tomCat.Name + " is age " + tomCat.Age + " and breed " + tomCat.Breed + " and is " + tomCat.Gender);
            tomCat.MakeSound();

            Console.WriteLine();

            Kitten pussyCat = new Kitten("Pussy", 2, "Angora");
            Console.WriteLine(pussyCat.Name + " is age " + pussyCat.Age + " and breed " + pussyCat.Breed + " and is " + pussyCat.Gender);
            pussyCat.MakeSound();
            Console.WriteLine();

            Dog balkanDog = new Dog("Balkan", 4, Gender.Male, "Bulgarian sheperd");
            Console.WriteLine(balkanDog.Name + " is age " + balkanDog.Age + " and breed " + balkanDog.Breed + " and is " + balkanDog.Gender);
            balkanDog.MakeSound();
            Console.WriteLine();

            Frog frogy = new Frog("Sluzestio", 2, Gender.Male);
            Console.WriteLine(frogy.Name + " is age " + frogy.Age + " and is " + frogy.Gender);
            frogy.MakeSound();

            Animal[] animals =
            {
                new Dog("Murdjo", 8, Gender.Male, "Pomiar"),
                new Dog("Sharo", 6, Gender.Male, "German sheper"),
                balkanDog,
                new Dog("Bonka", 4, Gender.Female, "Bolonka"),

                new Frog("Kerkendeto", 2, Gender.Male),
                new Frog("Zelenka", 2, Gender.Female),
                frogy,
                
                new Kitten("Maca", 2, "Angora"), 
                pussyCat, 
                new Tomcat("Ohoboho", 3, "Ulichna prevazhodna"),
                tomCat, 
            };

            double averageDogsAge = animals.Where(x => x is Dog).Average(x => x.Age);
            double averageFrogsAge = animals.Where(x => x is Frog).Average(x => x.Age);
            double averageCatsAge = animals.Where(x => x is Cat).Average(x => x.Age);

            Console.WriteLine("Average age of the dogs: {0}", averageDogsAge);
            Console.WriteLine("Average age of the frogs: {0}", averageFrogsAge);
            Console.WriteLine("Average age of the cats: {0}", averageCatsAge);
        }
    }
}
