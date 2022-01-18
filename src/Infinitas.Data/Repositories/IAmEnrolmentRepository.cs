using Infinitas.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infinitas.Data
{
    public interface IAmEnrolmentRepository
    {
        Task<IEnumerable<Student>> GetStudentsAsync(
            string classCode,
            DateTime date);
    }
}
