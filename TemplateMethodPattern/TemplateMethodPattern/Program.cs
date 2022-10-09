using TemplateMethodPattern;

Console.WriteLine("### Escolha o modo de corrida");

Console.WriteLine("1-Facil | 2-Normal | 3-Dificil");

Console.WriteLine("Suas condições de jogo são: ");

Jogo jogo = null;

switch (Console.ReadLine())
{
    case "1": jogo = new ModoFacil(); break;
    case "2": jogo = new ModoNormal(); break;
    case "3": jogo = new ModoDificil(); break;
}

Console.ReadKey();