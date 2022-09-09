using BuilderPattern;

var exercito = new Exercito();
CriadorDeSoldado criadorDeSoldado;
Soldado soldado;

//criando um soldado das Focas Especiais
criadorDeSoldado = new CriadorForcasEspeciais();
exercito.ConstruirSoldado(criadorDeSoldado);
soldado = criadorDeSoldado.ObterSoldado();
Console.WriteLine("Soldado com as caracteristicas: {0},{1},{2}", soldado.Arma, soldado.Transporte, soldado.Foco);
Console.ReadKey();