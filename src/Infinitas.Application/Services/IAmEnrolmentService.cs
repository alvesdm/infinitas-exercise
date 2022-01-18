using Infinitas.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infinitas.Application
{
    public interface IAmEnrolmentService
    {
        Task<IEnumerable<Student>> GetStudentsAsync(
            string classCode, 
            DateTime date);
    }
}