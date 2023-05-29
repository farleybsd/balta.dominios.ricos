namespace PaymentContext.Domanin.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string transactionCode,
            DateTime paiDate,
            DateTime expireDate,
            decimal total, 
            decimal totalPaid, 
            string owner,
            string payer, 
            string document,
            string address,
            string email)
            : base(paiDate, expireDate, total, totalPaid, owner, payer, document, address, email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}
