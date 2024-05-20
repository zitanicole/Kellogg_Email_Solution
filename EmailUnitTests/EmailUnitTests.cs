using Kellogg_Email;

namespace EmailUnitTests
{
    [TestClass]
    public class EmailUnitTests : TestBase
    {
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
            string email = GetTestSetting<string>("invalid1", string.Empty);
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
    }
}