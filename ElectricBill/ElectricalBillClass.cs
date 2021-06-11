using System;

    public interface IArea
    {
        string areaName { get; }
        int GetPercentage(IAccount account);
     }

    public interface IAccount
    {
        string accName { get; }
        double priceKwH { get; }
    }


    public class ElectricalBill
    {
        private IAccount account;
        private IArea area;
        private string accountnumber;
        private string customerName;
        private int prevReading;
        private int currReading;
        private double kilowattHrs;
        private double electricBill;
        private double systemCharges;
        private double totalBill;


    public ElectricalBill(int currReading, int prevReading, IAccount account, IArea area)
        {
        GetTotalBill(currReading, prevReading, account, area);
        }

    public double GetKilowattHrs()
    {
        return kilowattHrs;
    }

    public double GetElectricalBill()
    {
        return electricBill;
    }

    public double GetSystemCharges()
    {
        return electricBill;
    }

    public double GetToDisplayTotalBill()
    {
        return totalBill;
    }

    private double GetTotalBill(int currReading, int prevReading, IAccount account, IArea area)
    {
        this.currReading = currReading;
        this.prevReading = prevReading;
        this.account = account;
        this.area = area;

        kilowattHrs = ComputeKilowattHrs();
        Console.WriteLine(kilowattHrs);
        electricBill = ComputeElectricBill();
        Console.WriteLine(electricBill);
        systemCharges = ComputeSystemCharges();
        Console.WriteLine(systemCharges);
        totalBill = ComputeTotalBill();
        Console.WriteLine(totalBill);
        return totalBill;
    }

    private double ComputeTotalBill()
    {
        return electricBill + systemCharges;
    }

    private double ComputeSystemCharges()
    {
        double percentage = (Convert.ToDouble(area.GetPercentage(account)) / 100);
        Console.WriteLine("percentage computation = " + area.GetPercentage(account));
        Console.WriteLine("percentage = " + percentage);

        systemCharges = electricBill * percentage;
        return systemCharges;
    }

    private double ComputeElectricBill()
    {
        return kilowattHrs * account.priceKwH;
    }

    private int ComputeKilowattHrs()
    {
        return (currReading - prevReading);
    }
}




    public class Residential : IAccount
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

    public class Commercial : IAccount
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


    public class Industrial : IAccount
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

    public class NCR : IArea
    {
        public string areaName
        {
            get { return "Metro Manila"; }
        }
        public int GetPercentage(IAccount account)
        {
            if (account.GetType() == typeof(Residential))
            {
                return 3;
            }
            else if (account.GetType() == typeof(Commercial))
            {
                return 6;
            }
            else
            {
                return 9;
            }
        }
    }
    public class Provincial : IArea
    {
        public string areaName
        {
            get { return "Provincial"; }
        }
    public int GetPercentage(IAccount account)
    {
        if (account.GetType() == typeof(Residential))
        {
            return 2;
        }
        else if (account.GetType() == typeof(Commercial))
        {
            return 4;
        }
        else 
        {
            return 6;
        }
    }
}


