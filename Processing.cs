using System;

namespace Megasena
{
    class Processing
    {
        private int[] valorSorteado;
        private int[] valorApostado;

        public Processing(int tamanhoAposta, int tamanhoSortear)
        {
            valorSorteado = new int[tamanhoSortear];
            valorApostado = new int[tamanhoAposta];
        }

        public void MegasenaProcessing()
        {
            SortearValores();
            ApostarValores();

            Console.Write("\nValores Sorteados: ");
            PrintLista(valorSorteado);

            Console.Write("\nValores Apostados: ");
            PrintLista(valorApostado);

            CompararResultado();
        }

        private void SortearValores()
        {
            Random random = new Random();

            for (int contador = 0; contador < valorSorteado.Length;)
            {
                int valorGerado = random.Next(1, 61);
                bool incrementar = true; 

                foreach(int numerosSorteado in valorSorteado)
                {
                    if(valorGerado == numerosSorteado)
                    {
                        incrementar = false;
                    }
                }

                if(incrementar == true)
                {
                    valorSorteado[contador] = valorGerado;
                    contador++;
                }
            }
        }

        private void ApostarValores()
        {
            List<int> numerosApostados = new List<int>();

            for (int contador = 0; contador < valorApostado.Length; contador++)
            {
                bool valorValido = false;

                while (!valorValido)
                {
                    Console.Write($"Digite o {contador + 1}º valor: ");
                    int valorConsole = Convert.ToInt32(Console.ReadLine());

                    if (valorConsole >= 1 && valorConsole <= 60)
                    {
                        bool incrementar = true;

                        foreach(int valor in numerosApostados)
                        {
                            if(valor == valorConsole)
                            {
                                incrementar = false;
                                Console.WriteLine("Número já apostado.");
                            }
                        }

                        if(incrementar == true)
                        {
                            valorApostado[contador] = valorConsole;
                            numerosApostados.Add(valorConsole);
                            valorValido = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                }
            }
        }

        private void CompararResultado()
        {
            int acertos = 0;

            foreach (int valorApostado in valorApostado)
            {
                foreach (int valorSorteado in valorSorteado)
                {
                    if (valorApostado == valorSorteado)
                    {
                        acertos++;
                    }
                }
            }
            
            if (acertos >= valorSorteado.Length)
            {
                Console.WriteLine("\nVocê acertou o jogo!");
            }
            else
            {
                Console.WriteLine($"\nVocê acertou {acertos} de {valorSorteado.Length}.");
            }
        }

        private void PrintLista(int[] vetor)
        {
            foreach (int valor in vetor)
            {
                Console.Write($"{valor} ");
            }
        }
    }
}
