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
        private static double currentSaving;
        private static double monthlySaving;
        private static double interest = 1.07;
        private static double yearDifference;


        public double years
        {
            //gets and sets years as the difference between the retirement age and the current age. via encapsulation.
            get { return yearDifference; }
            set { yearDifference = value; }

        }

        //encapsulation to find the total monthly saving rate
        public double mSave
        {
            get { return monthlySaving; }
            set { monthlySaving = value; }
        }
        //encapsulation to find the the current amount saved.
        public double cSave
        {
            get { return currentSaving; }
            set { currentSaving = value; }

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
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false &&
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

        private void calculate_Click(object sender, EventArgs e)
        {
            
         currentSaving = Convert.ToDouble(amountSaved.Text);
        monthlySaving = Convert.ToDouble(monthlySaved.Text);
        yearDifference= Convert.ToDouble(retireAge.Text) - Convert.ToDouble(age.Text);



            calculations invested = new calculations();
            initialAmount.Text = invested.Total().ToString();
            totalAmount.Text = invested.Total(mSave, cSave, years, interest).ToString();
            
        }

       
    
    }
    //class to get calculations for no compound interest, and total retirement.
    class calculations : UserControl1
    {
        UserControl1 oc = new UserControl1();
        double monthly;
        double current;
        double year;

        
        public double Total()
        {
            monthly = this.mSave;
            current = this.cSave;
            year = this.years;
            double t = (((this.mSave*12)*this.years)+  this.cSave);
            return t;
        }
        public double Total(double mSave,double cSave,double years,double var)
        {
            double counter = 0;
            for(int i = 0; i<years;i++)
            {
                counter = counter + (((mSave * 12) + cSave) * var);
            }
            return counter;
        }







    }
}
