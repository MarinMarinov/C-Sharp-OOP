namespace Problem_2.Students_and_workers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class TheMain
    {
        static void Main()
        {
            Student studentPesho = new Student("Pesho", "Goshov", 6);
            Console.WriteLine(studentPesho.Grade);

            Worker bayGosho = new Worker("Georgi", "Petrov", 500, 8);
            Console.WriteLine(bayGosho.LastName);
            Console.WriteLine(bayGosho.MoneyPerHour());
            Console.WriteLine("------------------");
            Console.WriteLine();

            List<Student> students = new List<Student>()
            {
                new Student("Bobi", "Perukata", 3.0),
                new Student("Venzi", "Korema", 3.1),
                new Student("Nasko", "Raev", 3.5),
                new Student("Kiro", "Gela", 5.49),
                new Student("Lupi", "Tomov", 5.51),
                new Student("Todor", "Shmatkov", 5.50),                
                new Student("Joro", "Vratarcheto", 2.49),                
                new Student("Nikoleta", "Lozanova", 5.99),
                new Student("Alicia", "Pevachkata", 5.90),
                new Student("Mara", "Otvarachkata", 5.98),
            };

            List<Student> sortedByGrade = (from student in students
                                           orderby student.Grade
                                           select student).ToList();
            foreach (var item in sortedByGrade)
            {
                Console.WriteLine(item); 
            }

            Console.WriteLine("------------------");
            Console.WriteLine();


            List<Worker> workers = new List<Worker>()
            {
                new Worker("Georgi", "Petrov", 689, 8),
                new Worker("Petar", "Georgiev", 598, 8),
                new Worker("Ivan", "Ivanov", 743, 8),
                new Worker("Ivan", "Georgiev", 845, 8),
                new Worker("Dimitar", "Dimitrov", 934, 8),
                new Worker("Petkan", "Petkov", 345, 8),
                new Worker("Nikolay", "Nikolov", 435, 8),
                new Worker("Stefan", "Vasilev", 399, 8),
                new Worker("Vasil", "Stoyanov", 498, 8),
                new Worker("Angel", "Zahariev", 689, 8),
            };

            List<Worker> sortedByMoneyPerHour = (from worker in workers
                                                 orderby worker.MoneyPerHour()
                                                 select worker).ToList();
            foreach (var item in sortedByMoneyPerHour)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();

            List<Human> studentsAndWorkers = new List<Human>();
            studentsAndWorkers.AddRange(students);
            studentsAndWorkers.AddRange(workers);

            List<Human> allOrderdByname = studentsAndWorkers.OrderBy(f => f.FirstName).ThenBy(l => l.LastName).ToList();
            foreach (var item in allOrderdByname)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("The end of the Problem");

        }
    }
}
