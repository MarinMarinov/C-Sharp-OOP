namespace Problem_1.School_classes
{
    using System;
    
    public abstract class Person // класът е абстрактен, защото не желая да се инстанцира(безмислено е)
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name can't be empty!");
                }
                this.name = value;
            }
        }

        public Person(string name)
        {
            this.Name = name;
        }

    }
}
