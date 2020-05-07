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
using System.Data.SqlClient;
using System.Xml;

namespace retireCalc
{
    public partial class UserControl1: UserControl
    {
        
        //variables
        private static double currentSaving;
        private static double monthlySaving;
        private static double startYear;
        private static double retireYear;
        private static double interest = 1.04;
        private static double yearDifference;
        private static double salaryIn;


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

        public double sal
        {
            get { return salaryIn;}
            set { salaryIn = value; }
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
        salaryIn = Convert.ToDouble(salary.Text);
        yearDifference= Convert.ToDouble(retireAge.Text) - Convert.ToDouble(age.Text);



        calculations invested = new calculations();
            //Will print in text box the invested amount
            initialAmount.Text = invested.Total().ToString();
            //Will print the total amount at retirement 
            totalAmount.Text = invested.Total(mSave, cSave, years, interest).ToString();

            //Creaing waypoints for graph.
            graph graphRetirement = new graph();


            startYear = Convert.ToDouble(age.Text);
            retireYear =Convert.ToDouble(retireAge.Text);

            

            //Created max/minimum values x axis.
            chartGraphic.ChartAreas[0].AxisX.Minimum = startYear;
            chartGraphic.ChartAreas[0].AxisX.Maximum = retireYear;

            //Created max/minimum values Y axis.
            chartGraphic.ChartAreas[0].AxisY.Minimum = currentSaving;
            
            //creates the starting point for the 
            this.chartGraphic.Series["Retirement"].Points.AddXY(startYear, currentSaving);
            double count = invested.Total(mSave, cSave, years, interest);
            double countInvest = invested.Total();
            double rInterval=0;
            double tInterval = 0;

            //Will create the x,and y values
            for (double i = 0; i < yearDifference; i++)
            { 
                this.chartGraphic.Series["Retirement"].Points.AddXY((startYear + i), graphRetirement.TotalChart(count, rInterval,(yearDifference -i)));
                rInterval = graphRetirement.TotalChart(count, rInterval, (yearDifference - i));

                this.chartGraphic.Series["Investment"].Points.AddXY((startYear + i), graphRetirement.TotalChart(countInvest, tInterval, (yearDifference - i)));
                tInterval = graphRetirement.TotalChart(countInvest, tInterval, (yearDifference - i));
            }
            chartGraphic.ChartAreas[0].AxisY.Maximum = count;



        }

        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            //creates text box that will not be able to put anything non integer as inputs.
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false
                && (e.KeyChar == '.' ? salary.Text.Contains(".") == true : true))
                e.Handled = true;
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            //resets values.
            Utilities.ResetAllControls(this);
            //resets graph series
            this.chartGraphic.Series["Retirement"].Points.Clear();
            this.chartGraphic.Series["Investment"].Points.Clear();
        }

        private void salaryCalculate_Click(object sender, EventArgs e)
        {
            //creates dataset for display;
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"C:\Users\kwon ji\Desktop\retireCalc\Tables\jobOutlook2.xml");
            careerOptions.DataSource = dataSet.Tables[0];

            DataSet dataSet2 = new DataSet();
            dataSet2.ReadXml(@"C:\Users\kwon ji\Desktop\retireCalc\Tables\rent2.xml");
            livingOption.DataSource = dataSet2.Tables[0];
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

    //class to get graphing information for Y axis
    class graph : calculations
    {
     //creates a method to plot the yAxis for the total Investment.
        public double TotalChart(double count, double yInt, double i)
        {
            if (  yInt <= count)
            {
                yInt =count /(i);
               
            }
            return yInt;

        }

    }
    //Created class to reset all values for next attempt.
    public class Utilities
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }

    }

}

