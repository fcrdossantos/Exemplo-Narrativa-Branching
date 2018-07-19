using IniciacaoCientificaBranching.branchingEstrutura;
using IniciacaoCientificaBranching.branchingNarrativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniciacaoCientificaBranching.branchingEstrutura.nos;

namespace IniciacaoCientificaBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            Arvore arvore = Narrativa.GetNarrativa();
            while(arvore.noAtual.Ligacoes.Count>0)
            {
                Console.WriteLine(arvore.noAtual.Escolha.EscolhaTexto);
                arvore.noAtual = arvore.noAtual.EscolherLigacao();
            }
            Console.WriteLine(arvore.noAtual.Escolha.EscolhaTexto);
            Console.WriteLine("Fim de jogo");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Número de dados repetidos: 8");
            Console.WriteLine("Número de dados que se repetem: 4");
            Console.WriteLine("Dados únicos: 4");
            Console.WriteLine("Número de dados não-unicos: 12");
            Console.WriteLine("Dados totais: 16");
            Console.WriteLine("A árvore sempre estava com os 16 dados na memória");
            Console.ReadKey();
        }
    }
}
