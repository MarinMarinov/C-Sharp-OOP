namespace Problem_1.School_classes
{
    using System;
    
    public class Student: Person, IComment
    {
        private int classNumber;

        public int ClassNumber
        {
            get { return this.classNumber; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Student number must have at least 1 posittive digit");
                }
                this.classNumber = value;
            }
        }

        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public string Comment { get; private set; }

        public void MakeComment(string text)
        {
            this.Comment = text;
        }
    }
}
