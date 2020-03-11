using System;

namespace ToolHireTests
{
    public class clsClient
    {
        private bool mActive;
        private int mClientId;
        private string mBillingInformation;
        private string mSubscriptionType;
        private string mClientName;
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
        public int ClientId
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
            
        public string BillingInformation
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

        public string SubscriptionType
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

        
        public string ClientName
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

        public bool Find(int ClientId)
        {
            ClientId = 1;
            ClientName = "Ollie Hughes";
            BillingInformation = "21 Hilltop Road";
            SubscriptionType = "Platinum";
            SignUpDate = Convert.ToDateTime(16 / 08 / 2012);
            Active = true;

            return true;
        }

    }
}