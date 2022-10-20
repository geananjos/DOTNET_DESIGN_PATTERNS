namespace IteratorPattern.Interfaces
{
    public interface IAggregate
    {
        IIterator GetIterator();
        string this[int indexItem] { set; get; }
        int Contador { get; }
    }
}
