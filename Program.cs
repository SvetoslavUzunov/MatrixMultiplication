namespace MatrixMultiplication;

public class Program
{
    public static void Main()
    {
        int[,] matrixA = {
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 }
        };

        int[,] matrixB = {
            {9, 8, 7 },
            {6, 5, 4 },
            {3, 2, 1 }
        };

        if (matrixA.GetLength(0) != matrixB.GetLength(1))
        {
            Console.WriteLine("Error!");
        }
        else MultiplicationsMatrix(matrixA, matrixB);
    }

    private static void MultiplicationsMatrix(int[,] matrixA, int[,] matrixB)
    {
        int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        for (int row = 0; row < matrixA.GetLength(0); row++)
        {
            for (int col = 0; col < matrixB.GetLength(1); col++)
            {
                matrixC[row, col] = 0;
                for (int k = 0; k < matrixC.GetLength(0); k++)
                {
                    matrixC[row, col] += matrixA[row, k] * matrixB[k, col];
                }
            }
        }
        PrintMatrix(matrixC);
    }

    private static void PrintMatrix(int[,] matrixC)
    {
        for (int row = 0; row < matrixC.GetLength(0); row++)
        {
            for (int col = 0; col < matrixC.GetLength(1); col++)
            {
                Console.Write(matrixC[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}