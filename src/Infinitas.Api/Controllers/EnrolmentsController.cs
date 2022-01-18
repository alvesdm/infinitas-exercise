using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infinitas.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnrolmentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EnrolmentsController(
            //Using mdiator pattern to avoid fat controllters
            IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Returns a list of students by Class Code and Date
        /// </summary>
        /// <param name="classCode"> i.e: 2A</param>
        /// <param name="date">i.e: 2018-09-01</param>
        /// <returns>A list of StudentModel</returns>
        [HttpGet]
        [Route("{classCode}/{date}")]
        public async Task<IEnumerable<StudentModel>> Get(
            string classCode,
            DateTime date)
        {
            return await _mediator.Send(new EnrolmentByClassAndDateRequest
            {
                ClassCode = classCode,
                Date = date
            });
        }
    }
}
