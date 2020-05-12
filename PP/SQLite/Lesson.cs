using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PP
{
    class Lesson
    {
        public int id;
        public string name = "";
        public int equipment;

        public bool read_data() //якщо виникає проблема - повертає false; зчитує дані про заняття
        {
            if (id != 0)
            {
                Queue<int> available_id = new Queue<int>();
                available_id = Program.select_id("lessons");
                if (available_id.Peek() != -1 && available_id.Peek() != 0)
                {
                    if (Program.check_id(id, available_id) == true)
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
                                fmd.CommandText = @"SELECT name, equipment FROM lessons WHERE id=" + Convert.ToString(id);
                                SQLiteDataReader r = fmd.ExecuteReader();
                                while (r.Read())
                                {
                                    name = Convert.ToString(r["name"]);
                                    equipment = Convert.ToInt32(r["equipment"]);
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
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool write_data() //якщо виникає проблема - повертає false; додає зяняття
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
                    fmd.CommandText = @"INSERT INTO lessons (name, equipment) VALUES (" + name + ", " + equipment + ")";
                    fmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string log;
                    log = ex.Message;
                    con.Close();
                    return false;
                }
                con.Close();
                return true;
            }
        }

        public bool update_data() //якщо виникає проблема - повертає false; змінює дані існуючого заняття
        {
            if(id != 0)
            {
                Queue<int> available_id = new Queue<int>();
                available_id = Program.select_id("lessons");
                if (available_id.Peek() != -1 && available_id.Peek() != 0)
                {
                    if (Program.check_id(id, available_id) == true)
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
                                fmd.CommandText = @"UPDATE lessons SET name=" + name + ", equipment=" + equipment + " WHERE id=" + Convert.ToString(id);
                                fmd.ExecuteNonQuery();
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
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool delete_data() //якщо виникає проблема - повертає false; видаляє заняття
        {
            if(id != 0)
            {
                Queue<int> available_id = new Queue<int>();
                available_id = Program.select_id("lessons");
                if (available_id.Peek() != -1 && available_id.Peek() != 0)
                {
                    if (Program.check_id(id, available_id) == true)
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
                                fmd.CommandText = @"DELETE FROM lessons WHERE id=" + Convert.ToString(id);
                                fmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                string log;
                                log = ex.Message; 
                                con.Close();
                                return false;
                            }
                        }
                        con.Close();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}