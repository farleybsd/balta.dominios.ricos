using PaymentContext.Domanin.ValueObjects;

namespace PaymentContext.Domanin.Entities
{
    public class CrediCardPayment : Payment
    {
        public CrediCardPayment(string cardHolderName, string cardNumber, string lastTransactionNumber, DateTime paiDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string owner,
            string payer,
            Document document,
            Address address,
            Email email)
            : base(paiDate, expireDate, total, totalPaid, owner, payer, document, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}
