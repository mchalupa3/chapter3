namespace GreenvilleRevenueGUI
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
            this.txtNumberOfContestents = new System.Windows.Forms.TextBox();
            this.lblEnterContestents = new System.Windows.Forms.Label();
            this.btnCalculateProfits = new System.Windows.Forms.Button();
            this.lblProfits = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumberOfContestents
            // 
            this.txtNumberOfContestents.Location = new System.Drawing.Point(157, 45);
            this.txtNumberOfContestents.Name = "txtNumberOfContestents";
            this.txtNumberOfContestents.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfContestents.TabIndex = 0;
            // 
            // lblEnterContestents
            // 
            this.lblEnterContestents.AutoSize = true;
            this.lblEnterContestents.Location = new System.Drawing.Point(11, 48);
            this.lblEnterContestents.Name = "lblEnterContestents";
            this.lblEnterContestents.Size = new System.Drawing.Size(140, 13);
            this.lblEnterContestents.TabIndex = 1;
            this.lblEnterContestents.Text = "Number of Contests Entered";
            // 
            // btnCalculateProfits
            // 
            this.btnCalculateProfits.Location = new System.Drawing.Point(80, 150);
            this.btnCalculateProfits.Name = "btnCalculateProfits";
            this.btnCalculateProfits.Size = new System.Drawing.Size(122, 23);
            this.btnCalculateProfits.TabIndex = 2;
            this.btnCalculateProfits.Text = "Click to estimate Revenue";
            this.btnCalculateProfits.UseVisualStyleBackColor = true;
            this.btnCalculateProfits.Click += new System.EventHandler(this.btnCalculateProfits_Click);
            // 
            // lblProfits
            // 
            this.lblProfits.AutoSize = true;
            this.lblProfits.Location = new System.Drawing.Point(12, 110);
            this.lblProfits.Name = "lblProfits";
            this.lblProfits.Size = new System.Drawing.Size(100, 13);
            this.lblProfits.TabIndex = 4;
            this.lblProfits.Text = "Estimated Revenue";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(157, 110);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 23);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblProfits);
            this.Controls.Add(this.btnCalculateProfits);
            this.Controls.Add(this.lblEnterContestents);
            this.Controls.Add(this.txtNumberOfContestents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberOfContestents;
        private System.Windows.Forms.Label lblEnterContestents;
        private System.Windows.Forms.Button btnCalculateProfits;
        private System.Windows.Forms.Label lblProfits;
        private System.Windows.Forms.Label lblResult;
    }
}

