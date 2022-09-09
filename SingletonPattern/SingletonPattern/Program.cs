using SingletonPattern;

Singleton jogador1 = Singleton.GetInstancia;
jogador1.Mensagem("Jogador 1: A bola esta comigo no meio do campo.");

Singleton jogador2 = Singleton.GetInstancia;
jogador2.Mensagem("Jogador 2: Recebeu a bola.");

Singleton jogador3 = Singleton.GetInstancia;
jogador3.Mensagem("Jogador 3: Recebeu o lancamento na linha de fundo.");

Console.ReadKey();