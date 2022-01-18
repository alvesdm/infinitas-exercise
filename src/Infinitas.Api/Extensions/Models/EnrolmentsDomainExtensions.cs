using Infinitas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infinitas.Api.Controllers
{
    public static class EnrolmentsDomainExtensions
    {
        public static IEnumerable<StudentModel> ToModel(this IEnumerable<Student> students)
        {
            return students.Select(student => new StudentModel 
            {
                UniqueId = Guid.Empty, //making it empty as we dont have such field in our DB scheme
                Name = student.Name
            });
        }
    }
}
