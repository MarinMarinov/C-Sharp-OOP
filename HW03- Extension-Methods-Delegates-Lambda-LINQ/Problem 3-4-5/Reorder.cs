/*Problem 5. Order students
• Using the extension methods  OrderBy()  and  ThenBy()  with lambda expressions sort the students by first name and last name
 in descending order.
• Rewrite the same with LINQ*/

namespace Problem_03_04_05
{
    using System.Collections.Generic;
    using System.Linq;
    
    public class Reorder
    {
        public static List<Student> ReorderWithLambda(List<Student> students)
        {
            var selection = students.OrderByDescending(s => s.Firstname).ThenByDescending(s => s.Lastname);
            List<Student> sel = selection.ToList();           
            
            return sel;
        }

        public static List<Student> ReorderWithLINQ(List<Student> students)
        {
            var selection = from student in students
                            orderby student.Firstname descending, student.Lastname descending
                            select student;
            List<Student> sel = selection.ToList();

            return sel;
        }
    }
}