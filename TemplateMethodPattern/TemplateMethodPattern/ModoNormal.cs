namespace TemplateMethodPattern
{
    public class ModoNormal : Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("O carro deve abastecer uma vez");
        }

        public override void SegundaFase()
        {
            Console.WriteLine("Os carros devem correr na mesma velocidade");
        }
    }
}
