internal class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();

        Console.Clear();
        Console.WriteLine("-----Indovina PIN di 4 cifre-----");

        string PINSegreto = GeneraPIN();
        if (args.Length != 0 && args[0] == "-d") Console.WriteLine(PINSegreto);

        do
        {
            Console.WriteLine("Inserisci PIN");
        } while (!ProvaPIN(Console.ReadLine()!));
        
        Console.WriteLine("Bravo");

        bool ProvaPIN(string PIN)
        {
            if (PIN == PINSegreto)
                return true;
            else
                return false;
        }

        string GeneraPIN()
        {
            return rng.Next(1, 1000).ToString("D4");
        }
    }
}