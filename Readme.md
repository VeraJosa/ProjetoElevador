VISAO GERAL DO PROJETO

O projeto � um software que tem como fun��o o gerenciamento de um elevador, ele tem as fun��es de inicializar,
entrar, sair, subir, descer e finalizar.  
Foi utilizado o Visual Studio Community para criar o projeto Aplicativo de Console com o nome ProjetoElevador,
e a estrutura .NET 5.
Todas as classes est�o na pasta chamada Model, a estrutura com as pastas de Controller e View s�o opcionais.
A classe denominada Elevador armazena as informa��es de um elevador dentro de um pr�dio, a classe deve armazenar
o andar atual (t�rreo = 0), total de andares no pr�dio (desconsiderando o t�rreo), capacidade do elevador e
quantas pessoas est�o presentes nele. A classe Elevador tem os seguintes m�todos:

M�TODOS:

Inicializar: deve receber como par�metros a capacidade do elevador e o total de andares no pr�dio
(os elevadores sempre come�am no t�rreo e vazio);

Entrar: deve acrescentar uma pessoa no elevador (s� deve acrescentar se ainda houver espa�o);

Sair: deve remover uma pessoa do elevador (s� deve remover se houver algu�m entro dele);

Subir: deve subir um andar (n�o deve subir se j� estiver no �ltimo andar);

Descer: deve descer um andar (n�o deve descer se j� estiver no t�rreo);

Finalizar: deve finalizar o elevador se estiver no t�rreo e vazio;

E as seguintes propriedades:

PROPRIEDADE:

andarAtual: Armazena em qual andar o elevador est�;

totalAndares: N�mero max�mo de andares (excluindo o t�rreo);

capacidadeElevador: N�mero max�mo de pessoas;

lota��o: Quantas pessoas est�o no elevador;
