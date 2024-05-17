using Kellogg_Email;

namespace EmailUnitTests
{
    [TestClass]
    public class EmailUnitTests : TestBase
    {
        [TestMethod]
        public void EmailIsValid_IsTrue()
        {
            string email = GetTestSetting<string>("1", "email@email.com");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(result);  
        }

        [TestMethod]
        public void EmailIsNull_IsTrue()
        {
            string email = GetTestSetting<string>("2", "");
            bool result = EmailValidator.IsValidEmail(email);
            Assert.IsTrue(result);
        }
    }
}