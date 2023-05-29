using PaymentContext.Domanin.ValueObjects;

namespace PaymentContext.Domanin.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, string boletoNumber, DateTime paiDate,
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
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}
