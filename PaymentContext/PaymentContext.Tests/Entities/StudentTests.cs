using PaymentContext.Domanin.Entities;
using PaymentContext.Domanin.Enums;
using PaymentContext.Domanin.ValueObjects;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        private readonly Name _name;
        private readonly Domanin.ValueObjects.Document _document;
        private readonly Address _address;
        private readonly Email _email;
        private readonly Student _student;
        private readonly SubScription _subScription;

        public StudentTests()
        {
            _name = new Name("Bruce", "Wayne");
            _document = new Domanin.ValueObjects.Document("35111507795", EDocumentType.CPF);
            _address = new Address("Rua 1", "1234", "Bairro Legal", "Gotham", "SP", "BR", "1340000");
            _email = new Email("batman@dc.com");
            _student = new Student(_name, _document, _email);
            _subScription = new SubScription(null);
           
        }


        [TestMethod]
        public void ShouldReturnErrorWhenActiveSubscription()
        {
            var payment = new PayPalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Wayne Corp", "Wayne Corp", _document, _address, _email);
            _subScription.AddPayment(payment);
            _student.AddSubScription(_subScription);
            _student.AddSubScription(_subScription);
            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenActiveSubscriptionNoPaymament()
        {
            _student.AddSubScription(_subScription);
            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccesWhenAddSubscription()
        {
            var payment = new PayPalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Wayne Corp", "Wayne Corp", _document, _address, _email);
            _subScription.AddPayment(payment);
            _student.AddSubScription(_subScription);
            Assert.IsTrue(_student.Valid);
        }
    }
}
