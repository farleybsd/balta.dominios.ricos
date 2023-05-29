using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domanin.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if (string.IsNullOrEmpty(FirstName))
                AddNotification("FirstName", "Nome Invalido");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
