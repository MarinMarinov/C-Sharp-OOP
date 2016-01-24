namespace Problem_4.Person
{
    using System;
    
    class TheMain
    {
        static void Main()
        {
            Person ivan = new Person("Ivan", 20);
            Console.WriteLine(ivan);
            Person petkan = new Person("Petkan");
            Console.WriteLine(petkan);
        }
    }
}
