/*Problem 3. First before last
• Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
• Use LINQ query operators.*/

namespace Problem_03_04_05
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class FirstBeforeLastName
    {
        //Using LINQ query
        public static List<Student> FindStudentsWithFirstBeforeLastNameLINQ(List<Student> students)
        {
            var selectedNamesWithLINQ = from student in students
                                        where student.Firstname.CompareTo(student.Lastname) < 0
                                        select student;
            List<Student> sel = selectedNamesWithLINQ.ToList();

            return sel;
        }

        //Using Lambda expression
        public static List<Student> FindStudentsWithFirstBeforeLastNameLambda(List<Student> students)
        {
            var selectedNamesWithLambda = students.Where(s => s.Firstname.CompareTo(s.Lastname) < 0).Select(s => s);
            List<Student> sel = selectedNamesWithLambda.ToList();
            return sel;
        }
    }
}