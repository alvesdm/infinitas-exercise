using Dapper;
using Infinitas.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infinitas.Data
{
    public class EnrolmentRepository : IAmEnrolmentRepository
    {
        private readonly IAmDbContext _context;

        public EnrolmentRepository(IAmDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync(
            string classCode, 
            DateTime date)
        {
            var query = @"
SELECT
    s.* 
    FROM Inschrijvingen e
    INNER JOIN Leerlingen s
        on s.Id = e.LeerlingId
    INNER JOIN Klassen c
        on c.Id = e.KlasId
    WHERE c.Code = @ClassCode AND e.StartDate <= @Date AND (e.EndDate IS NULL OR e.EndDate >= @Date)
    ORDER BY s.Id";

            using (var connection = _context.CreateConnection())
            {
                connection.Open();
                return await connection.QueryAsync<Student>(query, new { ClassCode = classCode, Date = date });
            }
        }
    }
}
