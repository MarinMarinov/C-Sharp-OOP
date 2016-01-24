namespace Problem_5._64_Bit_array
{
    using System;
    
    class TheMain
    {
        static void Main()
        {
            var testNumber = new BitArray64(126);


            Console.WriteLine(string.Join("", testNumber.BitArray));// number as array of bits


            Console.WriteLine(testNumber[30]);// check indexer
            Console.WriteLine(testNumber[62]);


            foreach (var bit in testNumber)// check enumerator
            {
                Console.Write(bit);
            }
            Console.WriteLine();


            var testNumber2 = new BitArray64(255);//check equals and ==
            var testNumber3 = new BitArray64(123);

            Console.WriteLine(testNumber.Equals(testNumber2));
            Console.WriteLine(testNumber.Equals("1010101010"));
            Console.WriteLine(testNumber.Equals(testNumber3));
            Console.WriteLine(testNumber == testNumber2);
            Console.WriteLine(testNumber != testNumber3);
        }
    }
}
