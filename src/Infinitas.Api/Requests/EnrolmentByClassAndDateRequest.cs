using MediatR;
using System;
using System.Collections.Generic;

namespace Infinitas.Api.Controllers
{
    public class EnrolmentByClassAndDateRequest : IRequest<IEnumerable<StudentModel>>
    {
        public string ClassCode { get; internal set; }
        public DateTime Date { get; internal set; }
    }
}
