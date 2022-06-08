using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{

    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            var resultado = SomarVarios(1, 5, 9);



            var conta  = new ContaCorrente(344, 56456456);
            var gerenciador = new GerenciadorBonificacao();
            var gerenciadores = new List<GerenciadorBonificacao>();

            
















            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

           

            idades.AdicionarVarios(45, 89, 12);
            
            //ListExtensoes.AdicionarVarios(idades, 45, 89, 12)

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
                
            }

            Console.ReadLine();
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.Adicionar("um texto qualquer");
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");

            }

        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach(int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaListaDeContaCorrente()
        {
            //ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ContaCorrente contaDoGui = new ContaCorrente(11111, 111111);


            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754),
                new ContaCorrente(874, 5679754),
                new ContaCorrente(874, 5679754),
                new ContaCorrente(874, 5679754), 
                new ContaCorrente(874, 5679754)
                );

            for (int i = 0; i < lista.Tamanho; i++)
            {



                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
              {
                     new ContaCorrente(874, 5679787),
                     new ContaCorrente(874, 4456668),
                     new ContaCorrente(874, 7781438)
      };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contas[indice].Numero}");
            }

        }
        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 5 posições!
            int[] idades = null;
            idades = new int[3];


            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice <
                idades.Length; indice++)
            {
                int idade = idades[indice];


                Console.WriteLine($"Acessando o array idades no indice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }
    }
}
