using Flunt.Validations;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domanin.Entities
{
    public class SubScription : Entity
    {
        private IList<Payment> _payments;
        public SubScription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<Payment> Payments { get { return _payments.ToArray(); } }

        public void AddPayment(Payment payment)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsGreaterThan(DateTime.Now, payment.PaiDate, "SubScription.payment","A Data do Pagamento deve ser futura"));

            if(Valid)
            _payments.Add(payment);
        }
        public void Activate()
        {
            Active = true;
            LastUpdate= DateTime.Now;
        }
        public void Inactivate()
        {
            Active = false;
            LastUpdate = DateTime.Now;
        }
    }
}
