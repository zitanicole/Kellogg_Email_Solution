using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmailUnitTests
{
    public class TestBase
    {
        public TestContext TestContext { get; set; }
        public T GetTestSetting<T>(string name, T defaultvalue)
        {
            T returnValue = defaultvalue;
            try
            {
                var temp = TestContext.Properties[name];
                if (temp != null)
                {
                    returnValue = (T)Convert.ChangeType(temp, typeof(T));
                }
            }
            catch
            {
                // ingnore
            }
            return returnValue;
        }
    }
}
