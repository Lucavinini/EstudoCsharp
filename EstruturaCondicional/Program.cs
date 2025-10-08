namespace Condicional;

class Program
{
    static void Main()
    {
        Console.WriteLine("=====Verificador de idade ======");
        Console.WriteLine("Digite a sua idade:");

        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 18)
        {
            Console.WriteLine("Menor de idade, não vai entrar!");
        }
        else
        {
            Console.WriteLine("Pode entrar!");
        }


    }
}
    
