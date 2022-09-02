
using FactoryMethod;

var fm = new FactoryMethodClass();

Console.WriteLine("Liu Kang | SubZero | Scorpion");
Console.WriteLine();

Console.WriteLine("Escolha seu personagem");
string escolha = Console.ReadLine();

IPersonagem personagem = fm.EscolherPersonagem(escolha);

Console.WriteLine();
Console.Write("Voce vai jogar com ");
personagem.Escolhido();

Console.ReadKey();