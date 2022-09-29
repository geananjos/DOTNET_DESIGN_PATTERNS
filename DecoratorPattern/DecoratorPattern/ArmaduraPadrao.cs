namespace DecoratorPattern
{
    public class ArmaduraPadrao : MoldeArmadura
    {
        string _descricao = "Protecao simples, ";

        public override string Descricao
        {
            get { return _descricao; }
        }
    }
}
