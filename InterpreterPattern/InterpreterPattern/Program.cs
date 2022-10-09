using InterpreterPattern;

Mochila mochila = new Mochila(new Corda(), new Binoculos(), new ArcoFlecha());
mochila.Interpretar(new Contexto());
Console.ReadKey();