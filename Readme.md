VISAO GERAL DO PROJETO

O projeto é um software que tem como função o gerenciamento de um elevador, ele tem as funções de inicializar,
entrar, sair, subir, descer e finalizar.  
Foi utilizado o Visual Studio Community para criar o projeto Aplicativo de Console com o nome ProjetoElevador,
e a estrutura .NET 5.
Todas as classes estão na pasta chamada Model, a estrutura com as pastas de Controller e View são opcionais.
A classe denominada Elevador armazena as informações de um elevador dentro de um prédio, a classe deve armazenar
o andar atual (térreo = 0), total de andares no prédio (desconsiderando o térreo), capacidade do elevador e
quantas pessoas estão presentes nele. A classe Elevador tem os seguintes métodos:

MÉTODOS:

Inicializar: deve receber como parâmetros a capacidade do elevador e o total de andares no prédio
(os elevadores sempre começam no térreo e vazio);

Entrar: deve acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);

Sair: deve remover uma pessoa do elevador (só deve remover se houver alguém entro dele);

Subir: deve subir um andar (não deve subir se já estiver no último andar);

Descer: deve descer um andar (não deve descer se já estiver no térreo);

Finalizar: deve finalizar o elevador se estiver no térreo e vazio;

E as seguintes propriedades:

PROPRIEDADE:

andarAtual: Armazena em qual andar o elevador está;

totalAndares: Número maxímo de andares (excluindo o térreo);

capacidadeElevador: Número maxímo de pessoas;

lotação: Quantas pessoas estão no elevador;
