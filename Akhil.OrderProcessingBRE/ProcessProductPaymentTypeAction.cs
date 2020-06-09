using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akhil.ProcessOrdersBRE
{
    public sealed class ProcessProductPaymentTypeAction : IProcessProductPaymentTypeAction
    {
        private ProcessProductPaymentTypeAction()
        {
        }

        private static ProcessProductPaymentTypeAction processProductPaymentTypeActionInstance=null;
        private static readonly object objProcessProductPaymentTypeAction = new object();

        public static ProcessProductPaymentTypeAction GetProcessProductPaymentTypeActionInstance
        {
            get
            {
                if (processProductPaymentTypeActionInstance == null)
                {
                    lock (objProcessProductPaymentTypeAction)
                    {
                        if (processProductPaymentTypeActionInstance == null)
                            processProductPaymentTypeActionInstance = new ProcessProductPaymentTypeAction();
                    }
                }
                return processProductPaymentTypeActionInstance;
            }
        }
        public string Activate_Membership(int paymentTypeID)
        {
            return "Activated the membership";
        }

        public string Add_First_Aid_Free_Video(int paymentTypeID)
        {
            return "Added first aid [Free Video]";
        }

        public string Create_Duplicate_Packing_Slip_For_Royalty_Payment(int paymentTypeID)
        {
            return "Created duplicate packing slip for royality payment";
        }

        public string Generate_Commission_Payment_To_Agent(int paymentTypeID)
        {
            return "Genrated commission payment to the agent";
        }

        public string Generate_Packaging_Slip_for_Shipping(int paymentTypeID)
        {
            return "Genereate packaging slip for shipping";
        }

        public string Send_Activation_Upgrade_Plan_Email_To_Owner(int paymentTypeID)
        {
            return "Send activation upgrade plan email to the owner";
        }

        public string Upgrade_Membeship(int paymentTypeID)
        {
            return "Upgraded the membership";
        }
    }
}
