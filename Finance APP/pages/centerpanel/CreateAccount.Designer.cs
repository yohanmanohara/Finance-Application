namespace Finance_APP.pages
{
    partial class CreateAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
             this.txtDeposit.TabIndex = 7;
            this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackgroundImage = global::Finance_APP.Properties.Resources.Group_3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(291, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 124);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnActivate
            // 
            this.btnActivate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActivate.BorderRadius = 15;
            this.btnActivate.CheckedState.Parent = this.btnActivate;
            this.btnActivate.CustomImages.Parent = this.btnActivate;
            this.btnActivate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(93)))), ((int)(((byte)(243)))));
            this.btnActivate.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.ForeColor = System.Drawing.Color.White;
            this.btnActivate.HoverState.Parent = this.btnActivate;
            this.btnActivate.Location = new System.Drawing.Point(87, 420);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.ShadowDecoration.Parent = this.btnActivate;
            this.btnActivate.Size = new System.Drawing.Size(111, 37);
            this.btnActivate.TabIndex = 11;
            this.btnActivate.Text = "Activate";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackgroundImage = global::Finance_APP.Properties.Resources.Group_32;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(315, 389);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 231);
            this.panel2.TabIndex = 12;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2DateTimePicker1.BorderRadius = 15;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(198, 212);
            this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(165, 40);
            this.guna2DateTimePicker1.TabIndex = 14;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 3, 28, 10, 3, 13, 731);
            this.guna2DateTimePicker1.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // btnSignature
            // 
            this.btnSignature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSignature.BorderRadius = 15;
            this.btnSignature.CheckedState.Parent = this.btnSignature;
            this.btnSignature.CustomImages.Parent = this.btnSignature;
            this.btnSignature.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(93)))), ((int)(((byte)(243)))));
            this.btnSignature.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignature.ForeColor = System.Drawing.Color.White;
            this.btnSignature.HoverState.Parent = this.btnSignature;
            this.btnSignature.Location = new System.Drawing.Point(87, 357);
            this.btnSignature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSignature.Name = "btnSignature";
            this.btnSignature.ShadowDecoration.Parent = this.btnSignature;
            this.btnSignature.Size = new System.Drawing.Size(224, 37);
            this.btnSignature.TabIndex = 15;
            this.btnSignature.Text = "Upload Signature";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date Of Birth  :";
            this.label1.Click += new System.EventHandler(this.label1_Click);

            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtTIN);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignature);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.panel1);

            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtAddress);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateAccount";
            this.Size = new System.Drawing.Size(677, 631);
            this.Tag = "";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnActivate;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button btnSignature;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNo;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtTIN;
        private Guna.UI2.WinForms.Guna2TextBox txtDeposit;
    }
}
