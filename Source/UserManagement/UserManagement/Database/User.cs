using SQLite;
using System;

namespace UserManagement
{
    public class User
    {
        [PrimaryKey]
        public string Name { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}
