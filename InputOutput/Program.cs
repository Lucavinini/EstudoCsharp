namespace EntradaESaida;

class Program
{
    static void Main()
    {
        Console.WriteLine("---CADASTRO----");
        Console.WriteLine("Digite o seu nome:");

        string Nome_Usuario = Console.ReadLine(); //Principal comando para receber dados
        Console.WriteLine("Digite a sua idade:");

        int Idade_Usuario = Convert.ToInt32(Console.ReadLine()); //Uso do Convert.ToTipoDeDado() para converter tipo string para outro tipo.

        Console.WriteLine($"Bem vindo {Nome_Usuario}, sua idade é: {Idade_Usuario}");

    }
}