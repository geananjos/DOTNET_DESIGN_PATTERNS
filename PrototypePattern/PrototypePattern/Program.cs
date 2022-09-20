using PrototypePattern;

GerenciadorNuvens gerenciadorNuves = new GerenciadorNuvens();
gerenciadorNuves["padrao"] = new NuvemConcreta("branco", "azul");
gerenciadorNuves["personalizada"] = new NuvemConcreta("branco", "laranja");

NuvemConcreta um = gerenciadorNuves["padrao"].Clone() as NuvemConcreta;
NuvemConcreta dois = gerenciadorNuves["padrao"].Clone() as NuvemConcreta;
NuvemConcreta tres = gerenciadorNuves["personalizada"].Clone() as NuvemConcreta;

Console.ReadKey();
