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
    public class TestPurchaseGoods
    {
        public PurchaseGoodsModel purchase = new PurchaseGoodsModel();
        [TestMethod]
        public void Subtract_PurchaseAmount_WithTotal()
        {
            //// arrange
            //const decimal ZERO = 0;
            //const decimal ONE = 1;

            //// act
            //decimal actual = purchase.decrementTotal(ZERO, ONE);
            
            //// assert
            //Assert.AreEqual(ONE,actual);
        }

        [TestMethod]
        public void Purchase_Goods()
        {

            //try
            //{
            //    purchase.PurchaseGoods();
            //    Assert.IsNull(true);
            //    Assert.IsTrue(true);
            //    return;
            //}
            //catch (Exception ex)
            //{
            //    Assert.IsNull(false);
            //    Assert.IsNull(ex.Message);
            //}
        }

        [TestMethod]
        public void Get_Total_Money_Donations()
        {

            //try
            //{
            //    purchase.getTotalMoneyDonations();
            //    Assert.IsNull(true);
            //    Assert.IsTrue(true);
            //    return;
            //}
            //catch (Exception ex)
            //{
            //    Assert.IsNull(false);
            //    Assert.IsNull(ex.Message);
            //}
        }
    }
}
