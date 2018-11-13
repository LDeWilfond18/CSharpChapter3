namespace CarRentalInteractiveGUI
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
            this.txtEnterDays = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.txtEnterMiles = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEnterDays
            // 
            this.txtEnterDays.Location = new System.Drawing.Point(63, 79);
            this.txtEnterDays.Name = "txtEnterDays";
            this.txtEnterDays.Size = new System.Drawing.Size(100, 20);
            this.txtEnterDays.TabIndex = 0;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDays.Location = new System.Drawing.Point(59, 41);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(320, 24);
            this.lblDays.TabIndex = 1;
            this.lblDays.Text = "How many days did you rent the car?";
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMiles.Location = new System.Drawing.Point(59, 113);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(272, 24);
            this.lblMiles.TabIndex = 2;
            this.lblMiles.Text = "How many miles did you drive?";
            // 
            // txtEnterMiles
            // 
            this.txtEnterMiles.Location = new System.Drawing.Point(63, 155);
            this.txtEnterMiles.Name = "txtEnterMiles";
            this.txtEnterMiles.Size = new System.Drawing.Size(100, 20);
            this.txtEnterMiles.TabIndex = 3;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(63, 208);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(100, 23);
            this.btnTotal.TabIndex = 4;
            this.btnTotal.Text = "Print Receipt";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTotal.Location = new System.Drawing.Point(63, 258);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(268, 23);
            this.lblTotal.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtEnterMiles);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtEnterDays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.TextBox txtEnterMiles;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}

