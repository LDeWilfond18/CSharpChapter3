namespace ProjectedRaisesGUI
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
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtEnterSalary = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNewSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblSalary.Location = new System.Drawing.Point(95, 94);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(194, 24);
            this.lblSalary.TabIndex = 0;
            this.lblSalary.Text = "Enter The Salary here";
            // 
            // txtEnterSalary
            // 
            this.txtEnterSalary.Location = new System.Drawing.Point(99, 122);
            this.txtEnterSalary.Name = "txtEnterSalary";
            this.txtEnterSalary.Size = new System.Drawing.Size(190, 20);
            this.txtEnterSalary.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(313, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "Give the raise pls";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNewSalary
            // 
            this.lblNewSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNewSalary.Location = new System.Drawing.Point(466, 122);
            this.lblNewSalary.Name = "lblNewSalary";
            this.lblNewSalary.Size = new System.Drawing.Size(204, 20);
            this.lblNewSalary.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNewSalary);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEnterSalary);
            this.Controls.Add(this.lblSalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtEnterSalary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNewSalary;
    }
}

