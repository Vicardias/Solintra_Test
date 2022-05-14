using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace Solintra_Test
{
    public partial class Test_Solintra : Form
    {
        public Test_Solintra()
        {
            InitializeComponent();
        }

        private void Test_Solintra_Load(object sender, EventArgs e)
        {

        }

        public static decimal MonthDifference(DateTime _Actual_Delivery_Date, DateTime _Delivery_Date) {
            return Math.Abs((_Actual_Delivery_Date.Month - _Delivery_Date.Month) + 12 * (_Actual_Delivery_Date.Year - _Delivery_Date.Year));
        }

        private void Calculate_Cost_Click(object sender, EventArgs e)
        {

            DateTime _Delivery_Date = Delivery_Date.Value;
            DateTime _Actual_Delivery_Date = Actual_Delivery_Date.Value;

            int Difference_in_days = (_Actual_Delivery_Date - _Delivery_Date).Days;

            if (Difference_in_days < 0) {
                Cost_From_Book.Text = "Please select correctly the dates";
            } else if (Difference_in_days > 0 && Difference_in_days <= 30) {
                Cost_From_Book.Text = "The payment for the rental of the book would be: " + (Difference_in_days * 15) + " MXN";
            } else if (Difference_in_days > 31 && Difference_in_days <= 365) {
                Cost_From_Book.Text = "The payment for the rental of the book would be: " + (MonthDifference(_Actual_Delivery_Date, _Delivery_Date) * 500) + " MXN";
            } else if (Difference_in_days > 365) {
                Cost_From_Book.Text = "The payment for the rental of the book would be: 10,000 MXN";
            }

        }
    }
}
