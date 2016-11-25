using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RethinkDb.Driver;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Net;

namespace rethinkdb_gui
{
	public class RethinkHelper
	{
		private readonly IConnection _connection;
		private static RethinkDB R = RethinkDB.R;
		private Db Db => R.Db(_database);
		private string _database;

		public RethinkHelper(IConnection connection)
		{
			_connection = connection;
		}

		public RethinkHelper WithDb(string database)
		{
			_database = database;
			return this;
		}

		public async Task<List<string>> GetAllDatabases()
		{
			return await R.DbList().RunAsync<List<string>>(_connection);
		}

		public async Task<List<string>> GetAllTables(string database)
		{
			return await Db.TableList().RunAsync<List<string>>(_connection);
		}

		public async Task<Cursor<JObject>> GetDocuments(string table, int limit = 20)
		{
			return await Db.Table(table).GetAll().RunCursorAsync<JObject>(_connection);
		}
	}
}