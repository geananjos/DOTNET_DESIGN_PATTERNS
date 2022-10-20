namespace IteratorPattern.Interfaces
{
    public interface IIterator
    {
        string primeiroItem { get; }
        string proximoItem { get; }
        string atualItem { get; }
        bool estaPronto { get; }
    }
}
