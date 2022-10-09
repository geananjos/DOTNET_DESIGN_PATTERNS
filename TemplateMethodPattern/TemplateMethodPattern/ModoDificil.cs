namespace TemplateMethodPattern
{
    public class ModoDificil : Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("Adicionar obstaculo na pista");
        }

        public override void SegundaFase()
        {
            Console.WriteLine("Carros adversarios devem correr mais");
        }
    }
}
