namespace rethinkdb_gui.Configuration
{
	partial class ConfigForm
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
			this.lblHostname = new System.Windows.Forms.Label();
			this.txtHostname = new System.Windows.Forms.TextBox();
			this.lblPort = new System.Windows.Forms.Label();
			this.numPort = new System.Windows.Forms.NumericUpDown();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
			this.SuspendLayout();
			// 
			// lblHostname
			// 
			this.lblHostname.AutoSize = true;
			this.lblHostname.Location = new System.Drawing.Point(12, 18);
			this.lblHostname.Name = "lblHostname";
			this.lblHostname.Size = new System.Drawing.Size(58, 13);
			this.lblHostname.TabIndex = 0;
			this.lblHostname.Text = "Hostname:";
			// 
			// txtHostname
			// 
			this.txtHostname.Location = new System.Drawing.Point(15, 34);
			this.txtHostname.Name = "txtHostname";
			this.txtHostname.Size = new System.Drawing.Size(123, 20);
			this.txtHostname.TabIndex = 1;
			// 
			// lblPort
			// 
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(141, 18);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(29, 13);
			this.lblPort.TabIndex = 2;
			this.lblPort.Text = "Port:";
			// 
			// numPort
			// 
			this.numPort.Location = new System.Drawing.Point(144, 34);
			this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numPort.Name = "numPort";
			this.numPort.Size = new System.Drawing.Size(58, 20);
			this.numPort.TabIndex = 3;
			this.numPort.Value = new decimal(new int[] {
            28015,
            0,
            0,
            0});
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(15, 73);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(187, 20);
			this.txtUsername.TabIndex = 5;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(12, 57);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(58, 13);
			this.lblUsername.TabIndex = 4;
			this.lblUsername.Text = "Username:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(15, 112);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(187, 20);
			this.txtPassword.TabIndex = 7;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(12, 96);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(56, 13);
			this.lblPassword.TabIndex = 6;
			this.lblPassword.Text = "Password:";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(42, 147);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(131, 23);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Save and Connect";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 182);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.numPort);
			this.Controls.Add(this.lblPort);
			this.Controls.Add(this.txtHostname);
			this.Controls.Add(this.lblHostname);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "frmConfig";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Configuration";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHostname;
		private System.Windows.Forms.TextBox txtHostname;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.NumericUpDown numPort;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnSave;
	}
}