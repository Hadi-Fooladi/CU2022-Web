using System.Linq;
using SQLite;

namespace UserManagement
{
    public class Database
    {
        public Database(string path)
        {
            _con = new SQLiteConnection(path);
            _con.CreateTable<User>();
        }

        private SQLiteConnection _con;

        public User Find(string name) => _con.Table<User>()
            .FirstOrDefault(u => u.Name == name);

        public void Add(User user)
        {
            _con.Insert(user);
        }
    }
}
