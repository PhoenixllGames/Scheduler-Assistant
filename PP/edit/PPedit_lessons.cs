using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP
{
    public partial class PPedit_lessons : Form
    {
        Lesson[] lesson; //do not delete!
        public PPedit_lessons()
        {
            InitializeComponent();
        }

        private void englanguge()
        {
            ///langpack///

            string

                //settings
                setting1 = "Time at center",
                setting2 = "Prograss bar",
                setting3 = "Languge",

                //buttons
                savebutton = "Save",
                backbutton = "Back",
                dellacc = "Delete accaunt",
                exit = "Exit",
                ok = "OK",
                add = "Add",
                dell = "Delete",
                edit = "Edit",
                //texts
                warnrel = "Reload program and save sattings",
                editdata = "Edit data",
                surname = "Surname",
                patronymic = "Patronymic",
                editpass = "Edit password",
                newpass = "New password",
                confirmpass = "Confirm password",
                yid = "Your id",
                foraccept = "To confirm any data or delete the account, enter the password",
                id = "ID",
                password = "Password",
                ver = "Version",
                by = "Made by",
                and = "and",

                //menu
                menu = "Menu",
                        groups = "Groups",
                            seegroups = "View groups",
                            editgroups = "Edit groups",
                        clases = "Audience",
                            seeclases = "View audience",
                            editclases = "Edit audience",
                        lessons = "Lessons",
                            seelessons = "View lessons",
                            editlessons = "Edit lessons",
                        teachers = "Teachers",
                            seeteachers = "View teachers",
                            editteachers = "Edit teachers",
                        settings = "Settings",
                        users = "Users",
                            editusers = "Edit users",
                        account = "Account",
                            editaccount = "Edit account",
                            exitaccount = "Exit account",
                        about = "About program",
                   //exit = "Exit",
                   view = "View",
                        statistics = "Statistics",
                            students = "Students",
                            teacherss = "Teachers",
                                employment = "Employment",
                        thismoment = "At this moment",
                            couples = "Couples ",
                            freerooms = "Free rooms",
                        schedule = "Schedule",
                    plotting = "Plotting",
                        auto = "Auto",
                            separately = "Separately",
                        manually = "Manually",
                            editschedule = "Edit schedule",
                            makeschedule = "Make schedule",
                            recover = "Recover",
                    progressbar = "Couple progress",

              //titles
              ppadm = "Scheduler Assistant (Admin)",
              ppuser = "Scheduler Assistant (User)",
              warn = "Warning";


            this.Text = editlessons;
            //buttons
            button4.Text = add;
            button3.Text = dell;
            button2.Text = edit;
            button1.Text = backbutton;
            //menu
            menuToolStripMenuItem.Text = menu;
            настройкиToolStripMenuItem1.Text = settings;
            aboutProgramToolStripMenuItem.Text = about;
            backToolStripMenuItem.Text = backbutton;
            exitToolStripMenuItem1.Text = exit;
            //progressbar
            label1.Text = progressbar;

        }
        private void rulanguge()
        {
            ///langpack///

            string

                //settings
                setting1 = "Отображать часы",
                setting2 = "Отображать прогрес занятия",
                setting3 = "Язык",

                //buttons
                savebutton = "Сохранить",
                backbutton = "Назад",
                dellacc = "Удалить профиль",
                exit = "Выход",
                ok = "OK",
                add = "Добавить",
                dell = "Удалить",
                edit = "Изменить",
                //texts
                warnrel = "Перезагрузить программу и сохранить настройки",
                editdata = "Редактировать данные",
                surname = "Фамилия",
                patronymic = "Отчество",
                editpass = "Редактировать пароль",
                newpass = "Новый пароль",
                confirmpass = "Подтвердите пароль",
                yid = "Ваш ID",
                foraccept = "Для подтверждения изменений в профиле или его удаления, введите пароль",
                id = "ID",
                password = "Пароль",
                ver = "Версия",
                by = "Сделали",
                and = "и",

                //menu
                menu = "Меню",
                        groups = "Группы",
                            seegroups = "Просмотр групп",
                            editgroups = "Редактирование групп",
                        clases = "Аудитории",
                            seeclases = "Перосмотр аудиторий",
                            editclases = "Редактирование аудиторий",
                        lessons = "Занятия",
                            seelessons = "Просмотр занятий",
                            editlessons = "Редактирование занятий",
                        teachers = "Преподаватели",
                            seeteachers = "Просмотр преподавателей",
                            editteachers = "Редактирование преподавателей",
                        settings = "Настройки",
                        users = "Пользователи",
                            editusers = "Редактирование пользователей",
                        account = "Профиль",
                            editaccount = "Редактировать профиль",
                            exitaccount = "Выйти из профиля",
                        about = "О программе",
                   //exit = "Выход",
                   view = "Просмотр",
                        statistics = "Статистика",
                            students = "Группы",
                            teacherss = "Преподаватели",
                                employment = "Занятость",
                        thismoment = "Текущая",
                            couples = "Занятия",
                            freerooms = "Свободные аудитории",
                        schedule = "Расписание",
                    plotting = "Планировка",
                        auto = "Автоматическая",
                            separately = "Отдельно",
                        manually = "Вручную",
                            editschedule = "Редактировать расписание",
                            makeschedule = "Создать расписание",
                            recover = "Предыдущая версия",
                    progressbar = "Прогрес пары",

              //titles
              ppadm = "Помощник Планировщика (Администратор)",
              ppuser = "Помощник Планировщика (Пользователь)",
              warn = "Предупреждение";

            this.Text = editlessons;
            //buttons
            button4.Text = add;
            button3.Text = dell;
            button2.Text = edit;
            button1.Text = backbutton;
            //menu
            menuToolStripMenuItem.Text = menu;
            настройкиToolStripMenuItem1.Text = settings;
            aboutProgramToolStripMenuItem.Text = about;
            backToolStripMenuItem.Text = backbutton;
            exitToolStripMenuItem1.Text = exit;
            //progressbar
            label1.Text = progressbar;
        }
        private void ualanguge()
        {
            ///langpack///

            string

                //settings
                setting1 = "Відображати годинник",
                setting2 = "Відображати прогрес пари",
                setting3 = "Мова",

                //buttons
                savebutton = "Зберегти",
                backbutton = "Назад",
                dellacc = "Видалити профіль",
                exit = "Вихід",
                ok = "OK",
                add = "Додати",
                dell = "Видалити",
                edit = "Змінити",
                //texts
                warnrel = "Перезавантажити програму та зберегти налаштування",
                editdata = "Редагувати дані",
                surname = "Прізвище",
                patronymic = "По батькові",
                editpass = "Редагувати пароль",
                newpass = "Новий пароль",
                confirmpass = "Підтвердіть пароль",
                yid = "Ваш ID",
                foraccept = "Для підтвердження змін в профілі або його видалення, введіть пароль",
                id = "ID",
                password = "Пароль",
                ver = "Версія",
                by = "Зробили",
                and = "та",

                //menu
                menu = "Меню",
                        groups = "Групи",
                            seegroups = "Переглянути групи",
                            editgroups = "Редагувати групи",
                        clases = "Аудиторії",
                            seeclases = "Переглянути аудиторії",
                            editclases = "Редагувати аудиторії",
                        lessons = "Заняття",
                            seelessons = "Переглянути заняття",
                            editlessons = "Редагувати заняття",
                        teachers = "Викладачі",
                            seeteachers = "Переглянути викладачів",
                            editteachers = "Редагувати викладачів",
                        settings = "Налаштування",
                        users = "Користувачі",
                            editusers = "Редагувати користувачів",
                        account = "Профіль",
                            editaccount = "Редагувати профіль",
                            exitaccount = "Вийти з профілю",
                        about = "Про програму",
                   //exit = "Вихід",
                   view = "Перегляд",
                        statistics = "Статистика",
                            students = "Групи",
                            teacherss = "Викладачі",
                                employment = "Зайнятість",
                        thismoment = "На даний момент",
                            couples = "Заняття",
                            freerooms = "Вільні аудиторії",
                        schedule = "Розклад",
                    plotting = "Планування",
                        auto = "Автоматично",
                            separately = "Окремо",
                        manually = "Вручну",
                            editschedule = "Редагувати розклад",
                            makeschedule = "Створити родклад",
                            recover = "Попередня версія",
                    progressbar = "Прогрес пари",

              //titles
              ppadm = "Помічник Планувальника (Адміністратор)",
              ppuser = "Помічник Планувальника (Користувач)",
              warn = "Попередження";

            this.Text = editlessons;
            //buttons
            button4.Text = add;
            button3.Text = dell;
            button2.Text = edit;
            button1.Text = backbutton;
            //menu
            menuToolStripMenuItem.Text = menu;
            настройкиToolStripMenuItem1.Text = settings;
            aboutProgramToolStripMenuItem.Text = about;
            backToolStripMenuItem.Text = backbutton;
            exitToolStripMenuItem1.Text = exit;
            //progressbar
            label1.Text = progressbar;
        }
        public int lang = 0;
        private void PPedit_lessons_Load(object sender, EventArgs e)
        {
            string settings, aply = "";
            var path = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            using (FileStream fstream = File.OpenRead($"{path}/settings.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);

                settings = System.Text.Encoding.Default.GetString(array);

            }
            char[] tempc = settings.ToCharArray();
            for (int i = 0; i < settings.Length; i++)
            {
                if (int.TryParse(Convert.ToString(tempc[i]), out int v))
                {
                    aply += tempc[i];
                }
            }
            char[] set = aply.ToCharArray();

            if (Convert.ToInt32(set[0]) == 49)
            {
                label2.Visible = true;
            }
            else label2.Visible = false;
            if (Convert.ToInt32(set[1]) == 49)
            {
                label1.Visible = true;
                progressBar1.Visible = true;
            }
            else { label1.Visible = false; progressBar1.Visible = false; }

            lang = Convert.ToInt32(set[2]) - 48;
            if (lang == 1) { rulanguge(); }
            else if (lang == 2) { ualanguge(); }
            else
            {
                englanguge();
            }

            set_form();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = Convert.ToString(DateTime.Now.ToShortTimeString());
            int min = 0;


            if (time.Length != 5)
            {
                time = "0" + time;
                min += (Convert.ToInt32(time[1]) - 48) * 60 + (Convert.ToInt32(time[3]) - 48) * 10 + (Convert.ToInt32(time[4]) - 48);

            }
            else
            {
                min += ((Convert.ToInt32(time[0]) - 48) * 10 + (Convert.ToInt32(time[1]) - 48)) * 60 + (Convert.ToInt32(time[3]) - 48) * 10 + (Convert.ToInt32(time[4]) - 48);
            }
            if (900 > min && min > 540)
            {
                if (620 > min && min > 540) { progressBar1.Value = Convert.ToInt32((min - 540) * 1.25); }
                else if (710 > min && min > 630) { progressBar1.Value = Convert.ToInt32((min - 630) * 1.25); }
                else if (810 > min && min > 730) { progressBar1.Value = Convert.ToInt32((min - 730) * 1.25); }
                else if (900 > min && min > 820) { progressBar1.Value = Convert.ToInt32((min - 820) * 1.25); }
                else { progressBar1.Value = 0; }
            }
            else { progressBar1.Value = 0; }
            label2.Text = Convert.ToString(time);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new PPabout())
            {
                var result = form.ShowDialog();
            }
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var form = new PPsettings())
            {
                var result = form.ShowDialog();
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var form = new PPenter_values())
            {
                form.change = 4;
                form.update = false;
                var result = form.ShowDialog();
                set_form();
            }
        }

        public void set_form() //to be used after changes to database
        {
            comboBox1.Items.Clear();
            Queue<int> queue = new Queue<int>();
            queue = Program.select_id("lessons");
            int lesson_count = queue.Count;
            lesson = new Lesson[lesson_count]; //this one is global
            for (int i = 0; i < lesson_count; i++)
            {
                lesson[i] = new Lesson();
                lesson[i].id = queue.Peek();
                queue.Dequeue();
                lesson[i].read_data();
                string element = lesson[i].name + " (" + Convert.ToString(lesson[i].id) + ")";
                comboBox1.Items.Add(element);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form = new PPenter_values())
            {
                if (comboBox1.Text != "")
                {
                    form.change = 4;
                    form.update = true;
                    string id = "";
                    for (int i = comboBox1.Text.IndexOf('(') + 1; i < comboBox1.Text.IndexOf(')'); i++)
                    {
                        id += comboBox1.Text[i];
                    }
                    for (int i = 0; i < lesson.Length; i++)
                    {
                        if (Convert.ToString(lesson[i].id) == id)
                        {
                            form.sent_id = lesson[i].id;
                            form.sent_name = lesson[i].name;
                            form.sent_equipment = lesson[i].equipment;
                            break;
                        }
                    }
                    var result = form.ShowDialog();
                    set_form();
                }
                else
                {
                    //write 'lesson not chosen' error
                }
            }
        }
    }
}
