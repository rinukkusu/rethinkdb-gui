using System;
using System.IO;
using Newtonsoft.Json;
using RethinkDb.Driver.Net.Clustering;

namespace rethinkdb_gui.Configuration
{
	public class Config
	{
		private const string SETTINGS_PATH = "./settings.json";

		public string Host { get; set; }
		public int Port { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }

		private static Config _instance;
		public static Config Get() 
		{
			if (_instance != null)
				return _instance;

			_instance = Load();
			if (_instance == null)
				return null;

			if (String.IsNullOrEmpty(_instance.Host))
			{
				_instance = CreateFromForm(_instance.Host,
					_instance.Port,
					_instance.Username,
					_instance.Password
				);

				if (_instance == null)
					return null;

				_instance.Save();
			}

			return _instance;
		}

		private static Config CreateFromForm(string hostname = "", int port = 28015,
			string username = "", string password = "")
		{
			ConfigForm frmConfig = new ConfigForm(hostname, port, username, password);
			frmConfig.ShowDialog();

			if (!frmConfig.SavePressed)
				return null;

			return new Config()
			{
				Host = frmConfig.Hostname,
				Port = frmConfig.Port,
				Username = frmConfig.Username,
				Password = frmConfig.Password
			};
		}

		public void ShowConfigForm()
		{
			var newInstance = CreateFromForm(Host, Port, Username, Password);
			if (newInstance == null)
				return;

			_instance = newInstance;
			_instance.Save();
		}

		public static Config Load(string settingsPath = SETTINGS_PATH)
		{
			if (!File.Exists(settingsPath))
			{
				var newInstance = CreateFromForm();
				if (newInstance == null)
					return null;

				newInstance.Save();
			}

			string settingsContent = File.ReadAllText(settingsPath);
			return JsonConvert.DeserializeObject<Config>(settingsContent);
		}

		public void Save(string settingsPath = SETTINGS_PATH)
		{
			string settingsContent = JsonConvert.SerializeObject(this);
			File.WriteAllText(settingsPath, settingsContent);
		}
	}
}