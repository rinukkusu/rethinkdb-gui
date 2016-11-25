using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rethinkdb_gui.Configuration;
using rethinkdb_gui.Misc;
using RethinkDb.Driver;
using RethinkDb.Driver.Net;

namespace rethinkdb_gui
{
	public partial class frmMain : Form
	{
		private static RethinkDB R = RethinkDB.R;
		private RethinkHelper _rHelper;
		private IConnection _connection;

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			var assemblyInfo = Assembly.GetExecutingAssembly().GetName();
			Text = $"{assemblyInfo.Name} {assemblyInfo.Version.ToString(3)}";

			if (Config.Get() == null) 
				Application.Exit();

			Task.Run(() =>
			{
				_connection = R.Connection()
					.Hostname(Config.Get().Host)
					.Port(Config.Get().Port)
					.User(Config.Get().Username, Config.Get().Password)
					.Connect();

				_rHelper = new RethinkHelper(_connection);

				FillTreeWithDatabases();
			});
		}

		private void FillTreeWithDatabases()
		{
			Task.Run(() =>
			{
				List<string> databases = _rHelper.GetAllDatabases().Result;

				foreach (var database in databases)
				{
					BeginInvoke(new Action(() =>
					{
						treeDatabases.Nodes.Add(database, database, 0);
					}));					
				}
			});
		}

		private void FillNodeWithTables(TreeNode node)
		{
			Task.Run(() =>
			{
				List<string> tables = _rHelper.GetAllTables(node.Text).Result;

				foreach (var table in tables)
				{
					BeginInvoke(new Action(() =>
					{
						node.Nodes.Add(table, table, 1);
					}));
				}

				BeginInvoke(new Action(node.Expand));
			});
		}

		private void treeDatabases_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Node.GetNodeCount(false) == 0)
			{
				FillNodeWithTables(e.Node);
			}
		}

		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Config.Get().ShowConfigForm();
		}
	}
}
