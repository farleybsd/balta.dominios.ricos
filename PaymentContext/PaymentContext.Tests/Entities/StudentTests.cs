using PaymentContext.Domanin.Entities;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var subscription = new SubScription(null);
            var student = new Student("Andre","Baltieri","1234567891","hello@balta.io");
            student.AddSubScription(subscription);
        }
    }
}
