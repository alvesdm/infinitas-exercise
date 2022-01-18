namespace Infinitas.Domain
{
    /// <summary>
    /// aka Leerlingen
    /// </summary>
    public class Student : IAmIdentity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}