using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akhil.ProcessOrdersBRE
{
    public sealed class ProcessOrdersBRE : IProcessOrdersBRE
    {
        private IProcessProductPaymentTypeAction _IProcessProductPaymentTypeAction;

        private ProcessOrdersBRE()
        {
            _IProcessProductPaymentTypeAction = ProcessProductPaymentTypeAction.GetProcessProductPaymentTypeActionInstance;
        }


        private static ProcessOrdersBRE processOrdersBREInstance = null;
        private static readonly object objProcessOrdersBRE = new object();

        public static ProcessOrdersBRE GetProcessOrdersBREInstance
        {
            get
            {
                if (processOrdersBREInstance == null)
                {
                    lock (objProcessOrdersBRE)
                    {
                        if (processOrdersBREInstance == null)
                            processOrdersBREInstance = new ProcessOrdersBRE();
                    }

                }
                return processOrdersBREInstance;
            }
        }

        public string PaymentAction(string paymentTypeAction)
        {
            string paymentActionResult = null;

            if (paymentTypeAction == BREConstants.Activate_Membership)
                paymentActionResult = _IProcessProductPaymentTypeAction.Activate_Membership(1);

            else if (paymentTypeAction == BREConstants.Generate_Packaging_Slip_for_Shipping)
                paymentActionResult = _IProcessProductPaymentTypeAction.Generate_Packaging_Slip_for_Shipping(1);

            else if (paymentTypeAction == BREConstants.Create_Duplicate_Packing_Slip_For_Royalty_Payment)
                paymentActionResult = _IProcessProductPaymentTypeAction.Create_Duplicate_Packing_Slip_For_Royalty_Payment(1);

            else if (paymentTypeAction == BREConstants.Upgrade_Membeship)
                paymentActionResult = _IProcessProductPaymentTypeAction.Upgrade_Membeship(1);

            else if (paymentTypeAction == BREConstants.Send_Activation_Upgrade_Plan_Email_To_Owner)
                paymentActionResult = _IProcessProductPaymentTypeAction.Send_Activation_Upgrade_Plan_Email_To_Owner(1);

            else if (paymentTypeAction == BREConstants.Add_First_Aid_Free_Video)
                paymentActionResult = _IProcessProductPaymentTypeAction.Add_First_Aid_Free_Video(1);

            else if (paymentTypeAction == BREConstants.Generate_Commission_Payment_To_Agent)
                paymentActionResult = _IProcessProductPaymentTypeAction.Generate_Commission_Payment_To_Agent(1);

            return paymentActionResult;
        }
    }
}
