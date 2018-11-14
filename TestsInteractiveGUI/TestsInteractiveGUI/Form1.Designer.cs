namespace TestsInteractiveGUI
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
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.txtTest3 = new System.Windows.Forms.TextBox();
            this.txtTest4 = new System.Windows.Forms.TextBox();
            this.txtTest5 = new System.Windows.Forms.TextBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(84, 43);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(100, 20);
            this.txtTest1.TabIndex = 0;
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(190, 43);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(100, 20);
            this.txtTest2.TabIndex = 1;
            // 
            // txtTest3
            // 
            this.txtTest3.Location = new System.Drawing.Point(296, 43);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(100, 20);
            this.txtTest3.TabIndex = 2;
            // 
            // txtTest4
            // 
            this.txtTest4.Location = new System.Drawing.Point(403, 42);
            this.txtTest4.Name = "txtTest4";
            this.txtTest4.Size = new System.Drawing.Size(100, 20);
            this.txtTest4.TabIndex = 3;
            // 
            // txtTest5
            // 
            this.txtTest5.Location = new System.Drawing.Point(510, 42);
            this.txtTest5.Name = "txtTest5";
            this.txtTest5.Size = new System.Drawing.Size(100, 20);
            this.txtTest5.TabIndex = 4;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(84, 84);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(159, 23);
            this.btnAverage.TabIndex = 5;
            this.btnAverage.Text = "Calculate dat average numba";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(84, 137);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(213, 23);
            this.lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.txtTest5);
            this.Controls.Add(this.txtTest4);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.txtTest1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.TextBox txtTest3;
        private System.Windows.Forms.TextBox txtTest4;
        private System.Windows.Forms.TextBox txtTest5;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblResult;
    }
}

