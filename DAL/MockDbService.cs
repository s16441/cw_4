using Cw_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw_3.DAL
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
             //   new Student { IdStudent = 10, FirstName = "Jan", LastName = "Kowalski" },
               // new Student { IdStudent = 22, FirstName = "Anna", LastName = "Majewska" },
                //new Student { IdStudent = 33, FirstName = "Andrzej", LastName = "Andrzejewicz" }
            };
        }
        public IEnumerable<Student> GetStudents()
        {
            return _students;

        }
    }
}