using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Akhil.ProcessOrdersBRE.UnitTest
{
    [TestClass]
    public class ProcessOrdersBRETest
    {
        public IProcessOrdersBRE singletonProcessOrdersBRE;

        public ProcessOrdersBRETest()
        {
            singletonProcessOrdersBRE = ProcessOrdersBRE.GetProcessOrdersBREInstance;
        }

        [TestMethod]
        public void ProcessOrdersBRE_Verify_SingeltonObject()
        {
            var mockProcessOrdersBRE = new Mock<IProcessOrdersBRE>();
            mockProcessOrdersBRE.Setup(x => x.PaymentAction(BREConstants.Activate_Membership)).Returns("Activated the membership");
            mockProcessOrdersBRE.Verify();
        }

        [TestMethod]
        public void ProcessOrdersBRE_SingeltonObject_ConstructorInitialization()
        {            
            var paymentAction = singletonProcessOrdersBRE.PaymentAction(BREConstants.Activate_Membership);
            Assert.AreEqual("Activated the membership", paymentAction);
        }

        [TestMethod]
        public void PaymentAction_PositiveCase()
        {
            Assert.AreEqual("Activated the membership", ProcessOrdersBRE.GetProcessOrdersBREInstance.PaymentAction(BREConstants.Activate_Membership));
        }

        [TestMethod]
        public void PaymentAction_NegativeCase()
        {
            Assert.AreNotEqual("", ProcessOrdersBRE.GetProcessOrdersBREInstance.PaymentAction(BREConstants.Activate_Membership));
        }

        [TestMethod]
        public void ProcessProductPaymentTypeAction_SingeltonObject()
        {
            IProcessProductPaymentTypeAction processProductPaymentTypeAction = ProcessProductPaymentTypeAction.GetProcessProductPaymentTypeActionInstance;
            Assert.IsNotNull(processProductPaymentTypeAction.Activate_Membership(0));
        }

        [TestMethod]
        public void ProcessOrdersBRE_SingeltonObject()
        {
            IProcessOrdersBRE processOrdersBRE = ProcessOrdersBRE.GetProcessOrdersBREInstance;
            Assert.IsNotNull(processOrdersBRE.PaymentAction(BREConstants.Add_First_Aid_Free_Video));
        }
    }
}
