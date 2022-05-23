using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{

     /*Crie uma classe denominada Elevador para armazenar as informações de um elevador
      dentro de um prédio, a classe deve armazenar o andar atual (térreo = 0), total de andares
      no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
      presentes nele. */
    internal class Elevador
    {

        public int andarAtual; //Armazena em qual andar o elevador está.
        public int totalAndares; //Número maxímo de andares(excluindo o térreo)
        public int capacidadeElevador; //Número maxímo de pessoas
        public int lotação; //Quantas pessoas estão no elevador

        //A classe deve também disponibilizar os seguintes métodos:
        public void Inicializar(int capacidadeElevador, int totalAndares)
        {
            //Deve receber como parâmetros a capacidade do elevador e o total de
            //andares no prédio(os elevadores sempre começam no térreo e vazio);

            Console.WriteLine("INICIALIZANDO ELEVADOR");
            Console.WriteLine("ABRINDO PORTAS");
            Console.WriteLine("ENTRAR UM PASSAGEIRO DE CADA VEZ");
            Console.WriteLine("SUBIR UM ANDAR DE CADA VEZ");
            Console.WriteLine("Número maxímo de passageiros: " + capacidadeElevador);
            Console.WriteLine("Total de andares: " + totalAndares);
        
        }

        public int Entrar(int lotação, int capacidadeElevador)
        {
            //Deve acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço).
            if (lotação < capacidadeElevador)
            {

                lotação += 1;
                Console.WriteLine("UMA PESSOA ENTROU NO ELEVADOR.");
                Console.WriteLine("PESSOAS NO ELEVADOR: " + lotação);
                return lotação;
            }else
            {
                Console.WriteLine("PESSOAS NO ELEVADOR: " + lotação);
                Console.WriteLine("ELEVADOR LOTADO.");
                return lotação;
            }
            
        }

        public int Sair(int lotação)
        {
            //Deve remover uma pessoa do elevador (só deve remover se houver alguém dentro dele).
            if (lotação > 0)
            {

                lotação -= 1;
                Console.WriteLine("UMA PESSOA SAIU DO ELEVADOR.");
                Console.WriteLine("PESSOAS NO ELEVADOR: " + lotação);
                return lotação;
            }
            else
            {
                Console.WriteLine("ELEVADOR VAZIO.");
                return lotação;
            }

        }

        public int Subir(int andarAtual, int totalAndares)
        {
            //Deve subir um andar (não deve subir se já estiver no último andar).
            if (andarAtual < totalAndares)
            {

                andarAtual += 1;
                Console.WriteLine("O ELEVADOR SUBIU UM ANDAR.");
                Console.WriteLine("ANDAR ATUAL: " + andarAtual);
                return andarAtual;
            }
            else
            {
                Console.WriteLine("ÚLTIMO ANDAR.");
                return andarAtual;
            }


        }

        public int Descer(int andarAtual)
        {
            //Deve descer um andar (não deve descer se já estiver no térreo).
            if (andarAtual > 0)
            {

                andarAtual -= 1;
                Console.WriteLine("O ELEVADOR DESCEU UM ANDAR.");
                Console.WriteLine("ANDAR ATUAL: " + andarAtual);
                return andarAtual;
            }
            else
            {
                Console.WriteLine("TÉRREO.");
                return andarAtual;
            }

        }

        public bool Finalizar(int lotação, int andarAtual) {

            //Desliga o elevador(sai do programa),
            //Só desliga se estiver no térreo e vazio
            if (lotação == 0 && andarAtual == 0)
            {
                bool continuar = false;
                Console.WriteLine("DESLIGANDO ELEVADOR...");
                return continuar;
            } else
            {
                bool continuar = true;
                Console.WriteLine("AÇÃO NÃO AUTORIZADA");
                return continuar;
            }
            
             
        
        }

       
    }
}
