using ProxyPattern;

ProxyFase proxy = new ProxyFase();

Console.WriteLine("### Tentando acessar a fase do jogo com Password incorreto ####");
Console.WriteLine(proxy.InformarPassword("456"));
Console.WriteLine(proxy.Jogar());

Console.WriteLine();

Console.WriteLine("### Tentando acessar a fase do jogo com Password correto ###");
Console.WriteLine(proxy.InformarPassword("123"));
Console.WriteLine(proxy.Jogar());
Console.WriteLine();

Console.ReadKey();