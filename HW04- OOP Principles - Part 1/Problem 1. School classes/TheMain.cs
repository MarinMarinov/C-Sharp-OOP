namespace Problem_1.School_classes
{
    using System;
    using System.Collections.Generic;
    
    class TheMain
    {
        static void Main()
        {
            //Person newPerson = new Person("Gosho"); //правя класа абстрактен, за да не може да се инстанцира
            
            Student studentPesho = new Student("Pesho", 11222);
            Console.WriteLine(studentPesho.Name + " " + studentPesho.ClassNumber);
            studentPesho.MakeComment("Very clever student");
            

            Student studentGosho = new Student("Gosho", 11333);
            studentGosho.MakeComment("Not so clever student");

            List<Student> students = new List<Student>();
            students.Add(studentPesho);
            students.Add(studentGosho);
            Console.WriteLine(studentPesho.Name+ " " + studentPesho.Comment);
            Console.WriteLine(studentGosho.Name+ " " + studentGosho.Comment);

            Console.WriteLine("-----------------------");
            Console.WriteLine();

            Disciplines geometry = new Disciplines("Geometry", 10, 12);
            geometry.MakeComment("Hyperbolic Geometry of Lobachevski ");
            Console.WriteLine(geometry.Name + " " + geometry.NumberOfLectures + " " + geometry.NumberOfExercises + " " + geometry.Comment);
            

            Disciplines algebra = new Disciplines("Algebra", 12, 14);
            algebra.MakeComment("Lobachevski method for approximation of the roots of algebraic equations");
            Console.WriteLine(algebra.Name + " " + algebra.NumberOfLectures + " " + algebra.NumberOfExercises + " " + algebra.Comment);
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            Disciplines mathematics = new Disciplines("Mathematics", 11, 15);
            mathematics.MakeComment("Common mathematic methods");

            Disciplines literature = new Disciplines("Literature", 20, 30);
            literature.MakeComment("Bulgarian literature");

            List<Disciplines> lobachevskiSet = new List<Disciplines>() { geometry, algebra };
            foreach (Disciplines item in lobachevskiSet)
            {
                Console.WriteLine(item.Name + " " + item.NumberOfLectures + " " + item.NumberOfExercises);
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            
            Teacher teacherLobachevski = new Teacher("Nikolai Lobachevsky", lobachevskiSet);
            teacherLobachevski.Disciplines.Add(mathematics);
            teacherLobachevski.MakeComment("Great Russian mathematician");
            Console.WriteLine(teacherLobachevski.Name);
            
            foreach (Disciplines item in teacherLobachevski.Disciplines)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            Teacher teacherVazov = new Teacher("Ivan Vazov");
            teacherVazov.Disciplines.Add(literature);
            teacherVazov.MakeComment("Great Bulgarian writer");
            foreach (Disciplines item in teacherVazov.Disciplines)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(teacherLobachevski);
            teachers.Add(teacherVazov);

            SchoolClass classA = new SchoolClass("A class", students, teachers);
            Console.WriteLine("Students of Class A:");
            foreach (var student in classA.Students)
            {                
                Console.WriteLine(student.Name + " " + student.ClassNumber + " " + student.Comment);
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            Console.WriteLine("Teachers of Class A:");
            foreach (var teacher in classA.Teachers)
            {
                Console.WriteLine(teacher.Name + " " + teacher.Comment);
            }
            Console.WriteLine();
            Console.WriteLine("That's enough for this Problem");
            


            

            
           
            
            
        }
    }
}
