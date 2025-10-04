
namespace Variavel;

class Program
{
    static void Main()
    {

        //Tipo Inteiro:
        int idade = 23;
        int graus = -17;
        long MeuTelefone = 81989017433; //Tipo (long) para maior espaço na memória:


        //Tipo decimal 
        double Tamanho_Terreno = 23.876;
        decimal distacia = 3.143.245.6; //tipo (decimal) para maior precisão

        //Tipo constante:

        const int PI = 3.14; //Valor imutável


        //Tipo texto:
        char MinhaInicial = 'L' //char armazena apenas caracteres pequenos entre aspas simples
        string MeuNome = "Lucas Vinícius da Silva Lima" //Reunião de caracteres entre aspas duplas


        //Tipo lógico:
        bool Estado_Luz = true;
        bool Estado_LuzPatio = false;


        //Tipo var:
        var QualquerCoisa = "Bolo de morango"; //O tipo var transforma a variável no tipo recebido.


        //Tipo dynamic:
        dynamic Valor = 23;
        Valor = '24'; //Troca dinamicamente o seu tipo


    }
}