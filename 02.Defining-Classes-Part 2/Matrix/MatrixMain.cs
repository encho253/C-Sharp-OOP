namespace Matrix
{
    public class MatrixMain
    {
        public static void Main()
        {
            var matrix = new Matrix<int>(2, 3);
            var matrixOne = new Matrix<int>(2, 3);
            var resultMatrix = new Matrix<int>(3, 3);

            matrix.Add(0, 0, 0);
            matrix.Add(1, 0, 1);
            matrix.Add(2, 0, 2);
            matrix.Add(9, 1, 0);
            matrix.Add(8, 1, 1);
            matrix.Add(7, 1, 2);

            matrixOne.Add(6, 0, 0);
            matrixOne.Add(5, 0, 1);
            matrixOne.Add(4, 0, 2);
            matrixOne.Add(3, 1, 0);
            matrixOne.Add(4, 1, 1);
            matrixOne.Add(5, 1, 2);

            resultMatrix = matrixOne + matrix;

            System.Console.WriteLine(resultMatrix.ToString());

            resultMatrix = matrixOne - matrix;

            System.Console.WriteLine(resultMatrix.ToString());
        }
    }
}