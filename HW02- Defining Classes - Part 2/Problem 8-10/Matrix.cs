namespace Problem_8_10
{
    using System;
    using System.Text;

    public class Matrix<T>
    {
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public int Rows { get { return this.matrix.GetLength(0); } }
        public int Cols { get { return this.matrix.GetLength(1); } }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= this.Rows)
                {
                    throw new IndexOutOfRangeException("Row is out of range!");
                }

                if (col < 0 || col >= this.Cols)
                {
                    throw new ArgumentOutOfRangeException("Col is out of range!");
                }

                return this.matrix[row, col];
            }
            set
            {
                if (row < 0 || row >= this.Rows)
                {
                    throw new IndexOutOfRangeException("Row is out of range!");
                }

                if (col < 0 || col >= this.Cols)
                {
                    throw new ArgumentOutOfRangeException("Col is out of range!");
                }

                this.matrix[row, col] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    sb.Append(this.matrix[i, j] + " ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
            {
                throw new ArgumentNullException("Matrix {0} is null", firstMatrix == null ? "1" : "2");
            }

            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("Matrices have different dimensions");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
            {
                throw new ArgumentNullException("Matrix {0} is null", firstMatrix == null ? "1" : "2");
            }

            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("Matrices have different dimensions");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
            {
                throw new ArgumentNullException("Matrix {0} is null", (firstMatrix == null) ? "1" : "2");
            }

            if (firstMatrix.Cols != secondMatrix.Rows)
            {
                throw new ArgumentException("First matrix columns number must to be equal to second matrix raws number");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Cols, secondMatrix.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    dynamic temp = 0;

                    for (int k = 0; k < firstMatrix.Cols; k++)
                    {
                        temp += (dynamic)firstMatrix[i, k] * (dynamic)secondMatrix[k, j];
                    }

                    result[i, j] = temp;
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> currentMatrix)
        {
            for (int i = 0; i < currentMatrix.Rows; i++)
            {
                for (int j = 0; j < currentMatrix.Cols; j++)
                {
                    if (currentMatrix[i, j] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> currentMatrix)
        {
            for (int i = 0; i < currentMatrix.Rows; i++)
            {
                for (int j = 0; j < currentMatrix.Cols; j++)
                {
                    if (currentMatrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
