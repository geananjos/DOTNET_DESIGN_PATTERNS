using FlyweightPattern;

Flyweight  flyweight = new Flyweight();
string cor = string.Empty;

Tartaruga tartaruga;

while (true)
{
    Console.WriteLine();

    Console.Write("Qual tartaruga enviar para tela:");

    cor = Console.ReadLine();

    tartaruga = flyweight.GetTartaruga(cor);
    tartaruga.Mostra(cor);


    Console.WriteLine();
    Console.WriteLine("------------------------");    
}