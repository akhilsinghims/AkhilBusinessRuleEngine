using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akhil.ProcessOrdersBRE
{
  public  interface IProcessProductPaymentTypeAction
    {
        string Generate_Packaging_Slip_for_Shipping(int paymentTypeID);

        string Create_Duplicate_Packing_Slip_For_Royalty_Payment(int paymentTypeID);

        string Activate_Membership(int paymentTypeID);

        string Upgrade_Membeship(int paymentTypeID);

        string Send_Activation_Upgrade_Plan_Email_To_Owner(int paymentTypeID);

        string Add_First_Aid_Free_Video(int paymentTypeID);

        string Generate_Commission_Payment_To_Agent(int paymentTypeID);
    }
}
