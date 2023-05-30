using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domanin.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
                            .Requires()
                            .HasMinLen(firstName,3,"Name.FirstName","Nome Deve Conter Pelo Menos 3 Caracteres")
                            .HasMinLen(lastName, 3, "Name.lastName", "SobreNome Deve Conter Pelo Menos 3 Caracteres")
                            .HasMaxLen(firstName, 40, "Name.lastName", "Nome Deve Conter Ate 40 Caracteres")
                            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
