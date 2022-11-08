using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace UserManagement
{
    public class Global
    {
        public static Database Database { get; private set; }

        public static void Init(IWebHostEnvironment env)
        {
            Database = new Database(Path.Combine(env.ContentRootPath, "User.db3"));
        }
    }
}
