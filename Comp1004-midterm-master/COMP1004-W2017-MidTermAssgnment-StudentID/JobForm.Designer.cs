namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    partial class JobForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NextButton = new System.Windows.Forms.Button();
            this.jobGroupBox = new System.Windows.Forms.GroupBox();
            this.RadioButton4 = new System.Windows.Forms.RadioButton();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.healthLabel = new System.Windows.Forms.Label();
            this.healthTextBox = new System.Windows.Forms.TextBox();
            this.jobGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NextButton.Location = new System.Drawing.Point(512, 446);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // jobGroupBox
            // 
            this.jobGroupBox.Controls.Add(this.RadioButton4);
            this.jobGroupBox.Controls.Add(this.RadioButton3);
            this.jobGroupBox.Controls.Add(this.RadioButton2);
            this.jobGroupBox.Controls.Add(this.RadioButton1);
            this.jobGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.jobGroupBox.Location = new System.Drawing.Point(34, 55);
            this.jobGroupBox.Name = "jobGroupBox";
            this.jobGroupBox.Size = new System.Drawing.Size(202, 237);
            this.jobGroupBox.TabIndex = 4;
            this.jobGroupBox.TabStop = false;
            this.jobGroupBox.Text = "Job";
            this.jobGroupBox.Enter += new System.EventHandler(this.jobGroupBox_Enter);
            // 
            // RadioButton4
            // 
            this.RadioButton4.AutoSize = true;
            this.RadioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RadioButton4.Location = new System.Drawing.Point(7, 189);
            this.RadioButton4.Name = "RadioButton4";
            this.RadioButton4.Size = new System.Drawing.Size(77, 28);
            this.RadioButton4.TabIndex = 3;
            this.RadioButton4.Text = "Cultist";
            this.RadioButton4.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RadioButton3.Location = new System.Drawing.Point(6, 136);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(105, 28);
            this.RadioButton3.TabIndex = 2;
            this.RadioButton3.Text = "Magicker";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RadioButton2.Location = new System.Drawing.Point(7, 83);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(85, 28);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.Text = "Rogue";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged_1);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton1.Location = new System.Drawing.Point(7, 32);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(87, 28);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Soldier";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(30, 348);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(104, 20);
            this.healthLabel.TabIndex = 5;
            this.healthLabel.Text = "Health Points";
            // 
            // healthTextBox
            // 
            this.healthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.healthTextBox.Location = new System.Drawing.Point(34, 389);
            this.healthTextBox.Name = "healthTextBox";
            this.healthTextBox.Size = new System.Drawing.Size(552, 26);
            this.healthTextBox.TabIndex = 6;
            // 
            // JobForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.healthTextBox);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.jobGroupBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the Character\'s Job";
            this.jobGroupBox.ResumeLayout(false);
            this.jobGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox jobGroupBox;
        private System.Windows.Forms.RadioButton RadioButton4;
        private System.Windows.Forms.RadioButton RadioButton3;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.TextBox healthTextBox;
    }
}