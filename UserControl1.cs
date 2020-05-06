using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.CompilerServices;

namespace retireCalc
{
    public partial class UserControl1: UserControl
    {
        
        //variables
        private static double currentSaving;
        private static double monthlySaving;
        private static double interest = 1.04;
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

        private void calculate_Click(object sender, EventArgs e)
        {
            
        currentSaving = Convert.ToDouble(amountSaved.Text);
        monthlySaving = Convert.ToDouble(monthlySaved.Text);
        yearDifference= Convert.ToDouble(retireAge.Text) - Convert.ToDouble(age.Text);



            calculations invested = new calculations();
            //Will print in text box the invested amount
            initialAmount.Text = invested.Total().ToString();
            //Will print the total amount at retirement 
            totalAmount.Text = invested.Total(mSave, cSave, years, interest).ToString();

            //Creaing waypoints for graph.
            graph graphRetirement = new graph();

            this.chartGraphic.Series["money"].Points.AddXY(0, 0);

            for (double i = 0; i < yearDifference; i++)
            {
                
                this.chartGraphic.Series["money"].Points.AddXY(i, graphRetirement.TotalChart(i, count));
            }

        }

       
    
    }
    //class to get calculations for no compound interest, and total retirement. via inheritence.
    class calculations : UserControl1
    {
         public static double monthly;
         public static double current;
         public static double year;
         private static double variable;

        public double var
        {
            get { return variable; }
            set { variable = value; }
        }

        //Will get amount invested into your retirement
        public double Total()
        {
            monthly = this.mSave;
            current = this.cSave;
            year = this.years;

            double t = (((this.mSave*12)*this.years)+  this.cSave);
            return t;
        }
        //Will give the total amount at time of your retirement.
        private static double counter;
        public double Total(double mSave,double cSave,double years,double var)
        {
            variable = var;
            counter=0;
            mSave = mSave * 12;
            for(int i = 0; i<years;i++)
            {
                counter = counter + ((mSave + cSave) * variable);
            }
            return counter;
        }
       
    }

    //class to get graphing information
    class graph : calculations
    {
        private static double counter;
        
        public double TotalChart(double i, double counter)
        {
            mSave = mSave * 12;
            counter = counter + ((monthly + cSave) * var);
            return counter;

        }

    }
}
