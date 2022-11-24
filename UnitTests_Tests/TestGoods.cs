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
    public class TestGoods
    {
        GoodsDonationsModel goodsModel = new GoodsDonationsModel();
        [TestMethod]
        public void Insert_Disaster()
        {

            try
            {
                goodsModel.insertGoodsDonation();
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
