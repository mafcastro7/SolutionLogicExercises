namespace Shared
{
    public class ConsoleExtension
    {
        public static int GetInt(string message)
        {
            int numberInt;
            string? numberString;

            while (true)
            {
                Console.Write(message);
                numberString = Console.ReadLine();

                if (int.TryParse(numberString, out numberInt))
                {
                    return numberInt;
                }
                Console.Write("Entrada no válida, digite un número.");
            }
        }
  
        public static bool AskToContinue()
        {
            string? answer;
            while (true)
            {
                Console.Write("¿Desea ejecutar de nuevo? [s/n]: ");
                answer = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(answer))
                {
                    answer = answer.Trim().ToUpper();
                    if (answer == "S") return true;
                    if (answer == "N") return false;
                }
                Console.WriteLine($"Entrada no válida.");
            }
        }
    }
}
