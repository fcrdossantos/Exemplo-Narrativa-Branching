using IniciacaoCientificaBranching.branchingEstrutura;
using IniciacaoCientificaBranching.branchingEstrutura.nos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciacaoCientificaBranching.branchingNarrativa
{
    public static class Narrativa
    {
         /// <summary>
         /// Recupera a árvore com a narrativa pronta
         /// </summary>
        public static Arvore GetNarrativa()
        {
            // Nomeclatura escolhida:
                // 0 = Nó único, obrigatorio
                // 1;2;3... = Vários nós, o numero representa a escolha feita
                    // Ex: 2 = Foi na escolha 2
                // 1r;2r;3r... = Vários nós com escolha randomica, o numero representa a escolha feita
                    // Ex: 2r = Randomicamente escolheu 2
                // 1-1-2r ; 0-1-1; 0-2-1 = Caminho percorrido
                    // Ex: 0-1-2r = Primeiro nó era único, depois escolheu o nó 1 e depois randomicamente o 2
                // b0;b12;b23 = nó do branch 
                    // b0 = Ultimo nó do percurso "0"
                    // b12 = Ultimo nó do percurso "1-2"
                // eb0;eb12 = Escolha do nó em questão
                    // eb12 = Escolha do ultimo nó do percurso "1-2"

            Arvore narrativa = new Arvore();
            // Raíz
            No raiz = narrativa.noRaiz = new No(new Escolha("Inicio do Jogo")); // Método inline de instanciar um nó e escolha

            Escolha eb0 = new Escolha("Bifurcação, o que fazer?"); // Método padrão de instanciar uma escolha
            No b0 = new No(eb0); // Método padrão de instanciar um nó
            raiz.Ligacoes.Add(b0); // Adicionar o nó b0 na ligação do nó raiz

            #region branchs

            #region branchs 0-1-x
            // Branch 0-1-1-1r
            No b01 = new No("Esquerda"); // Método facil de instanciar um nó com escolha
            b0.Ligacoes.Add(b01);
            No b011 = new No("Continuar em frente");
            b01.Ligacoes.Add(b011);
            No b0111r = new No("Adicionar caminho ao gps", true);
            b011.Ligacoes.Add(b0111r);
            // Branch 0-1-1-2r
            No b0112r = new No("Tentar outro caminho na próxima vez", true);
            b011.Ligacoes.Add(b0112r);
            // Branch 0-1-2-1r
            No b012 = new No("Voltar e ir pelo da direita");
            b01.Ligacoes.Add(b012);
            No b0121r = new No("Adicionar caminho ao gps", true);
            b012.Ligacoes.Add(b0121r);
            // Branch 0-1-2-2r
            No b0122r = new No("Tentar outro caminho na próxima vez", true);
            b012.Ligacoes.Add(b0122r);
            #endregion

            #region branchs 0-2-x
            // Branch 0-2-1-1r
            No b02 = new No("Direita");
            b0.Ligacoes.Add(b02);
            No b021 = new No("Continuar em frente");
            b02.Ligacoes.Add(b021);
            No b0211r = new No("Adicionar caminho ao gps", true);
            b021.Ligacoes.Add(b0211r);
            // Branch 0-2-1-2r
            No b0212r = new No("Tentar outro caminho na próxima vez", true);
            b021.Ligacoes.Add(b0212r);
            // Branch 0-2-2-1r
            No b022 = new No("Voltar e ir pelo da esquerda");
            b02.Ligacoes.Add(b022);
            No b0221r = new No("Adicionar caminho ao gps", true);
            b022.Ligacoes.Add(b0221r);
            // Branch 0-2-2-2r
            No b0222r = new No("Tentar outro caminho na próxima vez", true);
            b022.Ligacoes.Add(b0222r);
            #endregion

            #endregion

            narrativa.noAtual = narrativa.noRaiz;
            return narrativa;

            

        }


    }
}
