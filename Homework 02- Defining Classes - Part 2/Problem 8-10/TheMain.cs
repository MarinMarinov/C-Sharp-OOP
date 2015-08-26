namespace Problem_8_10
{
    using System;
    
    class TheMain
    {
        static void Main()
        {
            Matrix<int> matrix = new Matrix<int>(3, 3);
            Matrix<int> anotherMatrix = new Matrix<int>(3, 3);
            Matrix<int> multiplicationTestMatrix = new Matrix<int>(3, 2);
            Matrix<int> fakeMatrix = new Matrix<int>(2, 5);

            //Console.WriteLine(matrix); // only zero values
            //Console.WriteLine(doubleMatrix); // only zero values

            // matrix[10, 5] = 1; // throws Exception

            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            Console.WriteLine(matrix);

            anotherMatrix[0, 0] = 11;
            anotherMatrix[0, 1] = 12;
            anotherMatrix[0, 2] = 13;
            anotherMatrix[1, 0] = 14;
            anotherMatrix[1, 1] = 15;
            anotherMatrix[1, 2] = 16;
            anotherMatrix[2, 0] = 17;
            anotherMatrix[2, 1] = 18;
            anotherMatrix[2, 2] = 19;

            multiplicationTestMatrix[0, 0] = 100;
            multiplicationTestMatrix[0, 1] = 200;
            multiplicationTestMatrix[1, 0] = 300;
            multiplicationTestMatrix[1, 1] = 400;
            multiplicationTestMatrix[2, 0] = 500;
            multiplicationTestMatrix[2, 1] = 600;

            Console.WriteLine(multiplicationTestMatrix);
            

            Console.WriteLine(matrix + anotherMatrix);
            //Console.WriteLine(matrix + fakeMatrix); // throws Exception

            Console.WriteLine(matrix - anotherMatrix);
            //Console.WriteLine(matrix - fakeMatrix); // throws Exception

            Console.WriteLine(matrix * anotherMatrix);
            //Console.WriteLine(matrix * fakeMatrix); // throws Exception
            Console.WriteLine(matrix * multiplicationTestMatrix);


            Matrix<double> doubleMatrix = new Matrix<double>(4, 4);
            
            if(doubleMatrix) // matrix contains only zero values
            {
                // Unreachable part of the code
            }

            doubleMatrix[0, 0] = 1;

            if (doubleMatrix)
            {
                Console.WriteLine("Matrix has at least one non-zero element");
            }
        }
    }
}