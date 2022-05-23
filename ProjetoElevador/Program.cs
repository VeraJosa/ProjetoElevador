using System;
using ProjetoElevador.Model;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();
            elevador.andarAtual = 0; //Inicia no térreo
            elevador.capacidadeElevador = 3; //Número maxímo de pessoas
            elevador.totalAndares = 5; //Número maxímo de andares(excluindo o térreo)
            elevador.lotação = 0; //Inicia vazio
           
            elevador.Inicializar(elevador.capacidadeElevador, elevador.totalAndares); //Chama a função Inicializar() uma vez quando executa o programa.
           
            bool continuar = true;

            //O usuario escolhe o que fazer: subir ou descer entre os andares, entrar ou sair do elevador.
            //A opção Finalizar não atende se o elevador, não estiver no térreo e vazio.
            
            do
            {

                    Console.WriteLine(@"Escolha uma opção: 
                                      1 - Entrar
                                      2 - Subir
                                      3 - Sair
                                      4 - Descer
                                      5 - Finalizar(No térreo e vazio)
                          ");

                    string OpcaoEscolhida = Console.ReadLine();

                    //Para limpar o console.
                    Console.Clear();

                    switch (OpcaoEscolhida)
                    {

                        case "1":
                            int l1 = elevador.Entrar(elevador.lotação, elevador.capacidadeElevador);
                            elevador.lotação = l1;
                            break;
                        case "2":
                            int a1 = elevador.Subir(elevador.andarAtual, elevador.totalAndares);
                            elevador.andarAtual = a1;
                            break;
                        case "3":
                            int l2 = elevador.Sair(elevador.lotação);
                            elevador.lotação = l2;
                            break;
                        case "4":
                            int a2 = elevador.Descer(elevador.andarAtual);
                            elevador.andarAtual = a2;
                            break;
                        case "5":
                            continuar = elevador.Finalizar(elevador.lotação, elevador.andarAtual);
                            break;

                        default: Console.WriteLine("Escolha não válida."); break;

                    }

            } while (continuar);
        }      
    }
}
