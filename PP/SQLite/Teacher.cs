using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace PP
{
    class Teacher
    {
        public int id;
        public string name;
        public string surename;
        public string middlename;
        public int number_of_lessons = 0;
        public int[] lesson = new int[10];
        public int[] monday = new int[4];
        public int[] tuesday = new int[4];
        public int[] wednesday = new int[4];
        public int[] thursday = new int[4];
        public int[] friday = new int[4];

        public bool read_data() //якщо виникає проблема - повертає false; зчитує дані про заняття викладача
        {
            if (id != 0)
            {
                Queue<int> available_id = new Queue<int>();
                available_id = Program.select_id("teachers");
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
                                fmd.CommandText = @"SELECT name, surename, middlename, lesson_1, lesson_2, lesson_3, lesson_4, lesson_5, lesson_6, lesson_7, lesson_8, lesson_9, lesson_10, lessons, monday_1, monday_2, monday_3, monday_4, tuesday_1, tuesday_2, tuesday_3, tuesday_4, wednesday_1, wednesday_2, wednesday_3, wednesday_4, thursday_1, thursday_2, thursday_3, thursday_4, friday_1, friday_2, friday_3, friday_4 FROM teachers WHERE id=" + Convert.ToString(id);
                                SQLiteDataReader r = fmd.ExecuteReader();
                                while (r.Read())
                                {
                                    name = Convert.ToString(r["name"]);
                                    surename = Convert.ToString(r["surename"]);
                                    middlename = Convert.ToString(r["middlename"]);
                                    lesson[0] = Convert.ToInt32(r["lesson_1"]);
                                    lesson[1] = Convert.ToInt32(r["lesson_2"]);
                                    lesson[2] = Convert.ToInt32(r["lesson_3"]);
                                    lesson[3] = Convert.ToInt32(r["lesson_4"]);
                                    lesson[4] = Convert.ToInt32(r["lesson_5"]);
                                    lesson[5] = Convert.ToInt32(r["lesson_6"]);
                                    lesson[6] = Convert.ToInt32(r["lesson_7"]);
                                    lesson[7] = Convert.ToInt32(r["lesson_8"]);
                                    lesson[8] = Convert.ToInt32(r["lesson_9"]);
                                    lesson[9] = Convert.ToInt32(r["lesson_10"]);
                                    number_of_lessons = Convert.ToInt32(r["lessons"]);
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

        public bool write_data() //якщо виникає проблема - повертає false; додає викладача
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
                    fmd.CommandText = @"INSERT INTO teachers (name, surename, middlename, lesson_1, lesson_2, lesson_3, lesson_4, lesson_5, lesson_6, lesson_7, lesson_8, lesson_9, lesson_10, lessons, monday_1, monday_2, monday_3, monday_4, tuesday_1, tuesday_2, tuesday_3, tuesday_4, wednesday_1, wednesday_2, wednesday_3, wednesday_4, thursday_1, thursday_2, thursday_3, thursday_4, friday_1, friday_2, friday_3, friday_4) VALUES (@n, " + surename + ", " + middlename + ", " + lesson[0] + ", " + lesson[1] + ", " + lesson[2] + ", " + lesson[3] + ", " + lesson[4] + ", " + lesson[5] + ", " + lesson[6] + ", " + lesson[7] + ", " + lesson[8] + ", " + lesson[9] + ", " + number_of_lessons + ", " + monday[0] + ", " + monday[1] + ", " + monday[2] + ", " + monday[3] + ", " + tuesday[0] + ", " + tuesday[1] + ", " + tuesday[2] + ", " + tuesday[3] + ", " + wednesday[0] + ", " + wednesday[1] + ", " + wednesday[2] + ", " + wednesday[3] + ", " + thursday[0] + ", " + thursday[1] + ", " + thursday[2] + ", " + thursday[3] + ", " + friday[0] + ", " + friday[1] + ", " + friday[2] + ", " + friday[3] + ")";
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

        public bool update_data() //якщо виникає проблема - повертає false; змінює дані існуючого викладача
        {
            if(id != 0)
            {
                Queue<int> available_id = new Queue<int>();
                available_id = Program.select_id("teachers");
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
                                fmd.CommandText = @"UPDATE teachers SET name=@n, surename=@s, middlename=@m, lesson_1=" + lesson[0] + ", lesson_2=" + lesson[1] + ", lesson_3=" + lesson[2] + ", lesson_4=" + lesson[3] + ", lesson_5=" + lesson[4] + ", lesson_6=" + lesson[5] + ", lesson_7=" + lesson[6] + ", lesson_8=" + lesson[7] + ", lesson_9=" + lesson[8] + ", lesson_10=" + lesson[9] + ", lessons=" + number_of_lessons + ", monday_1=" + monday[0] + ", monday_2=" + monday[1] + ", monday_3=" + monday[2] + ", monday_4=" + monday[3] + ", tuesday_1=" + tuesday[0] + ", tuesday_2=" + tuesday[1] + ", tuesday_3=" + tuesday[2] + ", tuesday_4=" + tuesday[3] + ", wednesday_1=" + wednesday[0] + ", wednesday_2=" + wednesday[1] + ", wednesday_3=" + wednesday[2] + ", wednesday_4=" + wednesday[3] + ", thursday_1=" + thursday[0] + ", thursday_2=" + thursday[1] + ", thursday_3=" + thursday[2] + ", thursday_4=" + thursday[3] + ", friday_1=" + friday[0] + ", friday_2=" + friday[1] + ", friday_3=" + friday[2] + ", friday_4=" + friday[3] + " WHERE id=" + Convert.ToString(id);
                                fmd.Parameters.Add("@n", System.Data.DbType.String, -1); //не чіпати!
                                fmd.Parameters["@n"].Value = name; //це також
                                fmd.Parameters.Add("@s", System.Data.DbType.String, -1); //не чіпати!
                                fmd.Parameters["@s"].Value = surename; //це також
                                fmd.Parameters.Add("@m", System.Data.DbType.String, -1); //не чіпати!
                                fmd.Parameters["@m"].Value = middlename; //це також
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
        
        public bool delete_data() //якщо виникає проблема - повертає false; видаляє групу
        {
            if(id != 0)
            {
                Queue<int> available_id = new Queue<int>();
                available_id = Program.select_id("teachers");
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
                                fmd.CommandText = @"DELETE FROM teachers WHERE id=" + Convert.ToString(id);
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

        public bool add_lesson(int add) //якщо виникає проблема - повертає false; додає новий предмет в список викладача
        {
            if (number_of_lessons < 10)
            {
                for(int i = 0; i < number_of_lessons; i++)
                {
                    if(add == lesson[i])
                    {
                        return false;
                    }
                }
                lesson[number_of_lessons] = add;
                number_of_lessons++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool delete_lesson(int delete) //якщо виникає проблема - повертає false; видаляє предмет зі списку викладача
        {
            bool changed = false;
            for (int i = 0; i < number_of_lessons; i++)
            {
                if(lesson[i] == delete)
                {
                    lesson[i] = 0;
                    for(int j = i + 1; j < number_of_lessons; j++)
                    {
                        lesson[j - 1] = lesson[j];
                        lesson[j] = 0;
                    }
                    number_of_lessons--;
                    changed = true;
                    break;
                }
            }
            return changed;
        }
    }
}