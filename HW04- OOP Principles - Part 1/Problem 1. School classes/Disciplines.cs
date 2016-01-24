namespace Problem_1.School_classes
{
    using System;
    
    public class Disciplines : IComment
    {
        private string name;
        private byte numberOfLectures;
        private byte numberOfExercises;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Discipline name can't be empty string!");
                }
                this.name = value;
            }
        }

        public byte NumberOfLectures
        {
            get { return this.numberOfLectures; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentNullException("Discipline ammount of lectures can't be zero or negative!");
                }
                this.numberOfLectures = value;
            }
        }

        public byte NumberOfExercises
        {
            get { return this.numberOfExercises; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentNullException("Discipline ammount of lectures can't be zero or negative!");
                }
                this.numberOfExercises = value;
            }
        }

        public Disciplines(string name, byte lectures, byte exercises)
        {
            this.Name = name;
            this.NumberOfLectures = lectures;
            this.NumberOfExercises = exercises;
        }

        public string Comment { get; private set; }

        public void MakeComment(string text)
        {
            this.Comment = text;
        }
    }
}
