namespace Megasena;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho da aposta: ");
        int tamanhoAposta = Convert.ToInt32(Console.ReadLine());

        Processing megaSena = new Processing(tamanhoAposta, 6);

        megaSena.MegasenaProcessing();
    }
}