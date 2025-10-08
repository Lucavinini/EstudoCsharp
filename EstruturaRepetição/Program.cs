namespace Laço;

public class Program
{
    public static void Main()
    {
        //While
        int passos = 30;

        while (passos <= 30)
        {
            Console.WriteLine(passos);
            passos++;
        }

        //for, utiliza-se os ; para separar os campos.
        int i = 30;

        for (; i > 0;)
        {
            Console.WriteLine(i);
            i--;
        }

    }
}