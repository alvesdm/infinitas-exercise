using System;

namespace Infinitas.Api.Controllers
{
    public class StudentModel
    {
        public Guid UniqueId { get; set; } /*ideally we'd have an external id other than an integer, to avoid security issues*/
        public string Name { get; set; }
    }
}
