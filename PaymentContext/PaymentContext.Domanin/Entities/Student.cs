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
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<SubScription> SubScriptions { get { return _subScriptions.ToArray(); } }

        public void AddSubScription(SubScription subScription)
        {
            // Todo:
            // Se ja tiver uma assinatura ativa,cancela
            // Cancelar todas as assinaturas e colocar essa como principal
            foreach (var sub in SubScriptions)
                sub.Inactivate();
            
            _subScriptions.Add(subScription);
        }
    }
}
