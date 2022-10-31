using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace NoteManager
{
	using DB;

	public static class Global
	{
		public static Database DB { get; private set; }

		public static void Init(IWebHostEnvironment env)
		{
			DB = new Database(Path.Combine(env.ContentRootPath, "DB.db3"));
		}
	}
}
