namespace Lab4_8_200_Skelly_Daniel
{
    partial class Lab8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addScore = new System.Windows.Forms.Button();
            this.clearScore = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.txtScoreCount = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average";
            // 
            // addScore
            // 
            this.addScore.Location = new System.Drawing.Point(183, 16);
            this.addScore.Name = "addScore";
            this.addScore.Size = new System.Drawing.Size(81, 23);
            this.addScore.TabIndex = 0;
            this.addScore.Text = "&Add";
            this.addScore.UseVisualStyleBackColor = true;
            this.addScore.Click += new System.EventHandler(this.addScore_Click);
            // 
            // clearScore
            // 
            this.clearScore.Location = new System.Drawing.Point(183, 144);
            this.clearScore.Name = "clearScore";
            this.clearScore.Size = new System.Drawing.Size(81, 23);
            this.clearScore.TabIndex = 1;
            this.clearScore.Text = "Clear Scores";
            this.clearScore.UseVisualStyleBackColor = true;
            this.clearScore.Click += new System.EventHandler(this.clearScore_Click);
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Location = new System.Drawing.Point(183, 178);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(91, 17);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(48, 20);
            this.txtScore.TabIndex = 7;
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Location = new System.Drawing.Point(91, 49);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.ReadOnly = true;
            this.txtScoreTotal.Size = new System.Drawing.Size(48, 20);
            this.txtScoreTotal.TabIndex = 8;
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.Location = new System.Drawing.Point(91, 81);
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.ReadOnly = true;
            this.txtScoreCount.Size = new System.Drawing.Size(48, 20);
            this.txtScoreCount.TabIndex = 9;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(91, 112);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(48, 20);
            this.txtAverage.TabIndex = 10;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(53, 144);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(86, 23);
            this.txtDisplay.TabIndex = 11;
            this.txtDisplay.Text = "Display Scores";
            this.txtDisplay.UseVisualStyleBackColor = true;
            this.txtDisplay.Click += new System.EventHandler(this.txtDisplay_Click);
            // 
            // Lab4
            // 
            this.AcceptButton = this.addScore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(281, 212);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clearScore);
            this.Controls.Add(this.addScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab4";
            this.Text = "C-Sharp Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addScore;
        private System.Windows.Forms.Button clearScore;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.TextBox txtScoreCount;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button txtDisplay;
    }
}

