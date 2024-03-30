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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActivate = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSignature = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTIN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDeposit = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
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
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(184, 219);
            this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(179, 29);
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
            this.label1.Location = new System.Drawing.Point(69, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date Of Birth  :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.Transparent;
            this.txtFullName.BorderRadius = 13;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.Parent = this.txtFullName;
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.FocusedState.Parent = this.txtFullName;
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.HoverState.Parent = this.txtFullName;
            this.txtFullName.Location = new System.Drawing.Point(87, 138);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFullName.PlaceholderText = "Full Name";
            this.txtFullName.SelectedText = "";
            this.txtFullName.ShadowDecoration.Parent = this.txtFullName;
            this.txtFullName.Size = new System.Drawing.Size(507, 28);
            this.txtFullName.TabIndex = 37;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BorderRadius = 13;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(87, 174);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAddress.PlaceholderText = "Residential Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(507, 28);
            this.txtAddress.TabIndex = 38;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.txtPhoneNo.BorderRadius = 13;
            this.txtPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNo.DefaultText = "";
            this.txtPhoneNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNo.DisabledState.Parent = this.txtPhoneNo;
            this.txtPhoneNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNo.FocusedState.Parent = this.txtPhoneNo;
            this.txtPhoneNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNo.HoverState.Parent = this.txtPhoneNo;
            this.txtPhoneNo.Location = new System.Drawing.Point(370, 219);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.PasswordChar = '\0';
            this.txtPhoneNo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPhoneNo.PlaceholderText = "Phone Number";
            this.txtPhoneNo.SelectedText = "";
            this.txtPhoneNo.ShadowDecoration.Parent = this.txtPhoneNo;
            this.txtPhoneNo.Size = new System.Drawing.Size(224, 28);
            this.txtPhoneNo.TabIndex = 39;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderRadius = 13;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(87, 267);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtEmail.PlaceholderText = "Email Address";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(507, 28);
            this.txtEmail.TabIndex = 40;
            // 
            // txtTIN
            // 
            this.txtTIN.BackColor = System.Drawing.Color.Transparent;
            this.txtTIN.BorderRadius = 13;
            this.txtTIN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTIN.DefaultText = "";
            this.txtTIN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTIN.DisabledState.Parent = this.txtTIN;
            this.txtTIN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTIN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTIN.FocusedState.Parent = this.txtTIN;
            this.txtTIN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTIN.HoverState.Parent = this.txtTIN;
            this.txtTIN.Location = new System.Drawing.Point(87, 303);
            this.txtTIN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.PasswordChar = '\0';
            this.txtTIN.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTIN.PlaceholderText = "TIN";
            this.txtTIN.SelectedText = "";
            this.txtTIN.ShadowDecoration.Parent = this.txtTIN;
            this.txtTIN.Size = new System.Drawing.Size(224, 28);
            this.txtTIN.TabIndex = 41;
            // 
            // txtDeposit
            // 
            this.txtDeposit.BackColor = System.Drawing.Color.Transparent;
            this.txtDeposit.BorderRadius = 13;
            this.txtDeposit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeposit.DefaultText = "";
            this.txtDeposit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeposit.DisabledState.Parent = this.txtDeposit;
            this.txtDeposit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeposit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeposit.FocusedState.Parent = this.txtDeposit;
            this.txtDeposit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeposit.HoverState.Parent = this.txtDeposit;
            this.txtDeposit.Location = new System.Drawing.Point(370, 303);
            this.txtDeposit.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.PasswordChar = '\0';
            this.txtDeposit.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtDeposit.PlaceholderText = "Deposit Amount";
            this.txtDeposit.SelectedText = "";
            this.txtDeposit.ShadowDecoration.Parent = this.txtDeposit;
            this.txtDeposit.Size = new System.Drawing.Size(224, 28);
            this.txtDeposit.TabIndex = 42;
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
