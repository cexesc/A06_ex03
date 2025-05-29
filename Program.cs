internal class Metodes
{
    public static List<int> comptadorMultiples(int v)
    {
        List<int> multiples = new List<int>();
        for (int i = 0; i < v; i++)
        {
            if (i % 7 == 0)
            {
                multiples.Add(i);
            }
        }
        return multiples;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Introdueix un valor: ");
        int valor = Convert.ToInt32(Console.ReadLine());
        var multiples = Metodes.comptadorMultiples(valor);
        Console.WriteLine("Múltiples de 7 menors que " + valor + ":");
        Console.WriteLine(string.Join(", ", multiples));
    }
}

