using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PP
{
    class Group
    {
        public int id;
        public string name = "";
        public int number_of_lessons = 0;
        public int[] lesson = new int[20];
        public int[] monday = new int[4];
        public int[] tuesday = new int[4];
        public int[] wednesday = new int[4];
        public int[] thursday = new int[4];
        public int[] friday = new int[4];
        public int[] monday_teacher = new int[4];
        public int[] tuesday_teacher = new int[4];
        public int[] wednesday_teacher = new int[4];
        public int[] thursday_teacher = new int[4];
        public int[] friday_teacher = new int[4];
        public int[] monday_room = new int[4];
        public int[] tuesday_room = new int[4];
        public int[] wednesday_room = new int[4];
        public int[] thursday_room = new int[4];
        public int[] friday_room = new int[4];

        public bool read_data() //якщо виникає проблема - повертає false; зчитує дані про заняття групи
        {
            if (id != 0)
            {
                Queue<int> available_id = new Queue<int>();
                available_id = Program.select_id("groups");
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
                                fmd.CommandText = @"SELECT name, lesson_1, lesson_2, lesson_3, lesson_4, lesson_5, lesson_6, lesson_7, lesson_8, lesson_9, lesson_10, lesson_11, lesson_12, lesson_13, lesson_14, lesson_15, lesson_16, lesson_17, lesson_18, lesson_19, lesson_20, lessons, monday_1l, monday_2l, monday_3l, monday_4l, tuesday_1l, tuesday_2l, tuesday_3l, tuesday_4l, wednesday_1l, wednesday_2l, wednesday_3l, wednesday_4l, thursday_1l, thursday_2l, thursday_3l, thursday_4l, friday_1l, friday_2l, friday_3l, friday_4l, monday_1t, monday_2t, monday_3t, monday_4t, tuesday_1t, tuesday_2t, tuesday_3t, tuesday_4t, wednesday_1t, wednesday_2t, wednesday_3t, wednesday_4t, thursday_1t, thursday_2t, thursday_3t, thursday_4t, friday_1t, friday_2t, friday_3t, friday_4t, monday_1r, monday_2r, monday_3r, monday_4r, tuesday_1r, tuesday_2r, tuesday_3r, tuesday_4r, wednesday_1r, wednesday_2r, wednesday_3r, wednesday_4r, thursday_1r, thursday_2r, thursday_3r, thursday_4r, friday_1r, friday_2r, friday_3r, friday_4r FROM groups WHERE id=" + Convert.ToString(id);
                                SQLiteDataReader r = fmd.ExecuteReader();
                                while (r.Read())
                                {
                                    name = Convert.ToString(r["name"]);
                                    string temp = "lesson_";
                                    for (int i = 0; i < 20; i++)
                                    {
                                        lesson[i] = Convert.ToInt32(r[temp + Convert.ToString((i+1))]);
                                    }
                                    number_of_lessons = Convert.ToInt32(r["lessons"]);
                                    monday[0] = Convert.ToInt32(r["monday_1l"]);
                                    monday[1] = Convert.ToInt32(r["monday_2l"]);
                                    monday[2] = Convert.ToInt32(r["monday_3l"]);
                                    monday[3] = Convert.ToInt32(r["monday_4l"]);
                                    tuesday[0] = Convert.ToInt32(r["tuesday_1l"]);
                                    tuesday[1] = Convert.ToInt32(r["tuesday_2l"]);
                                    tuesday[2] = Convert.ToInt32(r["tuesday_3l"]);
                                    tuesday[3] = Convert.ToInt32(r["tuesday_4l"]);
                                    wednesday[0] = Convert.ToInt32(r["wednesday_1l"]);
                                    wednesday[1] = Convert.ToInt32(r["wednesday_2l"]);
                                    wednesday[2] = Convert.ToInt32(r["wednesday_3l"]);
                                    wednesday[3] = Convert.ToInt32(r["wednesday_4l"]);
                                    thursday[0] = Convert.ToInt32(r["thursday_1l"]);
                                    thursday[1] = Convert.ToInt32(r["thursday_2l"]);
                                    thursday[2] = Convert.ToInt32(r["thursday_3l"]);
                                    thursday[3] = Convert.ToInt32(r["thursday_4l"]);
                                    friday[0] = Convert.ToInt32(r["friday_1l"]);
                                    friday[1] = Convert.ToInt32(r["friday_2l"]);
                                    friday[2] = Convert.ToInt32(r["friday_3l"]);
                                    friday[3] = Convert.ToInt32(r["friday_4l"]);
                                    monday_teacher[0] = Convert.ToInt32(r["monday_1t"]);
                                    monday_teacher[1] = Convert.ToInt32(r["monday_2t"]);
                                    monday_teacher[2] = Convert.ToInt32(r["monday_3t"]);
                                    monday_teacher[3] = Convert.ToInt32(r["monday_4t"]);
                                    tuesday_teacher[0] = Convert.ToInt32(r["tuesday_1t"]);
                                    tuesday_teacher[1] = Convert.ToInt32(r["tuesday_2t"]);
                                    tuesday_teacher[2] = Convert.ToInt32(r["tuesday_3t"]);
                                    tuesday_teacher[3] = Convert.ToInt32(r["tuesday_4t"]);
                                    wednesday_teacher[0] = Convert.ToInt32(r["wednesday_1t"]);
                                    wednesday_teacher[1] = Convert.ToInt32(r["wednesday_2t"]);
                                    wednesday_teacher[2] = Convert.ToInt32(r["wednesday_3t"]);
                                    wednesday_teacher[3] = Convert.ToInt32(r["wednesday_4t"]);
                                    thursday_teacher[0] = Convert.ToInt32(r["thursday_1t"]);
                                    thursday_teacher[1] = Convert.ToInt32(r["thursday_2t"]);
                                    thursday_teacher[2] = Convert.ToInt32(r["thursday_3t"]);
                                    thursday_teacher[3] = Convert.ToInt32(r["thursday_4t"]);
                                    friday_teacher[0] = Convert.ToInt32(r["friday_1t"]);
                                    friday_teacher[1] = Convert.ToInt32(r["friday_2t"]);
                                    friday_teacher[2] = Convert.ToInt32(r["friday_3t"]);
                                    friday_teacher[3] = Convert.ToInt32(r["friday_4t"]);
                                    monday_room[0] = Convert.ToInt32(r["monday_1r"]);
                                    monday_room[1] = Convert.ToInt32(r["monday_2r"]);
                                    monday_room[2] = Convert.ToInt32(r["monday_3r"]);
                                    monday_room[3] = Convert.ToInt32(r["monday_4r"]);
                                    tuesday_room[0] = Convert.ToInt32(r["tuesday_1r"]);
                                    tuesday_room[1] = Convert.ToInt32(r["tuesday_2r"]);
                                    tuesday_room[2] = Convert.ToInt32(r["tuesday_3r"]);
                                    tuesday_room[3] = Convert.ToInt32(r["tuesday_4r"]);
                                    wednesday_room[0] = Convert.ToInt32(r["wednesday_1r"]);
                                    wednesday_room[1] = Convert.ToInt32(r["wednesday_2r"]);
                                    wednesday_room[2] = Convert.ToInt32(r["wednesday_3r"]);
                                    wednesday_room[3] = Convert.ToInt32(r["wednesday_4r"]);
                                    thursday_room[0] = Convert.ToInt32(r["thursday_1r"]);
                                    thursday_room[1] = Convert.ToInt32(r["thursday_2r"]);
                                    thursday_room[2] = Convert.ToInt32(r["thursday_3r"]);
                                    thursday_room[3] = Convert.ToInt32(r["thursday_4r"]);
                                    friday_room[0] = Convert.ToInt32(r["friday_1r"]);
                                    friday_room[1] = Convert.ToInt32(r["friday_2r"]);
                                    friday_room[2] = Convert.ToInt32(r["friday_3r"]);
                                    friday_room[3] = Convert.ToInt32(r["friday_4r"]);
                                }
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

        public bool write_data() //якщо виникає проблема - повертає false; додає групу
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
                return false;
            }

            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {


                    fmd.CommandText = @"INSERT INTO groups (name, lesson_1, lesson_2, lesson_3, lesson_4, lesson_5, lesson_6, lesson_7, lesson_8, lesson_9, lesson_10, lesson_11, lesson_12, lesson_13, lesson_14, lesson_15, lesson_16, lesson_17, lesson_18, lesson_19, lesson_20, lessons, monday_1l, monday_2l, monday_3l, monday_4l, tuesday_1l, tuesday_2l, tuesday_3l, tuesday_4l, wednesday_1l, wednesday_2l, wednesday_3l, wednesday_4l, thursday_1l, thursday_2l, thursday_3l, thursday_4l, friday_1l, friday_2l, friday_3l, friday_4l, monday_1t, monday_2t, monday_3t, monday_4t, tuesday_1t, tuesday_2t, tuesday_3t, tuesday_4t, wednesday_1t, wednesday_2t, wednesday_3t, wednesday_4t, thursday_1t, thursday_2t, thursday_3t, thursday_4t, friday_1t, friday_2t, friday_3t, friday_4t, monday_1r, monday_2r, monday_3r, monday_4r, tuesday_1r, tuesday_2r, tuesday_3r, tuesday_4r, wednesday_1r, wednesday_2r, wednesday_3r, wednesday_4r, thursday_1r, thursday_2r, thursday_3r, thursday_4r, friday_1r, friday_2r, friday_3r, friday_4r) VALUES (@n, " + lesson[0] + ", " + lesson[1] + ", " + lesson[2] + ", " + lesson[3] + ", " + lesson[4] + ", " + lesson[5] + ", " + lesson[6] + ", " + lesson[7] + ", " + lesson[8] + ", " + lesson[9] + ", " + lesson[10] + ", " + lesson[11] + ", " + lesson[12] + ", " + lesson[13] + ", " + lesson[14] + ", " + lesson[15] + ", " + lesson[16] + ", " + lesson[17] + ", " + lesson[18] + ", " + lesson[19] + ", " + number_of_lessons + ", " + monday[0] + ", " + monday[1] + ", " + monday[2] + ", " + monday[3] + ", " + tuesday[0] + ", " + tuesday[1] + ", " + tuesday[2] + ", " + tuesday[3] + ", " + wednesday[0] + ", " + wednesday[1] + ", " + wednesday[2] + ", " + wednesday[3] + ", " + thursday[0] + ", " + thursday[1] + ", " + thursday[2] + ", " + thursday[3] + ", " + friday[0] + ", " + friday[1] + ", " + friday[2] + ", " + friday[3] + ", " + monday_teacher[0] + ", " + monday_teacher[1] + ", " + monday_teacher[2] + ", " + monday_teacher[3] + ", " + tuesday_teacher[0] + ", " + tuesday_teacher[1] + ", " + tuesday_teacher[2] + ", " + tuesday_teacher[3] + ", " + wednesday_teacher[0] + ", " + wednesday_teacher[1] + ", " + wednesday_teacher[2] + ", " + wednesday_teacher[3] + ", " + thursday_teacher[0] + ", " + thursday_teacher[1] + ", " + thursday_teacher[2] + ", " + thursday_teacher[3] + ", " + friday_teacher[0] + ", " + friday_teacher[1] + ", " + friday_teacher[2] + ", " + friday_teacher[3] + ", " + monday_room[0] + ", " + monday_room[1] + ", " + monday_room[2] + ", " + monday_room[3] + ", " + tuesday_room[0] + ", " + tuesday_room[1] + ", " + tuesday_room[2] + ", " + tuesday_room[3] + ", " + wednesday_room[0] + ", " + wednesday_room[1] + ", " + wednesday_room[2] + ", " + wednesday_room[3] + ", " + thursday_room[0] + ", " + thursday_room[1] + ", " + thursday_room[2] + ", " + thursday_room[3] + ", " + friday_room[0] + ", " + friday_room[1] + ", " + friday_room[2] + ", " + friday_room[3] + ")";
                    fmd.Parameters.Add("@n", System.Data.DbType.String, -1); //не чіпати!
                    fmd.Parameters["@n"].Value = name; //це також
                    fmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string log;
                    log = ex.Message;
                    return false;
                }
                return true;
            }
        }

        public bool update_data() //якщо виникає проблема - повертає false; змінює дані існуючої групи
        {
            if(id != 0)
            {
                Queue<int> available_id = new Queue<int>();
                available_id = Program.select_id("groups");
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
                            return false;
                        }

                        using (SQLiteCommand fmd = con.CreateCommand())
                        {
                            try
                            {
                                fmd.CommandText = @"UPDATE groups SET name=@n, lesson_1=" + lesson[0] + ", lesson_2=" + lesson[1] + ", lesson_3=" + lesson[2] + ", lesson_4=" + lesson[3] + ", lesson_5=" + lesson[4] + ", lesson_6=" + lesson[5] + ", lesson_7=" + lesson[6] + ", lesson_8=" + lesson[7] + ", lesson_9=" + lesson[8] + ", lesson_10=" + lesson[9] + ", lesson_11=" + lesson[10] + ", lesson_12=" + lesson[11] + ", lesson_13=" + lesson[12] + ", lesson_14=" + lesson[13] + ", lesson_15=" + lesson[14] + ", lesson_16=" + lesson[15] + ", lesson_17=" + lesson[16] + ", lesson_19=" + lesson[18] + ", lesson_20=" + lesson[19] + ", lessons=" + number_of_lessons + ", monday_1l=" + monday[0] + ", monday_2l=" + monday[1] + ", monday_3l=" + monday[2] + ", monday_4l=" + monday[3] + ", tuesday_1l=" + tuesday[0] + ", tuesday_2l=" + tuesday[1] + ", tuesday_3l=" + tuesday[2] + ", tuesday_4l=" + tuesday[3] + ", wednesday_1l=" + wednesday[0] + ", wednesday_2l=" + wednesday[1] + ", wednesday_3l=" + wednesday[2] + ", wednesday_4l=" + wednesday[3] + ", thursday_1l=" + thursday[0] + ", thursday_2l=" + thursday[1] + ", thursday_3l=" + thursday[2] + ", thursday_4l=" + thursday[3] + ", friday_1l=" + friday[0] + ", friday_2l=" + friday[1] + ", friday_3l=" + friday[2] + ", friday_4l=" + friday[3] + ", monday_1t=" + monday_teacher[0] + ", monday_2t=" + monday_teacher[1] + ", monday_3t=" + monday_teacher[2] + ", monday_4t=" + monday_teacher[3] + ", tuesday_1t=" + tuesday_teacher[0] + ", tuesday_2t=" + tuesday_teacher[1] + ", tuesday_3t=" + tuesday_teacher[2] + ", tuesday_4t=" + tuesday_teacher[3] + ", wednesday_1t=" + wednesday_teacher[0] + ", wednesday_2t=" + wednesday_teacher[1] + ", wednesday_3t=" + wednesday_teacher[2] + ", wednesday_4t=" + wednesday_teacher[3] + ", thursday_1t=" + thursday_teacher[0] + ", thursday_2t=" + thursday_teacher[1] + ", thursday_3t=" + thursday_teacher[2] + ", thursday_4t=" + thursday_teacher[3] + ", friday_1t=" + friday_teacher[0] + ", friday_2t=" + friday_teacher[1] + ", friday_3t=" + friday_teacher[2] + ", friday_4t=" + friday_teacher[3] + ", monday_1r=" + monday_room[0] + ", monday_2r=" + monday_room[1] + ", monday_3r=" + monday_room[2] + ", monday_4r=" + monday_room[3] + ", tuesday_1r=" + tuesday_room[0] + ", tuesday_2r=" + tuesday_room[1] + ", tuesday_3r=" + tuesday_room[2] + ", tuesday_4r=" + tuesday_room[3] + ", wednesday_1r=" + wednesday_room[0] + ", wednesday_2r=" + wednesday_room[1] + ", wednesday_3r=" + wednesday_room[2] + ", wednesday_4r=" + wednesday_room[3] + ", thursday_1r=" + thursday_room[0] + ", thursday_2r=" + thursday_room[1] + ", thursday_3r=" + thursday_room[2] + ", thursday_4r=" + thursday_room[3] + ", friday_1r=" + friday_room[0] + ", friday_2r=" + friday_room[1] + ", friday_3r=" + friday_room[2] + ", friday_4r=" + friday_room[3] + " WHERE id=" + Convert.ToString(id);
                                fmd.Parameters.Add("@n", System.Data.DbType.String, -1); //не чіпати!
                                fmd.Parameters["@n"].Value = name; //це також
                                fmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                string log;
                                log = ex.Message;
                                return false;
                            }
                        }
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
                available_id = Program.select_id("groups");
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
                            return false;
                        }

                        using (SQLiteCommand fmd = con.CreateCommand())
                        {
                            try
                            {
                                fmd.CommandText = @"DELETE FROM groups WHERE id=" + Convert.ToString(id);
                                fmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                string log;
                                log = ex.Message;
                                return false;
                            }
                        }
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

        public bool add_lesson(int add) //якщо виникає проблема - повертає false; додає новий предмет зі списку викладача
        {
            if (number_of_lessons < 20)
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
                if (lesson[i] == delete)
                {
                    lesson[i] = 0;
                    for (int j = i + 1; j < number_of_lessons; j++)
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