namespace BlogConsole.UI
{
    public class ConsoleHelper
    {
        public static void pause()
        {
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();
        }

        public static void printHeader(string title)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=== " + title + " ===\n");
            Console.ResetColor();

        }
        public static void errorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erreur: " + message);
            Console.ResetColor();
        }
    }
}
