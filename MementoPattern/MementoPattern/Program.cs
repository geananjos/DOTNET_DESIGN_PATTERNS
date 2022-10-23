using MementoPattern;

Acao acao = new Acao();
acao.Estado = "play";

Armazena armazena = new Armazena();
armazena.Memento = acao.CriarMemento();

acao.Estado = "pause";
acao.RestaurarEstado(armazena.Memento);

Console.ReadKey();