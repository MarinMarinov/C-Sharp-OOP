namespace Problem_1.School_classes
{
    using System;
    using System.Collections.Generic;
    
    public class SchoolClass
    {
        private string identifier;
        public List<Student> Students { get; private set; }
        public List<Teacher> Teachers { get; private set; }

        public string Identifier
        {
            get { return this.identifier; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Identifier can't be empty string!");
                }
                this.identifier = value;
            }
        }

        public SchoolClass(string identifier, List<Student> someStudents, List<Teacher> someTeachers)
        {
            this.Identifier = identifier;
            this.Students = someStudents;
            this.Teachers = someTeachers;
        }

        public string Comment { get; private set; }

        public void MakeComment(string text)
        {
            this.Comment = text;
        }
    }
}
