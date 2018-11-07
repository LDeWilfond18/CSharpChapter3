namespace GUIcalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtinputnumber = new System.Windows.Forms.TextBox();
            this.txtinputnumber2 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultSub = new System.Windows.Forms.Label();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.lblResultMult = new System.Windows.Forms.Label();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.lblResultDiv = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.lblMod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter another number";
            // 
            // txtinputnumber
            // 
            this.txtinputnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtinputnumber.Location = new System.Drawing.Point(244, 12);
            this.txtinputnumber.Name = "txtinputnumber";
            this.txtinputnumber.Size = new System.Drawing.Size(100, 29);
            this.txtinputnumber.TabIndex = 2;
            // 
            // txtinputnumber2
            // 
            this.txtinputnumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtinputnumber2.Location = new System.Drawing.Point(244, 53);
            this.txtinputnumber2.Name = "txtinputnumber2";
            this.txtinputnumber2.Size = new System.Drawing.Size(100, 29);
            this.txtinputnumber2.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAdd.Location = new System.Drawing.Point(37, 143);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 29);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblResult.Location = new System.Drawing.Point(244, 143);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 29);
            this.lblResult.TabIndex = 5;
            // 
            // lblResultSub
            // 
            this.lblResultSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultSub.Location = new System.Drawing.Point(244, 199);
            this.lblResultSub.Name = "lblResultSub";
            this.lblResultSub.Size = new System.Drawing.Size(100, 31);
            this.lblResultSub.TabIndex = 6;
            // 
            // buttonSub
            // 
            this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSub.Location = new System.Drawing.Point(37, 199);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(88, 31);
            this.buttonSub.TabIndex = 7;
            this.buttonSub.Text = "Subtract";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMult.Location = new System.Drawing.Point(471, 143);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(84, 29);
            this.buttonMult.TabIndex = 8;
            this.buttonMult.Text = "Multiply";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // lblResultMult
            // 
            this.lblResultMult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultMult.Location = new System.Drawing.Point(638, 143);
            this.lblResultMult.Name = "lblResultMult";
            this.lblResultMult.Size = new System.Drawing.Size(102, 29);
            this.lblResultMult.TabIndex = 9;
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDiv.Location = new System.Drawing.Point(471, 199);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(84, 31);
            this.buttonDiv.TabIndex = 10;
            this.buttonDiv.Text = "Divide";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // lblResultDiv
            // 
            this.lblResultDiv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblResultDiv.Location = new System.Drawing.Point(638, 199);
            this.lblResultDiv.Name = "lblResultDiv";
            this.lblResultDiv.Size = new System.Drawing.Size(102, 31);
            this.lblResultDiv.TabIndex = 11;
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMod.Location = new System.Drawing.Point(37, 262);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(96, 31);
            this.btnMod.TabIndex = 12;
            this.btnMod.Text = "Modulus";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // lblMod
            // 
            this.lblMod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMod.Location = new System.Drawing.Point(244, 262);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(100, 31);
            this.lblMod.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 457);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.lblResultDiv);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.lblResultMult);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.lblResultSub);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.txtinputnumber2);
            this.Controls.Add(this.txtinputnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtinputnumber;
        private System.Windows.Forms.TextBox txtinputnumber2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultSub;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Label lblResultMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Label lblResultDiv;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label lblMod;
    }
}

