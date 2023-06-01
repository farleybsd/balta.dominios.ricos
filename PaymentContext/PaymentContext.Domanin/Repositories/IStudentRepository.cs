using PaymentContext.Domanin.Entities;

namespace PaymentContext.Domanin.Repositories
{
    public interface IStudentRepository
    {
        bool DocumentExists(string document);
        bool EmailExists(string email);
        void CreateSubscription(Student student);
    }
}
