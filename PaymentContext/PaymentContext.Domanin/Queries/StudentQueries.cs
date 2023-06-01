using PaymentContext.Domanin.Entities;
using System.Linq.Expressions;

namespace PaymentContext.Domanin.Queries
{
    public static class StudentQueries
    {
        public static Expression<Func<Student, bool>> GetStudentInfo(string document)
        {
            return x => x.Document.Number == document;
        }

    }
}
