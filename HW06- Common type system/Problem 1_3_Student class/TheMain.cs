namespace Problem_1_3_Student_class
{
    using System;
    using System.Collections.Generic;
    
    public class TheMain
    {
        static void Main()
        {
            Student georgiStudent = new Student("Georgi", "Ivanov", "Petrov", 12345678, "Sofia, ul.Oborishte 15", "+359888777666",
                "goshko@abv.bg", 2, University.SU, Faculty.FMI, Speciality.AppliedMathematics);
            Console.WriteLine(georgiStudent);
            Console.WriteLine();

            Student ivanStudent = new Student("Ivan", "Ivanov", "Georgiev", 12345679, "Plovdiv, ul.Trakia 18", "+359888777555",
                "vanyo@abv.bg", 2, University.UACEG, Faculty.FacultyOfStructuralEngineering, Speciality.StructuralEngineering);
            Console.WriteLine(ivanStudent);

            Student georgiStudentTwo = new Student("Georgi", "Ivanov", "Petrov", 123456799, "Sofia, ul.Oborishte 15", "+359888777666",
                "goshko@abv.bg", 2, University.SU, Faculty.FMI, Speciality.AppliedMathematics);
            Console.WriteLine(georgiStudent);
            Console.WriteLine();

            Console.WriteLine(georgiStudent.Equals(ivanStudent));
            Console.WriteLine(georgiStudent == georgiStudentTwo); //това трябва да е True
            Console.WriteLine(georgiStudent != georgiStudentTwo); //това трябва да е False
            Console.WriteLine(georgiStudent.GetHashCode());
            Console.WriteLine(ivanStudent.GetHashCode());

            Student ivanCloning = (Student)ivanStudent.Clone();
            Console.WriteLine(ivanCloning);

            Console.WriteLine(georgiStudent.CompareTo(ivanStudent)); //-1, т.е. georgiStudent  е пред ivanStudent в подреждането/сравнението
            Console.WriteLine(ivanStudent.CompareTo(ivanCloning)); //0
            
            


        }
    }
}
