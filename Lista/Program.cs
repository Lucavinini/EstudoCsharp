using System;

class Program
{
    static void Main()
    {
        //1. Uma lista vai sempre ter um tipo e um construtor depois do =
        List<int> code_user = new List<int>();

        //Pode-se iniciar com valores.
        List<int> code_produto = new List<int> { 2345, 2221, 11114 };

        //2. Métodos

        //.Add()
        code_user.Add(850855);

        //.Count, para saber o tamanho da lista
        Console.WriteLine($"O tamanho é: {code_produto.Count}");

        //.Remove() podendo ser por indice ou valor.

        code_produto.Remove(11114); //Pelo valor
        code_produto.RemoveAt(0);

        //.Clear(), apaga todos os elementos da lista
        code_produto.Clear();
    }
}