using AdapterPattern;

Personagem reiner = new Personagem();
Aviao aviao_de_batalha = new Aviao();

IAcao adaptador = new Adapter(aviao_de_batalha);

Console.WriteLine("---- Caminhando ----");
reiner.Andar("Reiner Braun");
reiner.Atirar();


Console.WriteLine();

Console.WriteLine("---- Pegou um aviao no jogo ----");
adaptador.Andar("Reiner Braun");
adaptador.Atirar();

Console.ReadKey();