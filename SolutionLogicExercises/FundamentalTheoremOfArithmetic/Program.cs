using Shared;

do
{
    int numero = ConsoleExtension.GetInt("Ingrese el número a descomponer: ");
    int original = numero;

    if (numero <= 1)
    {
        Console.WriteLine("El número debe ser mayor que 1.");
    }
    else if (IsPrime(numero))
    {
        Console.WriteLine($"{numero} = {numero} x 1");
    }
    else
    {
        List<int> factores = new List<int>();
        int divisor = 2;

        while (numero > 1)
        {
            if (numero % divisor == 0)
            {
                factores.Add(divisor);
                numero /= divisor;
            }
            else
            {
                divisor++;
            }
        }
    
        Console.Write($"{original} = ");
        for (int i = 0; i < factores.Count; i++)
        {
            Console.Write(factores[i]);
            if (i < factores.Count - 1)
            {
                Console.Write(" x ");
            }
        }
        Console.WriteLine();
    }
} while (ConsoleExtension.AskToContinue());
static bool IsPrime(int numero)
{
    if (numero <= 1) return false;
    for (int i = 2; i * i <= numero; i++)
    {
        if (numero % i == 0) return false;
    }
    return true;
}
