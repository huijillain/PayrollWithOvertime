using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class payrollAmount : Form
    {
        public payrollAmount()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Named constants 
                const decimal REGULAR_HOURS = 37m;
                const decimal OVERTIME_RATE = 1.5m;

                // Local variables 
                decimal hoursWorked;
                decimal hourlyPayRate;
                decimal basePay;
                decimal overtimeHours;
                decimal overtimePay;
                decimal grossPay;

                // Get the hours worked and hourly pay rate. 
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                // Determine the gross pay. 
                if (hoursWorked > REGULAR_HOURS)
                {
                    // Calculate the base pay (without overtime). 
                    basePay = hourlyPayRate * REGULAR_HOURS;

                    // Calculate the number of overtime hours. 
                    overtimeHours = hoursWorked - REGULAR_HOURS;

                    // Calculate the overtime pay. 
                    overtimePay = overtimeHours * hourlyPayRate * OVERTIME_RATE;

                    // Calculate the gross pay. 
                    grossPay = basePay + overtimePay;
                }
                else
                {
                    // Calculate the gross pay. 
                    grossPay = hoursWorked * hourlyPayRate;
                }

                // Display the gross pay. 
                GrossPayLabel.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                // Display an error message. 
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + 
                    ex.StackTrace, "Exception");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and gross pay label. 
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            GrossPayLabel.Text = "";

            // Reset the focus. 
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
