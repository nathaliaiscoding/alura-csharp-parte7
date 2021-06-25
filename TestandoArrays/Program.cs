using System;

namespace TestandoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sintaxe do array de qualquer tipo:
            // TIPO[] minhaReferenciaDeArray = new TIPO[numero_de_posicoes];

            // Fazendo as substituições para um array com 5 posições de números inteiros teremos:
            // int[] idades = new int[5];

            // Em um array, os índices se baseiam em zero.Para atribuir valores nas posições de um array, basta usar a sintaxe meuArray[posicao] = valor;:
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            // É necessário um array com no mínimo 6 posições para usar idades[5] = 63;
            //  Uma exceção do tipo IndexOutOfRangeException será lançada

            Console.WriteLine(idades[1]);
            Console.WriteLine(idades[2]);

            // ao criar um array, todas as suas posições são inicializadas com o valor padrão do tipo do array. Em nosso caso, o valor padrão do int é o 0.


            // a expressão esperada dentro dos [] é qualquer tipo de expressão que retorne um int
            int indice = 2;
            int valorNoIndice = idades[indice];
            int outroValor = idades[2 + 2];

            // Sabendo que basta usar uma expressão de int para acessar uma posição do nosso array, podemos usar isto com uma variável de iteração em um laço for:
            for (int index = 0; index < idades.Length; index++)
            {
                int idade = idades[index];
                Console.WriteLine($"Valor no índice {index}: {idade}");
            }

            // Agora que conhecemos a propriedade Length, fica mais fácil obtermos a média das idades de nosso array:
            int acumulador = 0;
            for (int index2 = 0; index2 < idades.Length; index2++)
            {
                acumulador += idades[index2];
            }
            int media = acumulador / idades.Length;
            Console.WriteLine($"Valor médio das idades é {media}");

            // Também podemos usar o inicializador de arrays:
            int[] inicializadorDeIdades = new int[] { 15, 28, 35, 50, 28 };
            Console.WriteLine(inicializadorDeIdades[2]);
            Console.ReadLine();
        }
    }
}
