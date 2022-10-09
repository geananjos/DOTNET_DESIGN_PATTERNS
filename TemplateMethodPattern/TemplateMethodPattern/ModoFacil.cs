namespace TemplateMethodPattern
{
    public class ModoFacil : Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("Combustivel para a corrida toda");
        }

        public override void SegundaFase()
        {
            Console.WriteLine("Carros adversarios devem correr menos");
        }
    }
}
