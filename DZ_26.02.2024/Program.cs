/*class Task1
{
    static void Main()
    {
        double[] A = new double[5];
        Console.WriteLine("Введите 5 чисел для массива A:");
        for (int i = 0; i < 5; i++)
        {
            A[i] = Convert.ToDouble(Console.ReadLine());
        }

        Random random = new Random();
        double[,] B = new double[3, 4];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                B[i, j] = random.NextDouble() * 100; 
            }
        }

        Console.WriteLine("Массив A:");
        foreach (var num in A)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nМассив B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(B[i, j] + "\t");
            }
            Console.WriteLine();
        }

        double maxA = A.Max();
        double minA = A.Min();
        double maxB = B.Cast<double>().Max();
        double minB = B.Cast<double>().Min();

        double sumA = A.Sum();
        double sumB = B.Cast<double>().Sum();

        double prodA = A.Aggregate((x, y) => x * y);
        double prodB = B.Cast<double>().Aggregate((x, y) => x * y);

        double sumEvenA = A.Where(x => x % 2 == 0).Sum();

        double sumOddColsB = 0;
        for (int j = 0; j < 4; j++)
        {
            double colSum = 0;
            for (int i = 0; i < 3; i++)
            {
                colSum += B[i, j];
            }
            if (j % 2 != 0)
            {
                sumOddColsB += colSum;
            }
        }

        Console.WriteLine($"Максимальный элемент в массиве A: {maxA}");
        Console.WriteLine($"Минимальный элемент в массиве A: {minA}");
        Console.WriteLine($"Максимальный элемент в массиве B: {maxB}");
        Console.WriteLine($"Минимальный элемент в массиве B: {minB}");
        Console.WriteLine($"Общая сумма всех элементов в массиве A: {sumA}");
        Console.WriteLine($"Общая сумма всех элементов в массиве B: {sumB}");
        Console.WriteLine($"Общее произведение всех элементов в массиве A: {prodA}");
        Console.WriteLine($"Общее произведение всех элементов в массиве B: {prodB}");
        Console.WriteLine($"Сумма четных элементов в массиве A: {sumEvenA}");
        Console.WriteLine($"Сумма нечетных столбцов в массиве B: {sumOddColsB}");
    }
}*/
//====================================================================================================================//
/*class Task2
{
    static void Main()
    {
        int[,] array = new int[5, 5];
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = random.Next(1, 101);
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int min = array[0, 0];
        int max = array[0, 0];
        int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    minRow = i;
                    minCol = j;
                }

                if (array[i, j] > max)
                {
                    max = array[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        int sum = 0;

        int startRow = Math.Min(minRow, maxRow);
        int endRow = Math.Max(minRow, maxRow);
        int startCol = Math.Min(minCol, maxCol);
        int endCol = Math.Max(minCol, maxCol);

        for (int i = startRow; i <= endRow; i++)
        {
            for (int j = startCol; j <= endCol; j++)
            {
                if ((i == minRow && j >= minCol && j <= maxCol) || (i == maxRow && j >= minCol && j <= maxCol) || (i > minRow && i < maxRow))
                {
                    sum += array[i, j];
                }
            }
        }

        Console.WriteLine($"Минимальный элемент: {min}");
        Console.WriteLine($"Максимальный элемент: {max}");
        Console.WriteLine($"Сумма элементов между минимальным и максимальным элементами: {sum}");
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}*/
//====================================================================================================================//
/*class Task3
{
    static void Main()
    {
        Console.WriteLine("Введите строку для шифрования:");
        string input = Console.ReadLine();

        Console.WriteLine("Введите сдвиг (целое число):");
        int shift = int.Parse(Console.ReadLine());

        string encryptedText = Encrypt(input, shift);
        Console.WriteLine($"Зашифрованная строка: {encryptedText}");

        string decryptedText = Decrypt(encryptedText, shift);
        Console.WriteLine($"Расшифрованная строка: {decryptedText}");
    }

    static string Encrypt(string input, int shift)
    {
        string result = "";

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char shiftedChar = (char)(c + shift);

                if ((char.IsLower(c) && shiftedChar > 'z') || (char.IsUpper(c) && shiftedChar > 'Z'))
                {
                    shiftedChar = (char)(c - (26 - shift));
                }

                result += shiftedChar;
            }
            else
            {
                result += c;
            }
        }

        return result;
    }

    static string Decrypt(string input, int shift)
    {
        return Encrypt(input, 26 - shift);
    }
}*/
//====================================================================================================================//
/*class MatrixOperations
{
    public static int[,] MultiplyMatrixByScalar(int[,] matrix, int scalar)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }

        return result;
    }

    public static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);
        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }
}

class Task4
{
    static void Main()
    {
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };

        int scalar = 2;

        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("Matrix 2:");
        PrintMatrix(matrix2);

        int[,] result1 = MatrixOperations.MultiplyMatrixByScalar(matrix1, scalar);
        Console.WriteLine("Matrix 1 multiplied by scalar:");
        PrintMatrix(result1);

        int[,] result2 = MatrixOperations.AddMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix 1 + Matrix 2:");
        PrintMatrix(result2);

        int[,] result3 = MatrixOperations.MultiplyMatrices(matrix1, matrix2);
        Console.WriteLine("Matrix 1 * Matrix 2:");
        PrintMatrix(result3);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}*/
//====================================================================================================================//
/*class Task5
{
    static void Main()
    {
        Console.WriteLine("Введите арифметическое выражение (например, 2+3-4):");
        string input = Console.ReadLine();

        input = input.Replace(" ", "");

        int result = CalculateExpression(input);

        Console.WriteLine("Результат: " + result);
    }

    static int CalculateExpression(string expression)
    {
        int result = 0;
        char operation = '+';
        int num = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            char c = expression[i];

            if (char.IsDigit(c))
            {
                num = num * 10 + (c - '0');
            }
            if (!char.IsDigit(c) || i == expression.Length - 1)
            {
                if (operation == '+')
                {
                    result += num;
                }
                else if (operation == '-')
                {
                    result -= num;
                }

                if (c == '+' || c == '-')
                {
                    operation = c;
                    num = 0;
                }
            }
        }

        return result;
    }
}*/
//====================================================================================================================//
/*class Task6
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();

        string resultText = ChangeFirstLetterCase(inputText);

        Console.WriteLine("Результат работы приложения:");
        Console.WriteLine(resultText);
    }

    static string ChangeFirstLetterCase(string text)
    {
        string[] sentences = text.Split(". ", StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Length > 0)
            {
                char firstChar = char.ToUpper(sentences[i][0]);
                sentences[i] = firstChar + sentences[i].Substring(1);
            }
        }

        string resultText = string.Join(". ", sentences) + ".";

        return resultText;
    }
}*/
//====================================================================================================================//
class Task7
{

}