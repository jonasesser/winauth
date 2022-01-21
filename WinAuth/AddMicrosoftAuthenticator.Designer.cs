namespace WinAuth
{
	partial class AddMicrosoftAuthenticator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMicrosoftAuthenticator));
            this.newAuthenticatorProgress = new System.Windows.Forms.ProgressBar();
            this.codeField = new WinAuth.SecretTextBox();
            this.verifyAuthenticatorButton = new MetroFramework.Controls.MetroButton();
            this.secretCodeField = new MetroFramework.Controls.MetroTextBox();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.label12 = new MetroFramework.Controls.MetroLabel();
            this.nameField = new MetroFramework.Controls.MetroTextBox();
            this.newAuthenticatorTimer = new System.Windows.Forms.Timer(this.components);
            this.htmlPanel1 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.htmlPanel2 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.icon3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.htmlPanel3 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.htmlPanel4 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.htmlPanel6 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.htmlPanel5 = new MetroFramework.Drawing.Html.HtmlPanel();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newAuthenticatorProgress
            // 
            this.newAuthenticatorProgress.Location = new System.Drawing.Point(401, 560);
            this.newAuthenticatorProgress.Maximum = 30;
            this.newAuthenticatorProgress.Minimum = 1;
            this.newAuthenticatorProgress.Name = "newAuthenticatorProgress";
            this.newAuthenticatorProgress.Size = new System.Drawing.Size(158, 8);
            this.newAuthenticatorProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.newAuthenticatorProgress.TabIndex = 9;
            this.newAuthenticatorProgress.Value = 1;
            this.newAuthenticatorProgress.Visible = false;
            this.newAuthenticatorProgress.Click += new System.EventHandler(this.newAuthenticatorProgress_Click);
            // 
            // codeField
            // 
            this.codeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.codeField.Location = new System.Drawing.Point(401, 532);
            this.codeField.Multiline = true;
            this.codeField.Name = "codeField";
            this.codeField.SecretMode = false;
            this.codeField.Size = new System.Drawing.Size(158, 26);
            this.codeField.SpaceOut = 3;
            this.codeField.TabIndex = 8;
            this.codeField.TextChanged += new System.EventHandler(this.codeField_TextChanged);
            // 
            // verifyAuthenticatorButton
            // 
            this.verifyAuthenticatorButton.Location = new System.Drawing.Point(400, 430);
            this.verifyAuthenticatorButton.Name = "verifyAuthenticatorButton";
            this.verifyAuthenticatorButton.Size = new System.Drawing.Size(159, 23);
            this.verifyAuthenticatorButton.TabIndex = 5;
            this.verifyAuthenticatorButton.Text = "Verify Authenticator";
            this.verifyAuthenticatorButton.UseSelectable = true;
            this.verifyAuthenticatorButton.Click += new System.EventHandler(this.verifyAuthenticatorButton_Click);
            // 
            // secretCodeField
            // 
            this.secretCodeField.AllowDrop = true;
            this.secretCodeField.CausesValidation = false;
            this.secretCodeField.Location = new System.Drawing.Point(279, 384);
            this.secretCodeField.MaxLength = 32767;
            this.secretCodeField.Name = "secretCodeField";
            this.secretCodeField.PasswordChar = '\0';
            this.secretCodeField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.secretCodeField.SelectedText = "";
            this.secretCodeField.Size = new System.Drawing.Size(425, 22);
            this.secretCodeField.TabIndex = 4;
            this.secretCodeField.UseSelectable = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(855, 626);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseSelectable = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(936, 626);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Name:";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(77, 70);
            this.nameField.MaxLength = 32767;
            this.nameField.Name = "nameField";
            this.nameField.PasswordChar = '\0';
            this.nameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameField.SelectedText = "";
            this.nameField.Size = new System.Drawing.Size(371, 22);
            this.nameField.TabIndex = 0;
            this.nameField.UseSelectable = true;
            // 
            // newAuthenticatorTimer
            // 
            this.newAuthenticatorTimer.Tick += new System.EventHandler(this.newAuthenticatorTimer_Tick);
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.AutoScroll = true;
            this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(561, 240);
            this.htmlPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlPanel1.Location = new System.Drawing.Point(465, 119);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(561, 263);
            this.htmlPanel1.TabIndex = 14;
            this.htmlPanel1.Text = resources.GetString("htmlPanel1.Text");
            this.htmlPanel1.Click += new System.EventHandler(this.htmlPanel1_Click);
            // 
            // htmlPanel2
            // 
            this.htmlPanel2.AutoScroll = true;
            this.htmlPanel2.AutoScrollMinSize = new System.Drawing.Size(463, 223);
            this.htmlPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlPanel2.Location = new System.Drawing.Point(8, 119);
            this.htmlPanel2.Name = "htmlPanel2";
            this.htmlPanel2.Size = new System.Drawing.Size(463, 243);
            this.htmlPanel2.TabIndex = 15;
            this.htmlPanel2.Text = resources.GetString("htmlPanel2.Text");
            // 
            // icon3
            // 
            this.icon3.Image = global::WinAuth.Properties.Resources.GB;
            this.icon3.Location = new System.Drawing.Point(23, 103);
            this.icon3.Name = "icon3";
            this.icon3.Size = new System.Drawing.Size(26, 21);
            this.icon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon3.TabIndex = 16;
            this.icon3.TabStop = false;
            this.icon3.Tag = "";
            this.icon3.Click += new System.EventHandler(this.icon3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAuth.Properties.Resources.DE;
            this.pictureBox1.Location = new System.Drawing.Point(477, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // htmlPanel3
            // 
            this.htmlPanel3.AutoScroll = true;
            this.htmlPanel3.AutoScrollMinSize = new System.Drawing.Size(524, 17);
            this.htmlPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlPanel3.Location = new System.Drawing.Point(487, 475);
            this.htmlPanel3.Name = "htmlPanel3";
            this.htmlPanel3.Size = new System.Drawing.Size(524, 21);
            this.htmlPanel3.TabIndex = 15;
            this.htmlPanel3.Text = "<div style=\"font-family:verdana;font-size: 10pt;\">9. Klicken Sie auf <b>weiter</b" +
    "><div>";
            // 
            // htmlPanel4
            // 
            this.htmlPanel4.AutoScroll = true;
            this.htmlPanel4.AutoScrollMinSize = new System.Drawing.Size(355, 17);
            this.htmlPanel4.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlPanel4.Location = new System.Drawing.Point(29, 475);
            this.htmlPanel4.Name = "htmlPanel4";
            this.htmlPanel4.Size = new System.Drawing.Size(355, 21);
            this.htmlPanel4.TabIndex = 16;
            this.htmlPanel4.Text = "<div style=\"font-family:verdana;font-size: 10pt;\">9. Click on <b>next</b><div>";
            // 
            // htmlPanel6
            // 
            this.htmlPanel6.AutoScroll = true;
            this.htmlPanel6.AutoScrollMinSize = new System.Drawing.Size(355, 17);
            this.htmlPanel6.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlPanel6.Location = new System.Drawing.Point(29, 503);
            this.htmlPanel6.Name = "htmlPanel6";
            this.htmlPanel6.Size = new System.Drawing.Size(355, 36);
            this.htmlPanel6.TabIndex = 18;
            this.htmlPanel6.Text = "<div style=\"font-family:verdana;font-size: 10pt;\">10. Enter the following code an" +
    "d click on <b>next</b><div>";
            // 
            // htmlPanel5
            // 
            this.htmlPanel5.AutoScrollMinSize = new System.Drawing.Size(524, 17);
            this.htmlPanel5.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlPanel5.Location = new System.Drawing.Point(487, 503);
            this.htmlPanel5.Name = "htmlPanel5";
            this.htmlPanel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.htmlPanel5.Size = new System.Drawing.Size(524, 23);
            this.htmlPanel5.TabIndex = 19;
            this.htmlPanel5.Text = "<div style=\"font-family:verdana;font-size: 10pt;\">10. Geben Sie den folgenden Cod" +
    "e ein und klicken Sie auf <b>weiter</b><div>";
            // 
            // AddMicrosoftAuthenticator
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1034, 672);
            this.Controls.Add(this.htmlPanel5);
            this.Controls.Add(this.htmlPanel6);
            this.Controls.Add(this.htmlPanel4);
            this.Controls.Add(this.htmlPanel3);
            this.Controls.Add(this.icon3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.htmlPanel2);
            this.Controls.Add(this.htmlPanel1);
            this.Controls.Add(this.newAuthenticatorProgress);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.codeField);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.verifyAuthenticatorButton);
            this.Controls.Add(this.secretCodeField);
            this.MaximizeBox = false;
            this.Name = "AddMicrosoftAuthenticator";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Microsoft Authenticator";
            this.Load += new System.EventHandler(this.AddMicrosoftAuthenticator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroButton okButton;
		private MetroFramework.Controls.MetroButton cancelButton;
		private MetroFramework.Controls.MetroTextBox secretCodeField;
		private MetroFramework.Controls.MetroLabel label12;
		private MetroFramework.Controls.MetroTextBox nameField;
		private MetroFramework.Controls.MetroButton verifyAuthenticatorButton;
		private System.Windows.Forms.ProgressBar newAuthenticatorProgress;
		private SecretTextBox codeField;
		private System.Windows.Forms.Timer newAuthenticatorTimer;
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel1;
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel2;
        private System.Windows.Forms.PictureBox icon3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel3;
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel4;
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel6;
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel5;
    }
}