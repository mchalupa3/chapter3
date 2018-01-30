namespace WindowsFormsApplication1
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
            this.txtchicken1Eggs = new System.Windows.Forms.TextBox();
            this.txtchicken2Eggs = new System.Windows.Forms.TextBox();
            this.txtchicken3Eggs = new System.Windows.Forms.TextBox();
            this.txtchicken5Eggs = new System.Windows.Forms.TextBox();
            this.txtchicken4Eggs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtchicken1Eggs
            // 
            this.txtchicken1Eggs.Location = new System.Drawing.Point(32, 45);
            this.txtchicken1Eggs.Name = "txtchicken1Eggs";
            this.txtchicken1Eggs.Size = new System.Drawing.Size(100, 20);
            this.txtchicken1Eggs.TabIndex = 0;
            // 
            // txtchicken2Eggs
            // 
            this.txtchicken2Eggs.Location = new System.Drawing.Point(161, 45);
            this.txtchicken2Eggs.Name = "txtchicken2Eggs";
            this.txtchicken2Eggs.Size = new System.Drawing.Size(100, 20);
            this.txtchicken2Eggs.TabIndex = 1;
            // 
            // txtchicken3Eggs
            // 
            this.txtchicken3Eggs.Location = new System.Drawing.Point(32, 81);
            this.txtchicken3Eggs.Name = "txtchicken3Eggs";
            this.txtchicken3Eggs.Size = new System.Drawing.Size(100, 20);
            this.txtchicken3Eggs.TabIndex = 2;
            // 
            // txtchicken5Eggs
            // 
            this.txtchicken5Eggs.Location = new System.Drawing.Point(32, 121);
            this.txtchicken5Eggs.Name = "txtchicken5Eggs";
            this.txtchicken5Eggs.Size = new System.Drawing.Size(100, 20);
            this.txtchicken5Eggs.TabIndex = 3;
            // 
            // txtchicken4Eggs
            // 
            this.txtchicken4Eggs.Location = new System.Drawing.Point(161, 81);
            this.txtchicken4Eggs.Name = "txtchicken4Eggs";
            this.txtchicken4Eggs.Size = new System.Drawing.Size(100, 20);
            this.txtchicken4Eggs.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Click to calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(32, 221);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtchicken4Eggs);
            this.Controls.Add(this.txtchicken5Eggs);
            this.Controls.Add(this.txtchicken3Eggs);
            this.Controls.Add(this.txtchicken2Eggs);
            this.Controls.Add(this.txtchicken1Eggs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtchicken1Eggs;
        private System.Windows.Forms.TextBox txtchicken2Eggs;
        private System.Windows.Forms.TextBox txtchicken3Eggs;
        private System.Windows.Forms.TextBox txtchicken5Eggs;
        private System.Windows.Forms.TextBox txtchicken4Eggs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
    }
}

