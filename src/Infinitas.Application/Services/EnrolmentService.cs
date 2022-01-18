using Infinitas.Data;
using Infinitas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infinitas.Application
{
    public class EnrolmentService : IAmEnrolmentService
    {
        private readonly IAmEnrolmentRepository _enrolmentRepository;

        public EnrolmentService(IAmEnrolmentRepository enrolmentRepository)
        {
            _enrolmentRepository = enrolmentRepository;
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync(
            string classCode,
            DateTime date)
        {
            return await _enrolmentRepository.GetStudentsAsync(classCode, date);

            //We could have it here in case it is a domain rule/policy.. but I believe the assignemt's request was more like a UI feature

            //return (students.Count() < 10)
            //    ? students.OrderBy(x => x.Name)
            //    : students;
        }
    }
}
