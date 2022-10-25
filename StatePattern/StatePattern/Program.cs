using StatePattern;

Contexto contexto = new Contexto(new PersonagemA());
contexto.Troca();
contexto.Troca();
contexto.Troca();
contexto.Troca();

Console.ReadKey();