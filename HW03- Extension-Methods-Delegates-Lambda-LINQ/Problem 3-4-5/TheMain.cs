namespace Problem_03_04_05
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    
    class TheMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Bobi", "Perukata", 52),
                new Student("Venzi", "Korema", 55),
                new Student("Naso", "Raev", 51),
                new Student("Kiro", "Gela", 54),
                new Student("Lupi", "Tomov", 55),
                new Student("Todor", "Shmatkov", 54),
                new Student("Joro", "Rendeto", 45),
                new Student("Joro", "Vratarcheto", 43),
                new Student("Joro", "Iliev", 42),
                new Student("Nikoleta", "Lozanova", 19),
                new Student("Alicia", "Pevachkata", 22),
                new Student("Mara", "Otvarachkata", 23)
            };
            
            //problem 3
            Console.WriteLine("Using LINQ query");
            foreach (var item in FirstBeforeLastName.FindStudentsWithFirstBeforeLastNameLINQ(students))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Using Lambda expression");
            foreach (var item in FirstBeforeLastName.FindStudentsWithFirstBeforeLastNameLambda(students))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        
            //problem 4

            foreach (Student student in AgeRange.StudentsInAgeRange(students, 20, 50)) //other parameters, differetn from default parameters
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //problem 5
            Console.WriteLine("Using Lambda expression");
            foreach (Student student in Reorder.ReorderWithLambda(students))
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            Console.WriteLine("Using LINQ query");
            foreach (Student student in Reorder.ReorderWithLINQ(students))
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            Console.WriteLine("The end of these problems");
        }       
    }
}