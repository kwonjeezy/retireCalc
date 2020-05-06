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
        public class calculate: UserControl1
        {
            
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false
                && (e.KeyChar == '.' ? age.Text.Contains(".") == true : true))
                e.Handled = true;
        }

        private void retireAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false
                && (e.KeyChar == '.' ? retireAge.Text.Contains(".") == true : true))
                e.Handled = true;
        }

        private void amountSaved_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false
                && (e.KeyChar == '.' ? amountSaved.Text.Contains(".") == true : true))
                e.Handled = true;
        }

        private void monthlySaved_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false
                && (e.KeyChar == '.' ? monthlySaved.Text.Contains(".") == true : true))
                e.Handled = true;
        }
    }
}
