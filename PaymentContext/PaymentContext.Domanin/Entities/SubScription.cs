namespace PaymentContext.Domanin.Entities
{
    public class SubScription
    {
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool Active { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
