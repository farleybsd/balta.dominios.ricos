namespace PaymentContext.Domanin.Entities
{
    public class Student
    {
        private IList<SubScription> _subScriptions;
        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subScriptions= new List<SubScription>();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
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
