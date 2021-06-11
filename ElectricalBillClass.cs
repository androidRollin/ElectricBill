using System;

namespace ElectricBill
{
    public interface iArea
    {
        string areaName { get; }
        int getPercentage(iAccount account)
}

    public interface iAccount
    {
        string accName { get; }
        double priceKwH { get; }
    }


    public class ElectricBillClass
    {
        private iAccount account;
        private iArea area;
        private string accountnumber;
        private string customerName;
        private double prevReading;
        private double currReading;
        private double kwHUsed;
        private double electricBill;
        private double systemCharges;
        private double totalBill;
    }




    public class Residential : iAccount
    {
        public string accName
        {
            get { return "Residential"; }
        }
        public double priceKwH
        {
            get { return 15.00; }
        }
    }

    public class Commercial : iAccount
    {
        public string accName
        {
            get { return "Commercial"; }
        }
        public double priceKwH
        {
            get { return 30.00; }
        }
    }


    public class Industrial : iAccount
    {
        public string accName
        {
            get { return "Industrial"; }
        }
        public double priceKwH
        {
            get { return 45.00; }
        }
    }

    public class NCR : iArea
    {
        public string areaName
        {
            get { return "Metro Manila"}
        }
        public int getPercentage(iAccount account)
        {
            if (account.GetType == Residential)
            {
                return 3
            }
            else if (account.GetType == Commercial)
            {
                return 6
            }
            else
            {
                return 9
            }
        }
    }
    public class Provincial : iArea
    {
        public string areaName
        {
            get { return "Provincial"}
        }
        if (account.GetType == Residential)
        {
            return 2
        }
        else if (account.GetType == Commercial)
        {
            return 4
        }
        else 
        {
            return 6
        }
}

}

