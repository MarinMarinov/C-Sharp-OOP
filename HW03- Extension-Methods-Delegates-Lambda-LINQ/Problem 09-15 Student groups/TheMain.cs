/*Problem 9. Student groups
• Create a class  Student  with properties  FirstName ,  LastName ,  FN ,  Tel ,  Email ,  Marks  (a List),  GroupNumber .
• Create a  List<Student>  with sample students. Select only the students that are from group number 2.
• Use LINQ query. Order the students by FirstName.*/

namespace Problem_9.Student_groups
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
                new Student("Bobi", "Perukata", 111101, "+359888111111", "peruka@bfs.bg", new List<byte>(){ 2,3,4,3,4,2,3,4 }, 1),
                new Student("Venzi", "Korema", 222201, "+359888222222", "korema@slavia.bg", new List<byte>(){ 2,3,2,3,4,3,3,5 }, 2),
                new Student("Nasko", "Raev", 333301, "+359888333333", "gospodinRaev@casino.com", new List<byte>(){ 3,3,3,3,4,3,3,3 }, 3),
                new Student("Kiro", "Gela", 444401, "+359888444444", "theBigBoss@crazyforest.rz", new List<byte>(){ 6,6,6,6,6,6,6,6 }, 1),
                new Student("Lupi", "Tomov", 555501, "+359888555555", "theWolfOfWallStreet@cska.bg", new List<byte>(){ 6,6,6,6,6,5,4,3 }, 4),
                new Student("Todor", "Shmatkov", 666601, "+359888666666", "bayGanyo@levski.bg", new List<byte>(){ 3,4,5,6,6,6,6,6 }, 4),
                new Student("Joro", "Rendeto", 777702, "+359029777777", "rende@beorner.de", new List<byte>(){ 2,2,2,2,2,2,2,2 }, 2),
                new Student("Joro", "Vratarcheto", 888802, "+359888888888", "vratarche@idiot.bg", new List<byte>(){ 2,2,2,2,2,2,2,3 }, 2),
                new Student("Joro", "Iliev", 999902, "+359888999999", "budaBar@snaiper.ru", new List<byte>(){ 2,3,3,3,3,3,3,2 }, 3),
                new Student("Nikoleta", "Lozanova", 101006, "+359888101010", "niLo@razvod.bg", new List<byte>(){ 3,3,2,2,3,3,4,3 }, 5),
                new Student("Alicia", "Pevachkata", 121206, "+359029121212", "alicia@abv.bg", new List<byte>(){ 3,2,4,3,3,3,3,4 }, 2),
                new Student("Mara", "Otvarachkata", 212106, "+359028212121", "mara@abv.bg", new List<byte>(){ 3,3,3,5,3,4,3,2 }, 1), //ще ме прощаваш, малко се поувлякох, но ми беше забавно :)
            };

            // Proper setting of Consol window: width >= 110 font Consolas or other for cyrillic

            //Using LINQ - Problem 9
            List<Student> groupNumberTwoLINQ = (from student in students
                                                where student.GroupNumber == 2
                                                orderby student.Firstname
                                                select student).ToList();
            foreach (Student student in groupNumberTwoLINQ)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------");

            // Using Lambda - Problem 10
            List<Student> groupNumberTwo = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.Firstname).ToList();
            foreach (Student student in groupNumberTwo)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------");

            // Problem 11
            List<Student> groupABV = (from student in students
                                      where student.Email.Contains("abv.bg")
                                      select student).ToList();
            foreach (Student student in groupABV)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------");

            //Problem 12
            List<Student> stolichaniVPoveche = (from student in students
                                                where student.Tel.Contains("02")
                                                select student).ToList();
            Console.WriteLine("Столичаните в повече са: ");
            Console.WriteLine();
            foreach (Student stolichaninVPoveche in stolichaniVPoveche)
            {
                Console.WriteLine(stolichaninVPoveche);
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            //Problem 13
            List<Student> outstandings = (from student in students
                                          where student.Marks.Contains(6)
                                          select student).ToList();
            Console.WriteLine("Отличниците са: ");
            foreach (Student outstanding in outstandings)
            {
                Console.WriteLine(outstanding);
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------");

            //Problem 14
            List<Student> theDebils = students.Where(estimates => estimates.Marks.FindAll(n => n == 2).Count == 2).ToList();
            Console.WriteLine("Двойкаджиите са: ");
            foreach (Student debil in theDebils)
            {
                Console.WriteLine(debil);
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------");

            //Problem 15
            Console.WriteLine("Веселите момичета са: ");
            List<Student> thePussyCats = (from student in students
                                          where student.FN.ToString().Contains("06")
                                          select student).ToList();
            foreach (Student pussies in thePussyCats)
            {
                Console.WriteLine(pussies);
            }
            Console.WriteLine();

            Console.WriteLine("Enough is enough!");           
        }
    }
}