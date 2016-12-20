namespace Matrix
{
    using System;
    using System.Text;

    public class Matrix<T>
    {
        private int row;
        private int col;

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.MatrixArray = new T[row, col];
        }

        public T[,] MatrixArray { get; private set; }

        public int Row
        {
            get
            {
                return this.row;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Row cannot be smaller than 0");
                }

                this.row = value;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Col cannot be smaller than 0");
                }

                this.col = value;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                return this.MatrixArray[row, col];
            }

            set
            {
                if (row < 0 || row > this.row || col < 0 || col > this.col)
                {
                    throw new IndexOutOfRangeException();
                }

                this.MatrixArray[row, col] = value;
            }
        }

        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.Col != matrixTwo.Row)
            {
                throw new ArgumentException("Col != Row");
            }

            Matrix<T> resultMatrix = new Matrix<T>(matrixOne.Row, matrixTwo.Col);
            dynamic result = 0;
            int counter = 0;

            for (int i = 0; i < matrixOne.Row; i++)
            {
                for (int j = 0; j <= matrixTwo.Col; j++)
                {
                    result += (dynamic)matrixOne[i, j] * matrixTwo[j, counter];

                    if (j == matrixTwo.Col)
                    {
                        resultMatrix[i, counter] = result;
                        counter++;
                        i--;

                        if (counter == matrixTwo.Col)
                        {
                            counter = 0;
                            i++;
                        }
                    }
                }

                result = 0;
            }

            return resultMatrix;
        }

        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.Col != matrixTwo.Col || matrixOne.Row != matrixTwo.Row)
            {
                throw new ArgumentException("Matrices must be with same size");
            }

            var resultMatrix = new Matrix<T>(matrixOne.Row, matrixOne.Col);
            dynamic sum = 0;

            for (int i = 0; i < matrixOne.Row; i++)
            {
                for (int j = 0; j < matrixOne.Col; j++)
                {
                    sum += (dynamic)matrixOne[i, j] + matrixTwo[i, j];

                    resultMatrix[i, j] = sum;
                    sum = 0;
                }
            }

            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.Col != matrixTwo.Col || matrixOne.Row != matrixTwo.Row)
            {
                throw new ArgumentException("Matrices must be with same size");
            }

            var resultMatrix = new Matrix<T>(matrixOne.Row, matrixOne.Col);
            dynamic sum = 0;

            for (int i = 0; i < matrixOne.Row; i++)
            {
                for (int j = 0; j < matrixOne.Col; j++)
                {
                    sum += (dynamic)matrixOne[i, j] - matrixTwo[i, j];

                    resultMatrix[i, j] = sum;
                    sum = 0;
                }
            }

            return resultMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            var boolMatrix = new Matrix<bool>(matrix.Row, matrix.Col);
            bool zero = false;

            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] != 0)
                    {
                        boolMatrix[i, j] = true;
                    }
                    else
                    {
                        boolMatrix[i, j] = false;
                    }
                }
            }

            return zero;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            var boolMatrix = new Matrix<bool>(matrix.Row, matrix.Col);
            bool zero = false;

            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] != 0)
                    {
                        boolMatrix[i, j] = false;
                    }
                    else
                    {
                        boolMatrix[i, j] = true;
                    }
                }
            }

            return zero;
        }

        public void Add(T element, int row, int col)
        {
            this.MatrixArray[row, col] = element;
        }
               
        public override string ToString()
        {
            var builder = new StringBuilder();

            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    builder.Append(this.MatrixArray[i, j]).Append(" ");
                }

                builder.AppendLine();
            }

            return builder.ToString();
        }
    }
}
