using CommandPattern;

Controle controle = new Controle();
controle.EnviarComandoSimples(new SimplesComando("Dizer oi!"));

Receiver receiver = new Receiver();
controle.EnviarComandoComplexo(new ComplexoComando(receiver, "Abastecer o carro", "Calibrar os pneus do carro"));

controle.Fazer();
Console.ReadKey();