namespace HealthTrackerModule1
{
    partial class Form1
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
            this.lblStepGoal = new System.Windows.Forms.Label();
            this.lblDayPrompt = new System.Windows.Forms.Label();
            this.lblDayCount = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtStepGoal = new System.Windows.Forms.TextBox();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lstDailySteps = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStepGoal
            // 
            this.lblStepGoal.AutoSize = true;
            this.lblStepGoal.Location = new System.Drawing.Point(140, 76);
            this.lblStepGoal.Name = "lblStepGoal";
            this.lblStepGoal.Size = new System.Drawing.Size(342, 32);
            this.lblStepGoal.TabIndex = 0;
            this.lblStepGoal.Text = "Enter your daily step goal:";
            // 
            // lblDayPrompt
            // 
            this.lblDayPrompt.AutoSize = true;
            this.lblDayPrompt.Location = new System.Drawing.Point(140, 183);
            this.lblDayPrompt.Name = "lblDayPrompt";
            this.lblDayPrompt.Size = new System.Drawing.Size(245, 32);
            this.lblDayPrompt.TabIndex = 1;
            this.lblDayPrompt.Text = "Enter steps Day 1:";
            // 
            // lblDayCount
            // 
            this.lblDayCount.AutoSize = true;
            this.lblDayCount.Location = new System.Drawing.Point(140, 306);
            this.lblDayCount.Name = "lblDayCount";
            this.lblDayCount.Size = new System.Drawing.Size(141, 32);
            this.lblDayCount.TabIndex = 2;
            this.lblDayCount.Text = "Day 1 of 7";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(140, 432);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(109, 32);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Results";
            // 
            // txtStepGoal
            // 
            this.txtStepGoal.Location = new System.Drawing.Point(554, 76);
            this.txtStepGoal.Name = "txtStepGoal";
            this.txtStepGoal.Size = new System.Drawing.Size(338, 38);
            this.txtStepGoal.TabIndex = 4;
            // 
            // txtSteps
            // 
            this.txtSteps.Location = new System.Drawing.Point(554, 177);
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(338, 38);
            this.txtSteps.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 77);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Steps";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddSteps_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(774, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 77);
            this.button2.TabIndex = 7;
            this.button2.Text = "Calculate Results";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstDailySteps
            // 
            this.lstDailySteps.FormattingEnabled = true;
            this.lstDailySteps.ItemHeight = 31;
            this.lstDailySteps.Location = new System.Drawing.Point(1110, 76);
            this.lstDailySteps.Name = "lstDailySteps";
            this.lstDailySteps.Size = new System.Drawing.Size(333, 345);
            this.lstDailySteps.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 630);
            this.Controls.Add(this.lstDailySteps);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSteps);
            this.Controls.Add(this.txtStepGoal);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblDayCount);
            this.Controls.Add(this.lblDayPrompt);
            this.Controls.Add(this.lblStepGoal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStepGoal;
        private System.Windows.Forms.Label lblDayPrompt;
        private System.Windows.Forms.Label lblDayCount;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtStepGoal;
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstDailySteps;
    }
}

