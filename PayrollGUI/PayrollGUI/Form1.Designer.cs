namespace PayrollGUI
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
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblEnterSSN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEnterName.Location = new System.Drawing.Point(47, 22);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(155, 24);
            this.lblEnterName.TabIndex = 0;
            this.lblEnterName.Text = "Enter your name:";
            // 
            // lblEnterSSN
            // 
            this.lblEnterSSN.AutoSize = true;
            this.lblEnterSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEnterSSN.Location = new System.Drawing.Point(47, 69);
            this.lblEnterSSN.Name = "lblEnterSSN";
            this.lblEnterSSN.Size = new System.Drawing.Size(145, 24);
            this.lblEnterSSN.TabIndex = 1;
            this.lblEnterSSN.Text = "Enter your SSN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(47, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter pay rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(47, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter hours:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtName.Location = new System.Drawing.Point(209, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 29);
            this.txtName.TabIndex = 0;
            // 
            // txtSSN
            // 
            this.txtSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSSN.Location = new System.Drawing.Point(209, 69);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(100, 29);
            this.txtSSN.TabIndex = 1;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPayRate.Location = new System.Drawing.Point(209, 112);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(100, 29);
            this.txtPayRate.TabIndex = 2;
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtHours.Location = new System.Drawing.Point(209, 157);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 29);
            this.txtHours.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnCalculate.Location = new System.Drawing.Point(410, 74);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(206, 97);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "yah yeet";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(51, 231);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(407, 210);
            this.lblResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtPayRate);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnterSSN);
            this.Controls.Add(this.lblEnterName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Label lblEnterSSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}

