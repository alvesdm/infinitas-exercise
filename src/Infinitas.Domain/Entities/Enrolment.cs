using System;

namespace Infinitas.Domain
{
    /// <summary>
    /// aka Inschrijvingen
    /// </summary>
    public class Enrolment : IAmIdentity<Guid>
    {
        public Guid Id { get; set; }
        public Student Student { get; set; }
        public Class Class { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}