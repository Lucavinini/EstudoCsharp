using System;

public class Program
{
    static void Main()
    {
        //1.Declaração de um array inicializado

        //Array sempre terá um tipo.

        string[] produtos = { "Martelo", "Fita", "Machado" };

        //2. Acessando valores por meio de indice
        Console.WriteLine(produtos[0]);

        //Acessando por meio de loops
        foreach (string produto in produtos)
        {
            Console.WriteLine(produto);
        }

        //3. Declaração sem inicializar

        string[] amigos = new string[5];
        
        for (int cont = 0; cont < 5; cont++)
        {
            Console.WriteLine("Digite uma palavra:");
            amigos[cont] = Console.ReadLine();
        }

        for (int cont = 0; cont < 5; cont++)
        {
            Console.WriteLine(amigos[cont]);
        }

    }
}