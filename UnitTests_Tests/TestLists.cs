using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using POE_Task_1.Pages;

namespace UnitTests_Tests
{
    [TestClass]
    public class TestLists
    {
        public MonetaryModel monetary = new MonetaryModel();

        [TestMethod]
        public void Display_Lists()
        {
            try
            {
                monetary.displayLists();
                Assert.IsNull(true);
                Assert.IsTrue(true);
                return;
            }
            catch (Exception ex)
            {
                Assert.IsNull(false);
                Assert.IsNull(ex.Message);
            }
        }
    }
}
