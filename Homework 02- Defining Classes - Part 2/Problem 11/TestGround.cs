namespace Problem_11
{
    using System;

    [Version ("v. 2.12")]
    public class TestGround
    {
        static void Main(string[] args)
        {
            Type classType = typeof(TestGround);
            
            object[] attributes = classType.GetCustomAttributes(true);

            foreach(VersionAttribute item in attributes)
            {
                Console.WriteLine(item.Version);
            }
        }
    }
}