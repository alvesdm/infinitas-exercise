namespace Infinitas.Domain
{
    /// <summary>
    /// aka Klassen
    /// </summary>
    public class Class : IAmIdentity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}