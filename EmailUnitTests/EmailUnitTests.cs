using Kellogg_Email;

namespace EmailUnitTests
{
    [TestClass]
    public class EmailUnitTests : TestBase
    {

        [TestMethod]
        public void NullTest_IsFalse()
        {
            string email = GetTestSetting<string>("null", null);
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EmailIsNotNull_IsTrue()
        {
            string email = GetTestSetting<string>("valid1", "email@email.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EmailIsNotNull_IsFalse()
        {
            string email = GetTestSetting<string>("invalid1", "");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EmailHasOneAtSymbol_IsTrue()
        {
            string email = GetTestSetting<string>("valid2", "onlyone@atsymbol.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EmailHasOneAtSymbol_IsFalse()
        {
            string email = GetTestSetting<string>("invalid2", "atsymbol.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EmailHasOneAtSymbol_1_IsFalse()
        {
            string email = GetTestSetting<string>("invalid3", "more@thanone@atsymbol.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EmailHasOneAtSymbol_2_IsFalse()
        {
            string email = GetTestSetting<string>("invalid8", "@space.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EmailHasOneAtSymbol_3_IsFalse()
        {
            string email = GetTestSetting<string>("invalid9", "space.com@");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EmailHasNoSpace_IsFalse()
        {
            string email = GetTestSetting<string>("invalid4", "theres a@space.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UsernameLength_IsFalse()
        {
            string email = GetTestSetting<string>("invalid5", "qwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbnm@email.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DomainLength_IsFalse()
        {
            string email = GetTestSetting<string>("invalid6", "domaintooshort@e.");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DomainLength_1_IsFalse()
        {
            string email = GetTestSetting<string>("invalid7", "domain@qwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbnm.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Period_IsFalse()
        {
            string email = GetTestSetting<string>("invalid10", "period@.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Period_1_IsFalse()
        {
            string email = GetTestSetting<string>("invalid11", "period@com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Period_2_IsFalse()
        {
            string email = GetTestSetting<string>("invalid12", "period@com.");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Space_IsTrue()
        {
            string email = GetTestSetting<string>("invalid13", "theresa@space.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UsernameLength_1_IsFalse()
        {
            string email = GetTestSetting<string>("invalid14", "@space.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UsernameLength_IsTrue()
        {
            string email = GetTestSetting<string>("invalid15", "char@valid.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UsernameLength_IsOne_IsTrue()
        {
            string email = GetTestSetting<string>("invalid16", "c@valid.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void Valid_IsTrue()
        {
            string email = GetTestSetting<string>("valid3", "valid@email.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void index0_charalpha_IsFalse()
        {
            string email = GetTestSetting<string>("char1", "1char@email.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void indexlast_charalpha_IsFalse()
        {
            string email = GetTestSetting<string>("char2", "char1@email.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void chardomain_IsFalse()
        {
            string email = GetTestSetting<string>("char3", "char@1mail.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void chardomain_1_IsFalse()
        {
            string email = GetTestSetting<string>("char4", "char@email.com1");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void chardomain_IsTrue()
        {
            string email = GetTestSetting<string>("char5", "charvalid@email.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void chardomain_1_IsTrue()
        {
            string email = GetTestSetting<string>("char6", "char1valid@email.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void charuser_IsTrue()
        {
            string email = GetTestSetting<string>("char7", "charvalid@email1.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void charuser_1_IsTrue()
        {
            string email = GetTestSetting<string>("char8", "char2valid@email.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(result);
        }
    }
}