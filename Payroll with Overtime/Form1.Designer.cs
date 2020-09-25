namespace Payroll_with_Overtime
{
    partial class payrollAmount
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHoursWorked = new System.Windows.Forms.Label();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.labelHourlyPayRate = new System.Windows.Forms.Label();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.GrossPayLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHoursWorked
            // 
            this.labelHoursWorked.AutoSize = true;
            this.labelHoursWorked.Location = new System.Drawing.Point(18, 40);
            this.labelHoursWorked.Name = "labelHoursWorked";
            this.labelHoursWorked.Size = new System.Drawing.Size(84, 15);
            this.labelHoursWorked.TabIndex = 0;
            this.labelHoursWorked.Text = "Hours &worked:";
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(119, 32);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(117, 23);
            this.hoursWorkedTextBox.TabIndex = 1;
            // 
            // labelHourlyPayRate
            // 
            this.labelHourlyPayRate.AutoSize = true;
            this.labelHourlyPayRate.Location = new System.Drawing.Point(11, 74);
            this.labelHourlyPayRate.Name = "labelHourlyPayRate";
            this.labelHourlyPayRate.Size = new System.Drawing.Size(91, 15);
            this.labelHourlyPayRate.TabIndex = 2;
            this.labelHourlyPayRate.Text = "Hourly pay &rate:";
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(119, 66);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(117, 23);
            this.hourlyPayRateTextBox.TabIndex = 3;
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Location = new System.Drawing.Point(44, 107);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(61, 15);
            this.lblGrossPay.TabIndex = 4;
            this.lblGrossPay.Text = "&Gross pay:";
            // 
            // GrossPayLabel
            // 
            this.GrossPayLabel.BackColor = System.Drawing.SystemColors.Control;
            this.GrossPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrossPayLabel.Location = new System.Drawing.Point(119, 105);
            this.GrossPayLabel.Name = "GrossPayLabel";
            this.GrossPayLabel.Size = new System.Drawing.Size(117, 17);
            this.GrossPayLabel.TabIndex = 5;
            this.GrossPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(18, 151);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(78, 42);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Gross &Pay";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(115, 151);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(76, 43);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(213, 151);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(77, 42);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // payrollAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(307, 216);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.GrossPayLabel);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.labelHourlyPayRate);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.labelHoursWorked);
            this.Name = "payrollAmount";
            this.Text = "Payroll with Overtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHoursWorked;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.Label labelHourlyPayRate;
        private System.Windows.Forms.TextBox hourlyPayRateTextBox;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label GrossPayLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

