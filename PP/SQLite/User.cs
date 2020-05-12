using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PP
{
    class User
    {
        public int id;
        public string password;
        public string name;
        public string surename;
        public string middlename;
        public int rights;
        public bool read_data()
        {
            string connectionString = " Data Source =  db.sqlite3; Version = 3 ";
            SQLiteConnection con;

            con = new SQLiteConnection(connectionString);

            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {

                }
            }
            catch (Exception ex)
            {
                con.Close();
                return false;
            }

            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    fmd.CommandText = @"SELECT password, name, surename, middlename, rights FROM users WHERE id=" + Convert.ToString(id);
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        password = Convert.ToString(r["password"]);
                        name = Convert.ToString(r["name"]);
                        surename = Convert.ToString(r["surename"]);
                        middlename = Convert.ToString(r["middlename"]);
                        rights = Convert.ToInt32(r["rights"]);
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                    return false;
                }
            }
            con.Close();
            return true;
        }
    }
}
