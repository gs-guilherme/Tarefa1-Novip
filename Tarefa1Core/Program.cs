using System;
using System.Collections.Generic;

namespace Tarefa1Core
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequenciaCorreta = "ABAABBABAB";
            List<string> sequencias = new List<string>();
            int indexPosicaoCorreta = 0;

            CalculaSequencia(sequencias);

            for (int i = 0; i < sequencias.Count; i++)
            {
                Console.WriteLine($@"Posição {i}: {sequencias[i]}");
                if (sequencias[i] == sequenciaCorreta)
                    indexPosicaoCorreta = i;
            }

            Console.WriteLine($@"O cadeado será aberto na posição {indexPosicaoCorreta}: {sequencias[indexPosicaoCorreta]}");
            Console.ReadKey();
        }

        private static void CalculaSequencia(List<string> listaSequencias, string sequencia = null)
        {
            string[] letras = { "A", "B" };

            string sequenciaProcessada = sequencia;

            for (int i = 0; i < letras.Length; i++)
            {
                sequenciaProcessada += letras[i];

                if (sequenciaProcessada.Length >= 10)
                {
                    listaSequencias.Add(sequenciaProcessada);
                    sequenciaProcessada = sequencia;
                }
                else
                {
                    CalculaSequencia(listaSequencias, sequenciaProcessada);
                    sequenciaProcessada = sequencia;
                }
            }
        }
    }
}

