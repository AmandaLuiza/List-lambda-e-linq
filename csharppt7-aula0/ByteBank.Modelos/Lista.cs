using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
   public class List<T>
    {
        
            private T[] _itens;
            private int _proximaPosicao;


            public int Count
            {
                get

                { return _proximaPosicao; }
            }
            public List(int capacidadeInicial = 5)
            {
                _itens = new T[capacidadeInicial];
                _proximaPosicao = 0;
            }

       
        public void MeuMetodo(string texto = "texto padrao", int numero = 5)
            {

            }

            public void Add(T item)
            {
                VerificarCapacidade(_proximaPosicao + 1);

                //Console.WriteLine($"Adicionando itens na posição {_proximaPosicao}");

                _itens[_proximaPosicao] = item;
                _proximaPosicao++;
            }


            public void AdicionarVarios(params T[] itens)
            {

                foreach (T item in itens)
                {
                    Add(item);
                }
            }

            public void Remover(T item)
            {
                int indiceItem = -1;

                for (int i = 0; i < _proximaPosicao; i++)
                {
                    T itemAtual = _itens[i];

                    if (itemAtual.Equals(item))
                    {
                        indiceItem = i;
                        break;
                    }
                }

                //Quero remover o 0x01

                //[0x03] [...4] [...5] [null]
                //^
                //`
                //                      _proximaPosicao


                for (int i = indiceItem; i < _proximaPosicao - 1; i++)
                {
                    _itens[i] = _itens[i + 1];

                    _proximaPosicao--;
                    //_itens[_proximaPosicao] = null;
                }
            }
            public T GetItemNoIndice(int indice)
            {
                if (indice < 0 || indice >= _proximaPosicao)
                {
                    throw new ArgumentOutOfRangeException(nameof(indice));
                }

                return _itens[indice];
            }


            private void VerificarCapacidade(int tamanhoNecessario)
            {
                if (_itens.Length >= tamanhoNecessario)
                {
                    return;
                }

                int novoTamanho = _itens.Length * 2;
                if (novoTamanho < tamanhoNecessario)
                {
                    novoTamanho = tamanhoNecessario;

                }

                //Console.WriteLine("Aumentando capacidade da lista!");

                T[] novoArray = new T[novoTamanho];

                for (int indice = 0; indice < _itens.Length; indice++)
                {
                    novoArray[indice] = _itens[indice];
                    //
                    //Console.WriteLine(".");
                }

                _itens = novoArray;
            }


            public T this[int indice]
            {
                get
                {
                    return GetItemNoIndice(indice);
                }
                set
                {

                }
            }
        }    }

