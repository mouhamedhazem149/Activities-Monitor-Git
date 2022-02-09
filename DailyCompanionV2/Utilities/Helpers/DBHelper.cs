using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace DailyCompanionV2.Utilities
{
    public static class DBHelper
	{
		public static T Execute<T>(string sql, IDbConnection alt_connection = null) => SQL_DBH_Lib.Database_Activities.Execute<T, SQLiteConnection>(sql, alt_connection);
		public static async Task<T> Execute_Async<T>(string sql, IDbConnection alt_connection = null) => await SQL_DBH_Lib.Database_Activities.Execute_Async<T, SQLiteConnection>(sql, alt_connection);
		public static List<T> Load_Data<T>(string table_name, List<string> columns_name, List<string> whereClauses = null, IDbConnection alt_connection = null) where T : class => SQL_DBH_Lib.Database_Activities.Load_Data<T, SQLiteConnection>(table_name, columns_name, whereClauses, alt_connection);
		public static T Load_Item<T>(string table_name, List<string> columns_name, List<string> whereClauses = null, IDbConnection alt_connection = null) => SQL_DBH_Lib.Database_Activities.Load_Item<T, SQLiteConnection>(table_name, columns_name, whereClauses, alt_connection);
		public static async Task<T> Load_Item_Async<T>(string table_name, List<string> columns_name, List<string> whereClauses = null, IDbConnection alt_connection = null) => await SQL_DBH_Lib.Database_Activities.Load_Item_Async<T, SQLiteConnection>(table_name, columns_name, whereClauses, alt_connection);
		public static async Task<List<T>> Load_Data_Async<T>(string table_name, List<string> columns_name, List<string> whereClauses = null, int Limit = 0, IDbConnection alt_connection = null) where T : class => await SQL_DBH_Lib.Database_Activities.Load_Data_Async<T, SQLiteConnection>(table_name, columns_name, whereClauses, Limit, alt_connection);
		public static void Update_Database(string table_name, List<string> columns_name, object Model, SQL_DBH_Lib.Database_Activities.historyLog_Func hisFunc = null, string[] HistoryItems = null, string KEY = "id", string OLDVALUE = "id", IDbConnection alt_connection = null) => SQL_DBH_Lib.Database_Activities.Update_Database<SQLiteConnection>(table_name, columns_name, Model, hisFunc, HistoryItems, KEY, OLDVALUE, alt_connection);
		public static int Insert_Database(string table_name, List<string> columns_name, object Model, SQL_DBH_Lib.Database_Activities.historyLog_Func hisFunc = null, string[] HistoryItems = null, IDbConnection alt_connection = null) => SQL_DBH_Lib.Database_Activities.Insert_Database<SQLiteConnection>(table_name, columns_name, Model, hisFunc, HistoryItems, alt_connection, "SELECT last_insert_rowid();");
		public static void Delete_Database(string table_name, object Model, SQL_DBH_Lib.Database_Activities.historyLog_Func hisFunc = null, string[] HistoryItems = null, string KEY = "id", IDbConnection alt_connection = null) => SQL_DBH_Lib.Database_Activities.Delete_Database<SQLiteConnection>(table_name, Model, hisFunc, HistoryItems, KEY, alt_connection);

		public static List<string> tablesCreateString =>
			   new List<string> { createFinances, createSettings, createTodos, createHistory, createNotes };
		
		private static string createFinances = $@"CREATE TABLE `finances` (
	`id`	INTEGER,
	`relatedentity`	TEXT,
	`type`	TEXT,
	`category`	TEXT,
	`value`	REAL,
	`duedate`	TEXT,
	`donedate`	TEXT,
	`notes`	TEXT
);";
		private static string createNotes = $@"CREATE TABLE `notes` (
	`title`	TEXT NOT NULL UNIQUE,
	`note`	BLOB
);";
		private static string createSettings = $@"CREATE TABLE `settings` (
	`mainpassword`	TEXT,
	`serialnumber`	TEXT,
	`webpage`	TEXT,
	`phone`	TEXT,
	`email`	TEXT,
	`address`	TEXT,
	`name`	TEXT
);
";
		private static string createTodos = $@"CREATE TABLE `todos` (
	`id`	INTEGER NOT NULL UNIQUE,
	`category`	TEXT,
	`duefrom`	TEXT NOT NULL,
	`dueto`	TEXT NOT NULL,
	`duedate`	TEXT NOT NULL,
	`donedate`	REAL,
	`notes`	TEXT NOT NULL DEFAULT 'لا يوجد ملاحظات',
	`addeddate`	TEXT,
	`duration`	INTEGER,
	PRIMARY KEY(`id` AUTOINCREMENT)
);
";
		private static string createHistory = $@"CREATE TABLE `history` (
	`id`	INTEGER NOT NULL UNIQUE,
	`tableaffected`	TEXT,
	`operation`	TEXT,
	`add_info`	TEXT,
	`date`	TEXT,
	PRIMARY KEY(`id` AUTOINCREMENT)
);";

	}
}
