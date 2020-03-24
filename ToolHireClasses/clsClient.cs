using System;

namespace ToolHireClasses
{
    public class clsClient
    {
        private bool mActive;
        private Int32 mClientId;
        private String mBillingInformation;
        private String mSubscriptionType;
        private String mClientName;
        private DateTime mSignUpDate;

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
         }
        public Int32 ClientId
        {
            get
            {
                return mClientId;
            }
            set
            {
                mClientId = value;
            }
        }
            
        public String BillingInformation
        {
            get
            {
                return mBillingInformation;
            }
            set
            {
                mBillingInformation = value;
            }
        }

        public String SubscriptionType
        {
            get
            {
                return mSubscriptionType;
            }
            set
            {
                mSubscriptionType = value;
            }
        }

        
        public String ClientName
        {
            get
            {
                return mClientName;
            }
            set
            {
                mClientName = value;
            }
        }

        public DateTime SignUpDate
        {
            get
            {
                return mSignUpDate;
            }
            set
            {
                mSignUpDate = value;
            }
        }

      /*  public bool Find(int ClientId)
        {
            ClientId = 1;
            ClientName = "Ollie Hughes";
            BillingInformation = "21 Hilltop Road";
            SubscriptionType = "Platinum";
            SignUpDate = Convert.ToDateTime(16 / 08 / 2012);
            Active = true;

            return true;
        }*/

    }
}