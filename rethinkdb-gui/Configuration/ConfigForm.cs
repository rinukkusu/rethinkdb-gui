using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rethinkdb_gui.Properties;

namespace rethinkdb_gui.Configuration
{
	public partial class ConfigForm : Form
	{
		public bool SavePressed = false;
		public string Hostname { get; private set; }
		public int Port { get; private set; }
		public string Username { get; private set; }
		public string Password { get; private set; }

		public ConfigForm(string hostname = "", int port = 28015, 
			string username = "", string password = "")
		{
			InitializeComponent();

			txtHostname.Text = hostname;
			txtUsername.Text = username;
			txtPassword.Text = password;
			numPort.Value = port;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Hostname = txtHostname.Text;
			Username = txtUsername.Text;
			Password = txtPassword.Text;
			Port = (int) numPort.Value;

			if (String.IsNullOrEmpty(Hostname))
			{
				MessageBox.Show(Resources.ConfigForm_btnSave_Click_Please_enter_a_valid_Hostname);
			}
			else
			{
				SavePressed = true;
				Close();
			}
		}
	}
}
