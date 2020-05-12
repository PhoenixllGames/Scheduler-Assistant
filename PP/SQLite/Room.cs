using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PP
{
    class Room
    {
        public int id;
        public string name = "";
        public int equipment;
        public int[] monday = new int[4];
        public int[] tuesday = new int[4];
        public int[] wednesday = new int[4];
        public int[] thursday = new int[4];
        public int[] friday = new int[4];

        public bool read_data() //якщо виникає проблема - повертає false; зчитує дані про аудиторію
        {
            if (id != 0)
            {
                Queue<int> available_id = new Queue<int>();
                available_id = Program.select_id("rooms");
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
                                fmd.CommandText = @"SELECT name, equipment, monday_1, monday_2, monday_3, monday_4, tuesday_1, tuesday_2, tuesday_3, tuesday_4, wednesday_1, wednesday_2, wednesday_3, wednesday_4, thursday_1, thursday_2, thursday_3, thursday_4, friday_1, friday_2, friday_3, friday_4 FROM rooms WHERE id=" + Convert.ToString(id);
                                SQLiteDataReader r = fmd.ExecuteReader();
                                while (r.Read())
                                {
                                    name = Convert.ToString(r["name"]);
                                    equipment = Convert.ToInt32(r["equipment"]);
                                    monday[0] = Convert.ToInt32(r["monday_1"]);
                                    monday[1] = Convert.ToInt32(r["monday_2"]);
                                    monday[2] = Convert.ToInt32(r["monday_3"]);
                                    monday[3] = Convert.ToInt32(r["monday_4"]);
                                    tuesday[0] = Convert.ToInt32(r["tuesday_1"]);
                                    tuesday[1] = Convert.ToInt32(r["tuesday_2"]);
                                    tuesday[2] = Convert.ToInt32(r["tuesday_3"]);
                                    tuesday[3] = Convert.ToInt32(r["tuesday_4"]);
                                    wednesday[0] = Convert.ToInt32(r["wednesday_1"]);
                                    wednesday[1] = Convert.ToInt32(r["wednesday_2"]);
                                    wednesday[2] = Convert.ToInt32(r["wednesday_3"]);
                                    wednesday[3] = Convert.ToInt32(r["wednesday_4"]);
                                    thursday[0] = Convert.ToInt32(r["thursday_1"]);
                                    thursday[1] = Convert.ToInt32(r["thursday_2"]);
                                    thursday[2] = Convert.ToInt32(r["thursday_3"]);
                                    thursday[3] = Convert.ToInt32(r["thursday_4"]);
                                    friday[0] = Convert.ToInt32(r["friday_1"]);
                                    friday[1] = Convert.ToInt32(r["friday_2"]);
                                    friday[2] = Convert.ToInt32(r["friday_3"]);
                                    friday[3] = Convert.ToInt32(r["friday_4"]);
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

        public bool write_data() //якщо виникає проблема - повертає false; додає аудиторію
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
                    fmd.CommandText = @"INSERT INTO rooms (name, equipment, monday_1, monday_2, monday_3, monday_4, tuesday_1, tuesday_2, tuesday_3, tuesday_4, wednesday_1, wednesday_2, wednesday_3, wednesday_4, thursday_1, thursday_2, thursday_3, thursday_4, friday_1, friday_2, friday_3, friday_4) VALUES (@n, " + equipment + ", " + monday[0] + ", " + monday[1] + ", " + monday[2] + ", " + monday[3] + ", " + tuesday[0] + ", " + tuesday[1] + ", " + tuesday[2] + ", " + tuesday[3] + ", " + wednesday[0] + ", " + wednesday[1] + ", " + wednesday[2] + ", " + wednesday[3] + ", " + thursday[0] + ", " + thursday[1] + ", " + thursday[2] + ", " + thursday[3] + ", " + friday[0] + ", " + friday[1] + ", " + friday[2] + ", " + friday[3] + ")";
                    fmd.Parameters.Add("@n", System.Data.DbType.String, -1); //не чіпати!
                    fmd.Parameters["@n"].Value = name; //це також
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

        public bool update_data() //якщо виникає проблема - повертає false; змінює дані існуючої видаляє аудиторії
        {
            if(id != 0)
            {
                Queue<int> available_id = new Queue<int>();
                available_id = Program.select_id("rooms");
                if(available_id.Peek() != -1 && available_id.Peek() != 0)
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
                                fmd.CommandText = @"UPDATE rooms SET name=@n, equipment=" + equipment + ", monday_1=" + monday[0] + ", monday_2=" + monday[1] + ", monday_3=" + monday[2] + ", monday_4=" + monday[3] + ", tuesday_1=" + tuesday[0] + ", tuesday_2=" + tuesday[1] + ", tuesday_3=" + tuesday[2] + ", tuesday_4=" + tuesday[3] + ", wednesday_1=" + wednesday[0] + ", wednesday_2=" + wednesday[1] + ", wednesday_3=" + wednesday[2] + ", wednesday_4=" + wednesday[3] + ", thursday_1=" + thursday[0] + ", thursday_2=" + thursday[1] + ", thursday_3=" + thursday[2] + ", thursday_4=" + thursday[3] + ", friday_1=" + friday[0] + ", friday_2=" + friday[1] + ", friday_3=" + friday[2] + ", friday_4=" + friday[3] + " WHERE id=" + Convert.ToString(id);
                                fmd.Parameters.Add("@n", System.Data.DbType.String, -1); //не чіпати!
                                fmd.Parameters["@n"].Value = name; //це також
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

        public bool delete_data() //якщо виникає проблема - повертає false; видаляє аудиторію
        {
            if (id != 0)
            {
                Queue<int> available_id = new Queue<int>();
                available_id = Program.select_id("rooms");
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
                                fmd.CommandText = @"DELETE FROM rooms WHERE id=" + Convert.ToString(id);
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