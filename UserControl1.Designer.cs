namespace retireCalc
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.age = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.retireAge = new System.Windows.Forms.TextBox();
            this.retireAgeLabel = new System.Windows.Forms.Label();
            this.amountSaved = new System.Windows.Forms.TextBox();
            this.CurrentSaving = new System.Windows.Forms.Label();
            this.monthlySaved = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.initialAmount = new System.Windows.Forms.TextBox();
            this.AmountInvested = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.TextBox();
            this.TotalRetire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(1035, 39);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 22);
            this.age.TabIndex = 0;
            this.age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_KeyPress);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ageLabel.Location = new System.Drawing.Point(927, 44);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(88, 17);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "Current Age:";
            // 
            // retireAge
            // 
            this.retireAge.Location = new System.Drawing.Point(1035, 67);
            this.retireAge.Name = "retireAge";
            this.retireAge.Size = new System.Drawing.Size(100, 22);
            this.retireAge.TabIndex = 2;
            this.retireAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.retireAge_KeyPress);
            // 
            // retireAgeLabel
            // 
            this.retireAgeLabel.AutoSize = true;
            this.retireAgeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.retireAgeLabel.Location = new System.Drawing.Point(905, 70);
            this.retireAgeLabel.Name = "retireAgeLabel";
            this.retireAgeLabel.Size = new System.Drawing.Size(110, 17);
            this.retireAgeLabel.TabIndex = 3;
            this.retireAgeLabel.Text = "Retirement Age:";
            // 
            // amountSaved
            // 
            this.amountSaved.Location = new System.Drawing.Point(1035, 95);
            this.amountSaved.Name = "amountSaved";
            this.amountSaved.Size = new System.Drawing.Size(100, 22);
            this.amountSaved.TabIndex = 4;
            this.amountSaved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountSaved_KeyPress);
            // 
            // CurrentSaving
            // 
            this.CurrentSaving.AutoSize = true;
            this.CurrentSaving.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CurrentSaving.Location = new System.Drawing.Point(911, 95);
            this.CurrentSaving.Name = "CurrentSaving";
            this.CurrentSaving.Size = new System.Drawing.Size(104, 17);
            this.CurrentSaving.TabIndex = 5;
            this.CurrentSaving.Text = "Amount Saved:";
            // 
            // monthlySaved
            // 
            this.monthlySaved.Location = new System.Drawing.Point(1035, 123);
            this.monthlySaved.Name = "monthlySaved";
            this.monthlySaved.Size = new System.Drawing.Size(100, 22);
            this.monthlySaved.TabIndex = 6;
            this.monthlySaved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthlySaved_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(912, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Monthly saved:";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(1035, 166);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            // 
            // initialAmount
            // 
            this.initialAmount.Location = new System.Drawing.Point(1035, 205);
            this.initialAmount.Name = "initialAmount";
            this.initialAmount.ReadOnly = true;
            this.initialAmount.Size = new System.Drawing.Size(100, 22);
            this.initialAmount.TabIndex = 9;
            // 
            // AmountInvested
            // 
            this.AmountInvested.AutoSize = true;
            this.AmountInvested.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AmountInvested.Location = new System.Drawing.Point(905, 205);
            this.AmountInvested.Name = "AmountInvested";
            this.AmountInvested.Size = new System.Drawing.Size(117, 17);
            this.AmountInvested.TabIndex = 10;
            this.AmountInvested.Text = "Amount Invested:";
            // 
            // totalAmount
            // 
            this.totalAmount.Location = new System.Drawing.Point(1035, 233);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            this.totalAmount.Size = new System.Drawing.Size(100, 22);
            this.totalAmount.TabIndex = 11;
            // 
            // TotalRetire
            // 
            this.TotalRetire.AutoSize = true;
            this.TotalRetire.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalRetire.Location = new System.Drawing.Point(877, 236);
            this.TotalRetire.Name = "TotalRetire";
            this.TotalRetire.Size = new System.Drawing.Size(149, 17);
            this.TotalRetire.TabIndex = 12;
            this.TotalRetire.Text = "Amount at Retirement;";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TotalRetire);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.AmountInvested);
            this.Controls.Add(this.initialAmount);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthlySaved);
            this.Controls.Add(this.CurrentSaving);
            this.Controls.Add(this.amountSaved);
            this.Controls.Add(this.retireAgeLabel);
            this.Controls.Add(this.retireAge);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.age);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1165, 486);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox retireAge;
        private System.Windows.Forms.Label retireAgeLabel;
        private System.Windows.Forms.TextBox amountSaved;
        private System.Windows.Forms.Label CurrentSaving;
        private System.Windows.Forms.TextBox monthlySaved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox initialAmount;
        private System.Windows.Forms.Label AmountInvested;
        private System.Windows.Forms.TextBox totalAmount;
        private System.Windows.Forms.Label TotalRetire;
    }
}
