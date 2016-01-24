namespace Problem_3.Range_Excepitons
{
    using System;
    
    public class InvalidRangeException<T>: ApplicationException
    {
        public T Start { get; private set; }
        public T End { get; private set; }

        public InvalidRangeException(T start, T end)
        {
            this.Start = start;
            this.End = end;
        }

        public override string Message
        {
            get
            {
                return string.Format("Invalid input parameter. Parameters must be in the range: [{0}, {1}]", this.Start, this.End);
            }
        }
    }
}
