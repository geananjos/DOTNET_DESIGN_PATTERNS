using VisitorPattern;
using VisitorPattern.Interfaces;

List<IJogo> jogo = new List<IJogo>();
jogo.Add(new FaseJogo() { NomeFase = "Floresta" });
jogo.Add(new FaseJogo() { NomeFase = "Caverna" });
jogo.Add(new Chefao() { NomeChefao = "Boss 1", PontoVida = 30 });
jogo.Add(new Chefao() { NomeChefao = "Boss 2", PontoVida = 50 });

NivelVisitor niveis = new NivelVisitor();
foreach (var etapa in jogo)
{
    etapa.Visitante(niveis);
}

Console.ReadLine();