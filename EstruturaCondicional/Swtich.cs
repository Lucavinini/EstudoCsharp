
Console.WriteLine("======Calculadora=======");
Console.WriteLine("1. Somar");
Console.WriteLine("2. Subtrair");

int User_Escolha = Convert.ToInt32(Console.ReadLine());

switch (User_Escolha)
{
    case 1:
        Console.WriteLine("Digite o primeiro Número:");
        decimal Number1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Digite o 2 número:");
        decimal Number2 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine(Number1 + Number2);
        break;

    case 2:
        Console.WriteLine("Digite o primeiro Número:");
        decimal N1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Digite o segundo Número:");
        decimal N2 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine(N1 - N2);
        break;


}