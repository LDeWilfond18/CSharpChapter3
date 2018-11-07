namespace MilesToKilometers
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
            this.lblEnterMiles = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.lblKilometers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterMiles
            // 
            this.lblEnterMiles.AutoSize = true;
            this.lblEnterMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEnterMiles.Location = new System.Drawing.Point(99, 55);
            this.lblEnterMiles.Name = "lblEnterMiles";
            this.lblEnterMiles.Size = new System.Drawing.Size(161, 24);
            this.lblEnterMiles.TabIndex = 0;
            this.lblEnterMiles.Text = "Enter Miles Below";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.LawnGreen;
            this.btnConvert.Location = new System.Drawing.Point(103, 162);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(103, 98);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(157, 20);
            this.txtMiles.TabIndex = 3;
            // 
            // lblKilometers
            // 
            this.lblKilometers.Location = new System.Drawing.Point(103, 217);
            this.lblKilometers.Name = "lblKilometers";
            this.lblKilometers.Size = new System.Drawing.Size(188, 63);
            this.lblKilometers.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKilometers);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblEnterMiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterMiles;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Label lblKilometers;
    }
}

