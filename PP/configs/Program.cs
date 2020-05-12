using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; //важливо!

namespace PP
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PPlogin());
        }

        public static Queue<int> select_id(string table) //після виконання перевірити перший елемент - якщо він -1, сталася помилка, якщо 0, таблиця порожня
        {
            Queue<int> mistake = new Queue<int>(); //для вийняткових ситуацій

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
                mistake.Enqueue(-1);
                return mistake;
            }

            Queue<int> queue = new Queue<int>();
            using (SQLiteCommand fmd = con.CreateCommand())
            {
                try
                {
                    fmd.CommandText = @"SELECT id FROM " + table;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        queue.Enqueue(Convert.ToInt32(r["id"]));
                    }
                }
                catch (Exception ex)
                {
                    mistake.Enqueue(-1);
                    return mistake;
                }
            }
            
            try
            {
                int test;
                test = queue.Peek();
            }
            catch(Exception ex)
            {
                mistake.Enqueue(0); //якщо пуста таблиця
                return mistake;
            }
            return queue;
        }
    
        public static bool check_id(int id, Queue<int> queue) //перевіряє наявність id в черзі; повертає true, якщо він є, або false, якщо немає
        {
            int limit = queue.Count;
            for(int i = 0; i < limit; i++)
            {
                if(id == queue.Peek())
                {
                    return true;
                }
                else
                {
                    queue.Dequeue();
                }
            }
            return false;
        }
        
        //не видаляти - може знадобитися
        //Queue<int> available_id = new Queue<int>();
        //available_id = Program.select_id("rooms");
        //        if (available_id.Peek() != -1 && available_id.Peek() != 0)
        //        {
        //            if (Program.check_id(id, available_id) == true)
        //            {

        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            return false;
        //        }
    }
}