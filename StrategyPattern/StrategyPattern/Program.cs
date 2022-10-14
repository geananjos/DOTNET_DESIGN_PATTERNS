using StrategyPattern;

var papagaio = new Ajuda(new Papagaio());
Console.WriteLine(papagaio.Ajudar());

var sapo = new Ajuda(new Sapo());
Console.WriteLine(sapo.Ajudar());

Console.ReadKey();