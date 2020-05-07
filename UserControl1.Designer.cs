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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.chartGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Reset = new System.Windows.Forms.Button();
            this.careerOptions = new System.Windows.Forms.DataGridView();
            this.livingOption = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livingOption)).BeginInit();
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
            this.calculate.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(1060, 163);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
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
            this.TotalRetire.Text = "Amount at Retirement:";
            // 
            // chartGraphic
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraphic.ChartAreas.Add(chartArea1);
            legend1.Name = "legend1";
            legend1.Title = "legend";
            this.chartGraphic.Legends.Add(legend1);
            this.chartGraphic.Location = new System.Drawing.Point(4, 4);
            this.chartGraphic.Margin = new System.Windows.Forms.Padding(4);
            this.chartGraphic.Name = "chartGraphic";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "legend1";
            series1.LegendText = "Retirement over Time";
            series1.Name = "Retirement";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "legend1";
            series2.LegendText = "Investment over Time";
            series2.Name = "Investment";
            this.chartGraphic.Series.Add(series1);
            this.chartGraphic.Series.Add(series2);
            this.chartGraphic.Size = new System.Drawing.Size(867, 298);
            this.chartGraphic.TabIndex = 13;
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(1060, 279);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 14;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // careerOptions
            // 
            this.careerOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.careerOptions.Location = new System.Drawing.Point(332, 321);
            this.careerOptions.Name = "careerOptions";
            this.careerOptions.RowHeadersWidth = 51;
            this.careerOptions.RowTemplate.Height = 24;
            this.careerOptions.Size = new System.Drawing.Size(246, 162);
            this.careerOptions.TabIndex = 15;
            // 
            // livingOption
            // 
            this.livingOption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livingOption.Location = new System.Drawing.Point(631, 321);
            this.livingOption.Name = "livingOption";
            this.livingOption.RowHeadersWidth = 51;
            this.livingOption.RowTemplate.Height = 24;
            this.livingOption.Size = new System.Drawing.Size(240, 162);
            this.livingOption.TabIndex = 16;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.livingOption);
            this.Controls.Add(this.careerOptions);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.chartGraphic);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careerOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livingOption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox retireAge;
        private System.Windows.Forms.Label retireAgeLabel;
        private System.Windows.Forms.Label CurrentSaving;
        private System.Windows.Forms.TextBox monthlySaved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox initialAmount;
        private System.Windows.Forms.Label AmountInvested;
        private System.Windows.Forms.TextBox totalAmount;
        private System.Windows.Forms.Label TotalRetire;
        private System.Windows.Forms.TextBox amountSaved;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphic;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.DataGridView careerOptions;
        private System.Windows.Forms.DataGridView livingOption;
    }
}
