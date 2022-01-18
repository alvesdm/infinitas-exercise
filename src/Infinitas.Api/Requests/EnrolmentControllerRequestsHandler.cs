using Infinitas.Application;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Infinitas.Api.Controllers
{
    public class EnrolmentControllerRequestsHandler : 
        IRequestHandler<EnrolmentByClassAndDateRequest, IEnumerable<StudentModel>>
    {
        private readonly IAmEnrolmentService _enrolmentService;

        public EnrolmentControllerRequestsHandler(IAmEnrolmentService enrolmentService)
        {
            _enrolmentService = enrolmentService;
        }
        public async Task<IEnumerable<StudentModel>> Handle(EnrolmentByClassAndDateRequest request, CancellationToken cancellationToken)
        {
            var students = await _enrolmentService.GetStudentsAsync(request.ClassCode, request.Date);

            if ((students.Count() < 10))
                return students.OrderBy(x => x.Name).ToModel();

            return students.ToModel();
            
            //We could also have it this way below, but i like the other way better for readability reasons

            //var studentList = (students.Count() < 10)
            //    ? students.OrderBy(x => x.Name)
            //    : students;

            //return studentList.ToModel();
        }
    }
}
