using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricBill
{
    public partial class fElectribBill : Form
    {
        int current;
        int previous;
        public fElectribBill()
        {
            InitializeComponent();
            cbAccountType.SelectedIndex = 0;
            cbCustomerArea.SelectedIndex = 0;
            Console.WriteLine("Hello World");
        }

        private void lblPreviousReading_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            checkCurrentReadingValue();
            int indexAccountTypeSelected = cbAccountType.SelectedIndex;
            int indexAreaSelected = cbCustomerArea.SelectedIndex;
            Console.WriteLine(indexAreaSelected + " " + indexAccountTypeSelected);
            IAccount acc = getAccountType(indexAccountTypeSelected);
            IArea area = getArea(indexAreaSelected);
            ElectricalBill custJudith = new ElectricalBill(current, previous, acc, area);
            changeDisplayedTextBoxes(custJudith);
        }

        private void changeDisplayedTextBoxes(ElectricalBill customer)
        {
            string value; 
            value = customer.GetKilowattHrs().ToString();
            tbKwHUsed.Text = value;
            value = customer.GetElectricalBill().ToString();
            tbElectricBill.Text = value;
            value = customer.GetSystemCharges().ToString();
            tbSystemCharges.Text = value;
            value = customer.GetToDisplayTotalBill().ToString();
            tbTotalBill.Text = value;
           
        }

        private IArea getArea(int indexAreaSelected)
        {
            if (indexAreaSelected == 0)
            {
                NCR loc = new NCR();
                return loc;
            }
            else
            {
                Provincial loc = new Provincial();
                return loc;
            }
        }

        private IAccount getAccountType(int indexAccountTypeSelected)
        {
            if (indexAccountTypeSelected == 0)
            {
                Residential acc = new Residential();
                return acc;
            }
            else if (indexAccountTypeSelected == 1)
            {
                Commercial acc = new Commercial();
                return acc;
            }
            else
            {
                Industrial acc = new Industrial();
                return acc;
            }
        }

        private void checkCurrentReadingValue()
        {
            try
            {
                current = Int32.Parse(tbCurrentReading.Text);
                previous = Int32.Parse(tbPreviousReading.Text);
                if (current < previous)
                {
                    MessageBox.Show("Incorrect Reading, please input a new value for current Reading, please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (current < 0 || previous < 0)
                {
                    MessageBox.Show("Incorrect Reading Non-positive integer is not allowed, please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (FormatException)
            {
                MessageBox.Show("Non-numeric value is inputed, please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void tbCurrentReading_TextChanged(object sender, EventArgs e)
        {
        }


        private void tbCurrentReading_OnChange(object sender, EventArgs e)
        {
               
        }

        private void tbPreviousReading_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCustomerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
