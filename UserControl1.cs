using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace retireCalc
{
    public partial class UserControl1: UserControl
    {
        //variables

        private int currentAge;
        private int retirementAge;
        private double currentSaving;
        private double monthlySaving;
        private double totalRetirement;
        private double totalI;
        private int yearDifference;

        public int years
        {
            //gets and sets years as the difference between the retirement age and the current age. via encapsulation.
            get
            {
                return yearDifference;
            }
            set
            {
                yearDifference = retirementAge - currentAge;
            }

        }
        //encapsulation to find the total amount of money put into the retirement system without interest.
        public double saved
        {
            get
            {
                return totalI;
            }
            set
            {
                totalI = ((monthlySaving * 12) + currentSaving) * years;
            }
        }
        
        public UserControl1()
        {
            InitializeComponent();
        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            //creates text box that will not be able to put anything non integer as inputs.
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false
                && (e.KeyChar == '.' ? age.Text.Contains(".") == true : true))
                e.Handled = true;
        }

        private void retireAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            //creates text box that will not be able to put anything non integer as inputs.
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false
                && (e.KeyChar == '.' ? retireAge.Text.Contains(".") == true : true))
                e.Handled = true;
        }

        private void amountSaved_KeyPress(object sender, KeyPressEventArgs e)
        {
            //creates text box that will not be able to put anything non integer as inputs.
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false
                && (e.KeyChar == '.' ? amountSaved.Text.Contains(".") == true : true))
                e.Handled = true;
        }

        private void monthlySaved_KeyPress(object sender, KeyPressEventArgs e)
        {
            //creates text box that will not be able to put anything non integer as inputs.
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false
                && (e.KeyChar == '.' ? monthlySaved.Text.Contains(".") == true : true))
                e.Handled = true;
        }
    }
    public class calculations : UserControl1
    {

    }
}
