using Shared;

do
{
    int n = ConsoleExtension.GetInt("Ingrese orden de la matriz: ");
    int[,] matrix = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = (i + 1) - j;
        }
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine();
    }

    int suma = 0;
    int max = matrix[0, 0];
    int min = matrix[0, 0];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            suma += matrix[i, j];
            if (matrix[i, j] > max) max = matrix[i, j];
            if (matrix[i, j] < min) min = matrix[i, j];
        }
    }

    Console.WriteLine($"La sumatoria es: {suma}");
    Console.WriteLine($"El valor máximo es: {max}");
    Console.WriteLine($"El valor mínimo es: {min}");
} while (ConsoleExtension.AskToContinue());
