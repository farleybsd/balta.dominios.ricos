using Flunt.Validations;
using PaymentContext.Domanin.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domanin.Entities
{
    public class Student : Entity
    {
        private IList<SubScription> _subScriptions;
        public Student(Name name, Document document, Email email)
        {
            Name= name;
            Document = document;
            Email = email;
            _subScriptions= new List<SubScription>();

           AddNotifications(name,document,email);
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<SubScription> SubScriptions { get { return _subScriptions.ToArray(); } }

        public void AddSubScription(SubScription subScription)
        {
            var hasSubscriptionActive = false;

            foreach (var sub in _subScriptions)
            {
                if(sub.Active)
                   hasSubscriptionActive = true;
            }

            AddNotifications(new Contract()
                .Requires()
                .IsFalse(hasSubscriptionActive, "Student.subScriptions","Voce ja tem uma assinatura ativa")
                .AreEquals(0,subScription.Payments.Count, "Student.subScriptions.Payments","Essa Assinatura nao possui pagamento"));
        }
    }
}
