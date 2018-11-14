namespace EggsInteractiveGUI
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
            this.txtChick1 = new System.Windows.Forms.TextBox();
            this.txtChick4 = new System.Windows.Forms.TextBox();
            this.txtChick2 = new System.Windows.Forms.TextBox();
            this.txtChick5 = new System.Windows.Forms.TextBox();
            this.txtChick3 = new System.Windows.Forms.TextBox();
            this.lblEnterEggs = new System.Windows.Forms.Label();
            this.btnCalculateEggs = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtChick1
            // 
            this.txtChick1.Location = new System.Drawing.Point(176, 97);
            this.txtChick1.Name = "txtChick1";
            this.txtChick1.Size = new System.Drawing.Size(100, 20);
            this.txtChick1.TabIndex = 0;
            // 
            // txtChick4
            // 
            this.txtChick4.Location = new System.Drawing.Point(253, 155);
            this.txtChick4.Name = "txtChick4";
            this.txtChick4.Size = new System.Drawing.Size(100, 20);
            this.txtChick4.TabIndex = 1;
            // 
            // txtChick2
            // 
            this.txtChick2.Location = new System.Drawing.Point(325, 97);
            this.txtChick2.Name = "txtChick2";
            this.txtChick2.Size = new System.Drawing.Size(100, 20);
            this.txtChick2.TabIndex = 2;
            // 
            // txtChick5
            // 
            this.txtChick5.Location = new System.Drawing.Point(397, 155);
            this.txtChick5.Name = "txtChick5";
            this.txtChick5.Size = new System.Drawing.Size(100, 20);
            this.txtChick5.TabIndex = 3;
            // 
            // txtChick3
            // 
            this.txtChick3.Location = new System.Drawing.Point(477, 97);
            this.txtChick3.Name = "txtChick3";
            this.txtChick3.Size = new System.Drawing.Size(100, 20);
            this.txtChick3.TabIndex = 4;
            // 
            // lblEnterEggs
            // 
            this.lblEnterEggs.AutoSize = true;
            this.lblEnterEggs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEnterEggs.Location = new System.Drawing.Point(249, 44);
            this.lblEnterEggs.Name = "lblEnterEggs";
            this.lblEnterEggs.Size = new System.Drawing.Size(248, 24);
            this.lblEnterEggs.TabIndex = 5;
            this.lblEnterEggs.Text = "Enter Eggs for each chicken";
            // 
            // btnCalculateEggs
            // 
            this.btnCalculateEggs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCalculateEggs.Location = new System.Drawing.Point(286, 205);
            this.btnCalculateEggs.Name = "btnCalculateEggs";
            this.btnCalculateEggs.Size = new System.Drawing.Size(191, 42);
            this.btnCalculateEggs.TabIndex = 6;
            this.btnCalculateEggs.Text = "Click to calculate";
            this.btnCalculateEggs.UseVisualStyleBackColor = true;
            this.btnCalculateEggs.Click += new System.EventHandler(this.btnCalculateEggs_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(283, 288);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(194, 29);
            this.lblOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCalculateEggs);
            this.Controls.Add(this.lblEnterEggs);
            this.Controls.Add(this.txtChick3);
            this.Controls.Add(this.txtChick5);
            this.Controls.Add(this.txtChick2);
            this.Controls.Add(this.txtChick4);
            this.Controls.Add(this.txtChick1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChick1;
        private System.Windows.Forms.TextBox txtChick4;
        private System.Windows.Forms.TextBox txtChick2;
        private System.Windows.Forms.TextBox txtChick5;
        private System.Windows.Forms.TextBox txtChick3;
        private System.Windows.Forms.Label lblEnterEggs;
        private System.Windows.Forms.Button btnCalculateEggs;
        private System.Windows.Forms.Label lblOutput;
    }
}

