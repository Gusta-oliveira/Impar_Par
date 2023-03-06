internal class Program
{
    private static void Main(string[] args)
    {
        int digito;

        Console.WriteLine("Informe o número: ");
        digito = int.Parse(Console.ReadLine());
        
        if(digito % 2 == 0)
        {
            Console.WriteLine("O número é par!");

        }
        else
        {
            Console.WriteLine("O número é impar!");
        }
    }
}