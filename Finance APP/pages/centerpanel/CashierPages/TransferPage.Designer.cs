namespace Finance_APP.pages.centerpanel.CashierPages
{
    partial class TransferPage
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
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchQueryInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BorderRadius = 10;
            this.searchButton.CheckedState.Parent = this.searchButton;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.CustomImages.Parent = this.searchButton;
            this.searchButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(218)))));
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.HoverState.Parent = this.searchButton;
            this.searchButton.Location = new System.Drawing.Point(736, 325);
            this.searchButton.Name = "searchButton";
            this.searchButton.ShadowDecoration.Parent = this.searchButton;
            this.searchButton.Size = new System.Drawing.Size(125, 48);
            this.searchButton.TabIndex = 75;
            this.searchButton.Text = "Search";
            // 
            // searchQueryInput
            // 
            this.searchQueryInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchQueryInput.Animated = true;
            this.searchQueryInput.BorderRadius = 10;
            this.searchQueryInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchQueryInput.DefaultText = "";
            this.searchQueryInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchQueryInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchQueryInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchQueryInput.DisabledState.Parent = this.searchQueryInput;
            this.searchQueryInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchQueryInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchQueryInput.FocusedState.Parent = this.searchQueryInput;
            this.searchQueryInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQueryInput.ForeColor = System.Drawing.Color.Empty;
            this.searchQueryInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchQueryInput.HoverState.Parent = this.searchQueryInput;
            this.searchQueryInput.Location = new System.Drawing.Point(262, 328);
            this.searchQueryInput.Margin = new System.Windows.Forms.Padding(4);
            this.searchQueryInput.Name = "searchQueryInput";
            this.searchQueryInput.Padding = new System.Windows.Forms.Padding(10);
            this.searchQueryInput.PasswordChar = '\0';
            this.searchQueryInput.PlaceholderText = "0912 6730 7120 2940";
            this.searchQueryInput.SelectedText = "";
            this.searchQueryInput.ShadowDecoration.Parent = this.searchQueryInput;
            this.searchQueryInput.Size = new System.Drawing.Size(467, 45);
            this.searchQueryInput.TabIndex = 74;
            this.searchQueryInput.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(106, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 73;
            this.label2.Text = "Account Number";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(392, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 72;
            this.label1.Text = "Search for Account";
            // 
            // TransferPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchQueryInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransferPage";
            this.Size = new System.Drawing.Size(966, 631);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2TextBox searchQueryInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
