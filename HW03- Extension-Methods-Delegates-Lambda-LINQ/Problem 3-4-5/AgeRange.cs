/*Problem 4. Age range
 • Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.*/

namespace Problem_03_04_05
{
    using System.Collections.Generic;
    using System.Linq;

    public class AgeRange
    {
        public static List<Student> StudentsInAgeRange(List<Student> stidents, int startAge = 18, int endAge = 24)//By default parameters
        {
            var selection = from student in stidents
                            where student.Age >= startAge && student.Age <= endAge
                            select student;
            List<Student> sel = selection.ToList();

            return sel;
        }
    }
}
