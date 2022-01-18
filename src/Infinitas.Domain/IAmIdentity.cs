namespace Infinitas.Domain
{
    //This could be handy down the road
    public interface IAmIdentity<T>
    {
        T Id { get; set; }
    }
}