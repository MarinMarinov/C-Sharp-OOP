namespace Problem_1.School_classes
{
    using System;
    using System.Collections.Generic;
    
    public class Teacher : Person, IComment
    {
        private List<Disciplines> disciplines;

        public List<Disciplines> Disciplines
        {
            get { return this.disciplines; }
            private set
            {
                if (value.Count < 0 )
                {
                    throw new ArgumentOutOfRangeException("Each teacher have at least 1 discipline in the set of Disciplines!");
                }
                this.disciplines = value;
            }
        }

        public Teacher(string name) : base(name)
        {
            this.Disciplines = new List<Disciplines>();
        }

        public Teacher(string name, List<Disciplines> setOfDisciplines) : base(name)
        {
            this.Disciplines = setOfDisciplines;
        }

        public string Comment { get; private set; }

        public void MakeComment(string text)
        {
            this.Comment = text;
        }
    }
}
