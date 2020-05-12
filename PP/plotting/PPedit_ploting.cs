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

namespace PP.plotting
{
    public partial class PPedit_ploting : Form
    {
        Group[] group;
        Teacher[] teachers;
        Lesson[] lessons;
        Room[] rooms;
        public PPedit_ploting()
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
                open = "Open",

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

                  

                  

                this.Text = editschedule;
                //buttons
                button4.Text = open;
                button2.Text = edit;
                button1.Text = backbutton;
                //menu
                menuToolStripMenuItem.Text = menu;
                settingsToolStripMenuItem1.Text = settings;
                aboutProgrammToolStripMenuItem.Text = about;
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
                    open = "Открыть",
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

            this.Text = editschedule;
            //buttons
            button4.Text = open;
            button2.Text = edit;
            button1.Text = backbutton;
            //menu
            menuToolStripMenuItem.Text = menu;
            settingsToolStripMenuItem1.Text = settings;
            aboutProgrammToolStripMenuItem.Text = about;
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
                    open = "Відкрити",
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


            this.Text = editschedule;
            //buttons
            button4.Text = open;
            button2.Text = edit;
            button1.Text = backbutton;
            //menu
            menuToolStripMenuItem.Text = menu;
            settingsToolStripMenuItem1.Text = settings;
            aboutProgrammToolStripMenuItem.Text = about;
            backToolStripMenuItem.Text = backbutton;
            exitToolStripMenuItem1.Text = exit;
            //progressbar
            label1.Text = progressbar;
        }
            public int lang = 0;
            private void PPedit_ploting_Load(object sender, EventArgs e)
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
            teachers = set_teacher();
            lessons = set_lesson();
            rooms = set_room();
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

            private void aboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool schedule = true;
                string id = "";
                if (comboBox1.Text != "")
                {
                    for (int i = comboBox1.Text.IndexOf('(') + 1; i < comboBox1.Text.IndexOf(')'); i++)
                    {
                        id += comboBox1.Text[i];
                    }
                    int group_id = Convert.ToInt32(id);
                    int lesson_id = 0;
                    if (comboBox_monday1l.Text != "")
                    {
                        id = "";
                        for (int i = comboBox_monday1l.Text.IndexOf('(') + 1; i < comboBox_monday1l.Text.IndexOf(')'); i++) //monday lesson 1 id
                        {
                            id += comboBox_monday1l.Text[i];
                        }
                        lesson_id = Convert.ToInt32(id);
                    }
                    else
                    {
                        lesson_id = 0;
                    }
                    if (lesson_id != 0)
                    {
                        id = "";
                        for (int i = comboBox_monday1t.Text.IndexOf('(') + 1; i < comboBox_monday1t.Text.IndexOf(')'); i++) //id of teacher on monday 1 lesson
                        {
                            id += comboBox_monday1t.Text[i];
                        }
                        int teacher_id = Convert.ToInt32(id);
                        for (int i = 0; i < teachers.Length; i++)
                        {
                            if (teachers[i].id == teacher_id)
                            {
                                if (teachers[i].monday[0] == 0 || teachers[i].monday[0] == group_id)
                                {
                                    id = "";
                                    for (int j = comboBox_monday1r.Text.IndexOf('(') + 1; j < comboBox_monday1r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                    {
                                        id += comboBox_monday1r.Text[j];
                                    }
                                    int room_id = Convert.ToInt32(id);
                                    for (int j = 0; j < rooms.Length; j++)
                                    {
                                        if (rooms[j].id == room_id)
                                        {
                                            if (rooms[i].monday[0] == 0 || rooms[i].monday[0] == group_id)
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                room_unavailable(rooms[i], 1, 1);
                                                schedule = false;
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                    teacher_unavailable(teachers[i], 1, 1);
                                    schedule = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (schedule == true)
                    {
                        if (comboBox_monday2l.Text != "")
                        {
                            id = "";
                            for (int i = comboBox_monday2l.Text.IndexOf('(') + 1; i < comboBox_monday2l.Text.IndexOf(')'); i++) //monday lesson 1 id
                            {
                                id += comboBox_monday2l.Text[i];
                            }
                            lesson_id = Convert.ToInt32(id);
                        }
                        else
                        {
                            lesson_id = 0;
                        }
                        if (lesson_id != 0)
                        {
                            id = "";
                            for (int i = comboBox_monday2t.Text.IndexOf('(') + 1; i < comboBox_monday2t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                            {
                                id += comboBox_monday2t.Text[i];
                            }
                            int teacher_id = Convert.ToInt32(id);
                            for (int i = 0; i < teachers.Length; i++)
                            {
                                if (teachers[i].id == teacher_id)
                                {
                                    if (teachers[i].monday[1] == 0 || teachers[i].monday[1] == group_id)
                                    {
                                        id = "";
                                        for (int j = comboBox_monday2r.Text.IndexOf('(') + 1; j < comboBox_monday2r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                        {
                                            id += comboBox_monday2r.Text[j];
                                        }
                                        int room_id = Convert.ToInt32(id);
                                        for (int j = 0; j < rooms.Length; j++)
                                        {
                                            if (rooms[j].id == room_id)
                                            {
                                                if (rooms[i].monday[1] == 0 || rooms[i].monday[1] == group_id)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    room_unavailable(rooms[i], 1, 2);
                                                    schedule = false;
                                                    break;
                                                }
                                            }
                                        }
                                        break;
                                    }
                                    else
                                    {
                                        teacher_unavailable(teachers[i], 1, 2);
                                        schedule = false;
                                        break;
                                    }
                                }
                            }
                        }
                        if (schedule == true)
                        {
                            if (comboBox_monday3l.Text != "")
                            {
                                id = "";
                                for (int i = comboBox_monday3l.Text.IndexOf('(') + 1; i < comboBox_monday3l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                {
                                    id += comboBox_monday3l.Text[i];
                                }
                                lesson_id = Convert.ToInt32(id);
                            }
                            else
                            {
                                lesson_id = 0;
                            }
                            if (lesson_id != 0)
                            {
                                id = "";
                                for (int i = comboBox_monday3t.Text.IndexOf('(') + 1; i < comboBox_monday3t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                {
                                    id += comboBox_monday3t.Text[i];
                                }
                                int teacher_id = Convert.ToInt32(id);
                                for (int i = 0; i < teachers.Length; i++)
                                {
                                    if (teachers[i].id == teacher_id)
                                    {
                                        if (teachers[i].monday[2] == 0 || teachers[i].monday[2] == group_id)
                                        {
                                            id = "";
                                            for (int j = comboBox_monday3r.Text.IndexOf('(') + 1; j < comboBox_monday3r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                            {
                                                id += comboBox_monday3r.Text[j];
                                            }
                                            int room_id = Convert.ToInt32(id);
                                            for (int j = 0; j < rooms.Length; j++)
                                            {
                                                if (rooms[j].id == room_id)
                                                {
                                                    if (rooms[i].monday[2] == 0 || rooms[i].monday[2] == group_id)
                                                    {
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        room_unavailable(rooms[i], 1, 3);
                                                        schedule = false;
                                                        break;
                                                    }
                                                }
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            teacher_unavailable(teachers[i], 1, 3);
                                            schedule = false;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (schedule == true)
                            {
                                if (comboBox_monday4l.Text != "")
                                {
                                    id = "";
                                    for (int i = comboBox_monday4l.Text.IndexOf('(') + 1; i < comboBox_monday4l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                    {
                                        id += comboBox_monday4l.Text[i];
                                    }
                                    lesson_id = Convert.ToInt32(id);
                                }
                                else
                                {
                                    lesson_id = 0;
                                }
                                if (lesson_id != 0)
                                {
                                    id = "";
                                    for (int i = comboBox_monday4t.Text.IndexOf('(') + 1; i < comboBox_monday4t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                    {
                                        id += comboBox_monday4t.Text[i];
                                    }
                                    int teacher_id = Convert.ToInt32(id);
                                    for (int i = 0; i < teachers.Length; i++)
                                    {
                                        if (teachers[i].id == teacher_id)
                                        {
                                            if (teachers[i].monday[3] == 0 || teachers[i].monday[3] == group_id)
                                            {
                                                id = "";
                                                for (int j = comboBox_monday4r.Text.IndexOf('(') + 1; j < comboBox_monday4r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                {
                                                    id += comboBox_monday4r.Text[j];
                                                }
                                                int room_id = Convert.ToInt32(id);
                                                for (int j = 0; j < rooms.Length; j++)
                                                {
                                                    if (rooms[j].id == room_id)
                                                    {
                                                        if (rooms[i].monday[3] == 0 || rooms[i].monday[3] == group_id)
                                                        {
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            room_unavailable(rooms[i], 1, 4);
                                                            schedule = false;
                                                            break;
                                                        }
                                                    }
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                teacher_unavailable(teachers[i], 1, 4);
                                                schedule = false;
                                                break;
                                            }
                                        }
                                    }
                                }
                                if (schedule == true)
                                {
                                    if (comboBox_tuesday1l.Text != "")
                                    {
                                        id = "";
                                        for (int i = comboBox_tuesday1l.Text.IndexOf('(') + 1; i < comboBox_tuesday1l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                        {
                                            id += comboBox_tuesday1l.Text[i];
                                        }
                                        lesson_id = Convert.ToInt32(id);
                                    }
                                    else
                                    {
                                        lesson_id = 0;
                                    }
                                    if (lesson_id != 0)
                                    {
                                        id = "";
                                        for (int i = comboBox_tuesday1t.Text.IndexOf('(') + 1; i < comboBox_tuesday1t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                        {
                                            id += comboBox_tuesday1t.Text[i];
                                        }
                                        int teacher_id = Convert.ToInt32(id);
                                        for (int i = 0; i < teachers.Length; i++)
                                        {
                                            if (teachers[i].id == teacher_id)
                                            {
                                                if (teachers[i].tuesday[0] == 0 || teachers[i].tuesday[0] == group_id)
                                                {
                                                    id = "";
                                                    for (int j = comboBox_tuesday1r.Text.IndexOf('(') + 1; j < comboBox_tuesday1r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                    {
                                                        id += comboBox_tuesday1r.Text[j];
                                                    }
                                                    int room_id = Convert.ToInt32(id);
                                                    for (int j = 0; j < rooms.Length; j++)
                                                    {
                                                        if (rooms[j].id == room_id)
                                                        {
                                                            if (rooms[i].tuesday[0] == 0 || rooms[i].tuesday[0] == group_id)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                room_unavailable(rooms[i], 2, 1);
                                                                schedule = false;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    break;
                                                }
                                                else
                                                {
                                                    teacher_unavailable(teachers[i], 2, 1);
                                                    schedule = false;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    if (schedule == true)
                                    {
                                        if (comboBox_tuesday2l.Text != "")
                                        {
                                            id = "";
                                            for (int i = comboBox_tuesday2l.Text.IndexOf('(') + 1; i < comboBox_tuesday2l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                            {
                                                id += comboBox_tuesday2l.Text[i];
                                            }
                                            lesson_id = Convert.ToInt32(id);
                                        }
                                        else
                                        {
                                            lesson_id = 0;
                                        }
                                        if (lesson_id != 0)
                                        {
                                            id = "";
                                            for (int i = comboBox_tuesday2t.Text.IndexOf('(') + 1; i < comboBox_tuesday2t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                            {
                                                id += comboBox_tuesday2t.Text[i];
                                            }
                                            int teacher_id = Convert.ToInt32(id);
                                            for (int i = 0; i < teachers.Length; i++)
                                            {
                                                if (teachers[i].id == teacher_id)
                                                {
                                                    if (teachers[i].tuesday[1] == 0 || teachers[i].tuesday[1] == group_id)
                                                    {
                                                        id = "";
                                                        for (int j = comboBox_tuesday2r.Text.IndexOf('(') + 1; j < comboBox_tuesday2r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                        {
                                                            id += comboBox_tuesday2r.Text[j];
                                                        }
                                                        int room_id = Convert.ToInt32(id);
                                                        for (int j = 0; j < rooms.Length; j++)
                                                        {
                                                            if (rooms[j].id == room_id)
                                                            {
                                                                if (rooms[i].tuesday[1] == 0 || rooms[i].tuesday[1] == group_id)
                                                                {
                                                                    break;
                                                                }
                                                                else
                                                                {
                                                                    room_unavailable(rooms[i], 2, 2);
                                                                    schedule = false;
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        teacher_unavailable(teachers[i], 2, 2);
                                                        schedule = false;
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        if (schedule == true)
                                        {
                                            if (comboBox_tuesday3l.Text != "")
                                            {
                                                id = "";
                                                for (int i = comboBox_tuesday3l.Text.IndexOf('(') + 1; i < comboBox_tuesday3l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                                {
                                                    id += comboBox_tuesday3l.Text[i];
                                                }
                                                lesson_id = Convert.ToInt32(id);
                                            }
                                            else
                                            {
                                                lesson_id = 0;
                                            }
                                            if (lesson_id != 0)
                                            {
                                                id = "";
                                                for (int i = comboBox_tuesday3t.Text.IndexOf('(') + 1; i < comboBox_tuesday3t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                                {
                                                    id += comboBox_tuesday3t.Text[i];
                                                }
                                                int teacher_id = Convert.ToInt32(id);
                                                for (int i = 0; i < teachers.Length; i++)
                                                {
                                                    if (teachers[i].id == teacher_id)
                                                    {
                                                        if (teachers[i].tuesday[2] == 0 || teachers[i].tuesday[2] == group_id)
                                                        {
                                                            id = "";
                                                            for (int j = comboBox_tuesday3r.Text.IndexOf('(') + 1; j < comboBox_tuesday3r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                            {
                                                                id += comboBox_tuesday3r.Text[j];
                                                            }
                                                            int room_id = Convert.ToInt32(id);
                                                            for (int j = 0; j < rooms.Length; j++)
                                                            {
                                                                if (rooms[j].id == room_id)
                                                                {
                                                                    if (rooms[i].tuesday[2] == 0 || rooms[i].tuesday[2] == group_id)
                                                                    {
                                                                        break;
                                                                    }
                                                                    else
                                                                    {
                                                                        room_unavailable(rooms[i], 2, 3);
                                                                        schedule = false;
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            teacher_unavailable(teachers[i], 2, 3);
                                                            schedule = false;
                                                            break;
                                                        }
                                                    }
                                                }
                                            }
                                            if (schedule == true)
                                            {
                                                if (comboBox_tuesday4l.Text != "")
                                                {
                                                    id = "";
                                                    for (int i = comboBox_tuesday4l.Text.IndexOf('(') + 1; i < comboBox_tuesday4l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                                    {
                                                        id += comboBox_tuesday4l.Text[i];
                                                    }
                                                    lesson_id = Convert.ToInt32(id);
                                                }
                                                else
                                                {
                                                    lesson_id = 0;
                                                }
                                                if (lesson_id != 0)
                                                {
                                                    id = "";
                                                    for (int i = comboBox_tuesday4t.Text.IndexOf('(') + 1; i < comboBox_tuesday4t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                                    {
                                                        id += comboBox_tuesday4t.Text[i];
                                                    }
                                                    int teacher_id = Convert.ToInt32(id);
                                                    for (int i = 0; i < teachers.Length; i++)
                                                    {
                                                        if (teachers[i].id == teacher_id)
                                                        {
                                                            if (teachers[i].tuesday[3] == 0 || teachers[i].tuesday[3] == group_id)
                                                            {
                                                                id = "";
                                                                for (int j = comboBox_tuesday4r.Text.IndexOf('(') + 1; j < comboBox_tuesday4r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                                {
                                                                    id += comboBox_tuesday4r.Text[j];
                                                                }
                                                                int room_id = Convert.ToInt32(id);
                                                                for (int j = 0; j < rooms.Length; j++)
                                                                {
                                                                    if (rooms[j].id == room_id)
                                                                    {
                                                                        if (rooms[i].tuesday[3] == 0 || rooms[i].tuesday[3] == group_id)
                                                                        {
                                                                            break;
                                                                        }
                                                                        else
                                                                        {
                                                                            room_unavailable(rooms[i], 2, 4);
                                                                            schedule = false;
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                teacher_unavailable(teachers[i], 2, 4);
                                                                schedule = false;
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                if (schedule == true)
                                                {
                                                    if (comboBox_wednesday1l.Text != "")
                                                    {
                                                        id = "";
                                                        for (int i = comboBox_wednesday1l.Text.IndexOf('(') + 1; i < comboBox_wednesday1l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                                        {
                                                            id += comboBox_wednesday1l.Text[i];
                                                        }
                                                        lesson_id = Convert.ToInt32(id);
                                                    }
                                                    else
                                                    {
                                                        lesson_id = 0;
                                                    }
                                                    if (lesson_id != 0)
                                                    {
                                                        id = "";
                                                        for (int i = comboBox_wednesday1t.Text.IndexOf('(') + 1; i < comboBox_wednesday1t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                                        {
                                                            id += comboBox_wednesday1t.Text[i];
                                                        }
                                                        int teacher_id = Convert.ToInt32(id);
                                                        for (int i = 0; i < teachers.Length; i++)
                                                        {
                                                            if (teachers[i].id == teacher_id)
                                                            {
                                                                if (teachers[i].wednesday[0] == 0 || teachers[i].wednesday[0] == group_id)
                                                                {
                                                                    id = "";
                                                                    for (int j = comboBox_wednesday1r.Text.IndexOf('(') + 1; j < comboBox_wednesday1r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                                    {
                                                                        id += comboBox_wednesday1r.Text[j];
                                                                    }
                                                                    int room_id = Convert.ToInt32(id);
                                                                    for (int j = 0; j < rooms.Length; j++)
                                                                    {
                                                                        if (rooms[j].id == room_id)
                                                                        {
                                                                            if (rooms[i].wednesday[0] == 0 || rooms[i].wednesday[0] == group_id)
                                                                            {
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                room_unavailable(rooms[i], 3, 1);
                                                                                schedule = false;
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                                }
                                                                else
                                                                {
                                                                    teacher_unavailable(teachers[i], 3, 1);
                                                                    schedule = false;
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (schedule == true)
                                                    {
                                                        if (comboBox_wednesday2l.Text != "")
                                                        {
                                                            id = "";
                                                            for (int i = comboBox_wednesday2l.Text.IndexOf('(') + 1; i < comboBox_wednesday2l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                                            {
                                                                id += comboBox_wednesday2l.Text[i];
                                                            }
                                                            lesson_id = Convert.ToInt32(id);
                                                        }
                                                        else
                                                        {
                                                            lesson_id = 0;
                                                        }
                                                        if (lesson_id != 0)
                                                        {
                                                            id = "";
                                                            for (int i = comboBox_wednesday2t.Text.IndexOf('(') + 1; i < comboBox_wednesday2t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                                            {
                                                                id += comboBox_wednesday2t.Text[i];
                                                            }
                                                            int teacher_id = Convert.ToInt32(id);
                                                            for (int i = 0; i < teachers.Length; i++)
                                                            {
                                                                if (teachers[i].id == teacher_id)
                                                                {
                                                                    if (teachers[i].wednesday[1] == 0 || teachers[i].wednesday[1] == group_id)
                                                                    {
                                                                        id = "";
                                                                        for (int j = comboBox_wednesday2r.Text.IndexOf('(') + 1; j < comboBox_wednesday2r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                                        {
                                                                            id += comboBox_wednesday2r.Text[j];
                                                                        }
                                                                        int room_id = Convert.ToInt32(id);
                                                                        for (int j = 0; j < rooms.Length; j++)
                                                                        {
                                                                            if (rooms[j].id == room_id)
                                                                            {
                                                                                if (rooms[i].wednesday[1] == 0 || rooms[i].wednesday[1] == group_id)
                                                                                {
                                                                                    break;
                                                                                }
                                                                                else
                                                                                {
                                                                                    room_unavailable(rooms[i], 3, 2);
                                                                                    schedule = false;
                                                                                    break;
                                                                                }
                                                                            }
                                                                        }
                                                                        break;
                                                                    }
                                                                    else
                                                                    {
                                                                        teacher_unavailable(teachers[i], 3, 2);
                                                                        schedule = false;
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        if (schedule == true)
                                                        {
                                                            if (comboBox_wednesday3l.Text != "")
                                                            {
                                                                id = "";
                                                                for (int i = comboBox_wednesday3l.Text.IndexOf('(') + 1; i < comboBox_wednesday3l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                                                {
                                                                    id += comboBox_wednesday3l.Text[i];
                                                                }
                                                                lesson_id = Convert.ToInt32(id);
                                                            }
                                                            else
                                                            {
                                                                lesson_id = 0;
                                                            }
                                                            if (lesson_id != 0)
                                                            {
                                                                id = "";
                                                                for (int i = comboBox_wednesday3t.Text.IndexOf('(') + 1; i < comboBox_wednesday3t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                                                {
                                                                    id += comboBox_wednesday3t.Text[i];
                                                                }
                                                                int teacher_id = Convert.ToInt32(id);
                                                                for (int i = 0; i < teachers.Length; i++)
                                                                {
                                                                    if (teachers[i].id == teacher_id)
                                                                    {
                                                                        if (teachers[i].wednesday[2] == 0 || teachers[i].wednesday[2] == group_id)
                                                                        {
                                                                            id = "";
                                                                            for (int j = comboBox_wednesday3r.Text.IndexOf('(') + 1; j < comboBox_wednesday3r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                                            {
                                                                                id += comboBox_wednesday3r.Text[j];
                                                                            }
                                                                            int room_id = Convert.ToInt32(id);
                                                                            for (int j = 0; j < rooms.Length; j++)
                                                                            {
                                                                                if (rooms[j].id == room_id)
                                                                                {
                                                                                    if (rooms[i].wednesday[2] == 0 || rooms[i].wednesday[2] == group_id)
                                                                                    {
                                                                                        break;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        room_unavailable(rooms[i], 3, 3);
                                                                                        schedule = false;
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                            break;
                                                                        }
                                                                        else
                                                                        {
                                                                            teacher_unavailable(teachers[i], 3, 3);
                                                                            schedule = false;
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            if (schedule == true)
                                                            {
                                                                if (comboBox_wednesday4l.Text != "")
                                                                {
                                                                    id = "";
                                                                    for (int i = comboBox_wednesday4l.Text.IndexOf('(') + 1; i < comboBox_wednesday4l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                                                    {
                                                                        id += comboBox_wednesday4l.Text[i];
                                                                    }
                                                                    lesson_id = Convert.ToInt32(id);
                                                                }
                                                                else
                                                                {
                                                                    lesson_id = 0;
                                                                }
                                                                if (lesson_id != 0)
                                                                {
                                                                    id = "";
                                                                    for (int i = comboBox_wednesday4t.Text.IndexOf('(') + 1; i < comboBox_wednesday4t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                                                    {
                                                                        id += comboBox_wednesday4t.Text[i];
                                                                    }
                                                                    int teacher_id = Convert.ToInt32(id);
                                                                    for (int i = 0; i < teachers.Length; i++)
                                                                    {
                                                                        if (teachers[i].id == teacher_id)
                                                                        {
                                                                            if (teachers[i].wednesday[3] == 0 || teachers[i].wednesday[3] == group_id)
                                                                            {
                                                                                id = "";
                                                                                for (int j = comboBox_wednesday4r.Text.IndexOf('(') + 1; j < comboBox_wednesday4r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                                                {
                                                                                    id += comboBox_wednesday4r.Text[j];
                                                                                }
                                                                                int room_id = Convert.ToInt32(id);
                                                                                for (int j = 0; j < rooms.Length; j++)
                                                                                {
                                                                                    if (rooms[j].id == room_id)
                                                                                    {
                                                                                        if (rooms[i].wednesday[3] == 0 || rooms[i].wednesday[3] == group_id)
                                                                                        {
                                                                                            break;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            room_unavailable(rooms[i], 3, 4);
                                                                                            schedule = false;
                                                                                            break;
                                                                                        }
                                                                                    }
                                                                                }
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                teacher_unavailable(teachers[i], 3, 4);
                                                                                schedule = false;
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                if (schedule == true)
                                                                {
                                                                    if (comboBox_thursday1l.Text != "")
                                                                    {
                                                                        id = "";
                                                                        for (int i = comboBox_thursday1l.Text.IndexOf('(') + 1; i < comboBox_thursday1l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                                                        {
                                                                            id += comboBox_thursday1l.Text[i];
                                                                        }
                                                                        lesson_id = Convert.ToInt32(id);
                                                                    }
                                                                    else
                                                                    {
                                                                        lesson_id = 0;
                                                                    }
                                                                    if (lesson_id != 0)
                                                                    {
                                                                        id = "";
                                                                        for (int i = comboBox_thursday1t.Text.IndexOf('(') + 1; i < comboBox_thursday1t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                                                        {
                                                                            id += comboBox_thursday1t.Text[i];
                                                                        }
                                                                        int teacher_id = Convert.ToInt32(id);
                                                                        for (int i = 0; i < teachers.Length; i++)
                                                                        {
                                                                            if (teachers[i].id == teacher_id)
                                                                            {
                                                                                if (teachers[i].thursday[0] == 0 || teachers[i].thursday[0] == group_id)
                                                                                {
                                                                                    id = "";
                                                                                    for (int j = comboBox_thursday1r.Text.IndexOf('(') + 1; j < comboBox_thursday1r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                                                    {
                                                                                        id += comboBox_thursday1r.Text[j];
                                                                                    }
                                                                                    int room_id = Convert.ToInt32(id);
                                                                                    for (int j = 0; j < rooms.Length; j++)
                                                                                    {
                                                                                        if (rooms[j].id == room_id)
                                                                                        {
                                                                                            if (rooms[i].thursday[0] == 0 || rooms[i].thursday[0] == group_id)
                                                                                            {
                                                                                                break;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                room_unavailable(rooms[i], 4, 1);
                                                                                                schedule = false;
                                                                                                break;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    break;
                                                                                }
                                                                                else
                                                                                {
                                                                                    teacher_unavailable(teachers[i], 4, 1);
                                                                                    schedule = false;
                                                                                    break;
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                    if (schedule == true)
                                                                    {
                                                                        if (comboBox_thursday2l.Text != "")
                                                                        {
                                                                            id = "";
                                                                            for (int i = comboBox_thursday2l.Text.IndexOf('(') + 1; i < comboBox_thursday2l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                                                            {
                                                                                id += comboBox_thursday2l.Text[i];
                                                                            }
                                                                            lesson_id = Convert.ToInt32(id);
                                                                        }
                                                                        else
                                                                        {
                                                                            lesson_id = 0;
                                                                        }
                                                                        if (lesson_id != 0)
                                                                        {
                                                                            id = "";
                                                                            for (int i = comboBox_thursday2t.Text.IndexOf('(') + 1; i < comboBox_thursday2t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                                                            {
                                                                                id += comboBox_thursday2t.Text[i];
                                                                            }
                                                                            int teacher_id = Convert.ToInt32(id);
                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                            {
                                                                                if (teachers[i].id == teacher_id)
                                                                                {
                                                                                    if (teachers[i].thursday[1] == 0 || teachers[i].thursday[1] == group_id)
                                                                                    {
                                                                                        id = "";
                                                                                        for (int j = comboBox_thursday2r.Text.IndexOf('(') + 1; j < comboBox_thursday2r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                                                        {
                                                                                            id += comboBox_thursday2r.Text[j];
                                                                                        }
                                                                                        int room_id = Convert.ToInt32(id);
                                                                                        for (int j = 0; j < rooms.Length; j++)
                                                                                        {
                                                                                            if (rooms[j].id == room_id)
                                                                                            {
                                                                                                if (rooms[i].thursday[1] == 0 || rooms[i].thursday[1] == group_id)
                                                                                                {
                                                                                                    break;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    room_unavailable(rooms[i], 4, 2);
                                                                                                    schedule = false;
                                                                                                    break;
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                        break;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        teacher_unavailable(teachers[i], 4, 2);
                                                                                        schedule = false;
                                                                                        break;
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                        if (schedule == true)
                                                                        {
                                                                            if (comboBox_thursday3l.Text != "")
                                                                            {
                                                                                id = "";
                                                                                for (int i = comboBox_thursday3l.Text.IndexOf('(') + 1; i < comboBox_thursday3l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                                                                {
                                                                                    id += comboBox_thursday3l.Text[i];
                                                                                }
                                                                                lesson_id = Convert.ToInt32(id);
                                                                            }
                                                                            else
                                                                            {
                                                                                lesson_id = 0;
                                                                            }
                                                                            if (lesson_id != 0)
                                                                            {
                                                                                id = "";
                                                                                for (int i = comboBox_thursday3t.Text.IndexOf('(') + 1; i < comboBox_thursday3t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                                                                {
                                                                                    id += comboBox_thursday3t.Text[i];
                                                                                }
                                                                                int teacher_id = Convert.ToInt32(id);
                                                                                for (int i = 0; i < teachers.Length; i++)
                                                                                {
                                                                                    if (teachers[i].id == teacher_id)
                                                                                    {
                                                                                        if (teachers[i].thursday[2] == 0 || teachers[i].thursday[2] == group_id)
                                                                                        {
                                                                                            id = "";
                                                                                            for (int j = comboBox_thursday3r.Text.IndexOf('(') + 1; j < comboBox_thursday3r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                                                            {
                                                                                                id += comboBox_thursday3r.Text[j];
                                                                                            }
                                                                                            int room_id = Convert.ToInt32(id);
                                                                                            for (int j = 0; j < rooms.Length; j++)
                                                                                            {
                                                                                                if (rooms[j].id == room_id)
                                                                                                {
                                                                                                    if (rooms[i].thursday[2] == 0 || rooms[i].thursday[2] == group_id)
                                                                                                    {
                                                                                                        break;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        room_unavailable(rooms[i], 4, 3);
                                                                                                        schedule = false;
                                                                                                        break;
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                            break;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            teacher_unavailable(teachers[i], 4, 3);
                                                                                            schedule = false;
                                                                                            break;
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                            if (schedule == true)
                                                                            {
                                                                                if (comboBox_thursday4l.Text != "")
                                                                                {
                                                                                    id = "";
                                                                                    for (int i = comboBox_thursday4l.Text.IndexOf('(') + 1; i < comboBox_thursday4l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                                                                    {
                                                                                        id += comboBox_thursday4l.Text[i];
                                                                                    }
                                                                                    lesson_id = Convert.ToInt32(id);
                                                                                }
                                                                                else
                                                                                {
                                                                                    lesson_id = 0;
                                                                                }
                                                                                if (lesson_id != 0)
                                                                                {
                                                                                    id = "";
                                                                                    for (int i = comboBox_thursday4t.Text.IndexOf('(') + 1; i < comboBox_thursday4t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                                                                    {
                                                                                        id += comboBox_thursday4t.Text[i];
                                                                                    }
                                                                                    int teacher_id = Convert.ToInt32(id);
                                                                                    for (int i = 0; i < teachers.Length; i++)
                                                                                    {
                                                                                        if (teachers[i].id == teacher_id)
                                                                                        {
                                                                                            if (teachers[i].thursday[3] == 0 || teachers[i].thursday[3] == group_id)
                                                                                            {
                                                                                                id = "";
                                                                                                for (int j = comboBox_thursday4r.Text.IndexOf('(') + 1; j < comboBox_thursday4r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                                                                {
                                                                                                    id += comboBox_thursday4r.Text[j];
                                                                                                }
                                                                                                int room_id = Convert.ToInt32(id);
                                                                                                for (int j = 0; j < rooms.Length; j++)
                                                                                                {
                                                                                                    if (rooms[j].id == room_id)
                                                                                                    {
                                                                                                        if (rooms[i].thursday[3] == 0 || rooms[i].thursday[3] == group_id)
                                                                                                        {
                                                                                                            break;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            room_unavailable(rooms[i], 4, 4);
                                                                                                            schedule = false;
                                                                                                            break;
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                                break;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                teacher_unavailable(teachers[i], 4, 4);
                                                                                                schedule = false;
                                                                                                break;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                                if (schedule == true)
                                                                                {
                                                                                    if (comboBox_friday1l.Text != "")
                                                                                    {
                                                                                        id = "";
                                                                                        for (int i = comboBox_friday1l.Text.IndexOf('(') + 1; i < comboBox_friday1l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                                                                        {
                                                                                            id += comboBox_friday1l.Text[i];
                                                                                        }
                                                                                        lesson_id = Convert.ToInt32(id);
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        lesson_id = 0;
                                                                                    }
                                                                                    if (lesson_id != 0)
                                                                                    {
                                                                                        id = "";
                                                                                        for (int i = comboBox_friday1t.Text.IndexOf('(') + 1; i < comboBox_friday1t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                                                                        {
                                                                                            id += comboBox_friday1t.Text[i];
                                                                                        }
                                                                                        int teacher_id = Convert.ToInt32(id);
                                                                                        for (int i = 0; i < teachers.Length; i++)
                                                                                        {
                                                                                            if (teachers[i].id == teacher_id)
                                                                                            {
                                                                                                if (teachers[i].friday[0] == 0 || teachers[i].friday[0] == group_id)
                                                                                                {
                                                                                                    id = "";
                                                                                                    for (int j = comboBox_friday1r.Text.IndexOf('(') + 1; j < comboBox_friday1r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                                                                    {
                                                                                                        id += comboBox_friday1r.Text[j];
                                                                                                    }
                                                                                                    int room_id = Convert.ToInt32(id);
                                                                                                    for (int j = 0; j < rooms.Length; j++)
                                                                                                    {
                                                                                                        if (rooms[j].id == room_id)
                                                                                                        {
                                                                                                            if (rooms[i].friday[0] == 0 || rooms[i].friday[0] == group_id)
                                                                                                            {
                                                                                                                break;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                room_unavailable(rooms[i], 5, 1);
                                                                                                                schedule = false;
                                                                                                                break;
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                    break;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    teacher_unavailable(teachers[i], 5, 1);
                                                                                                    schedule = false;
                                                                                                    break;
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    if (schedule == true)
                                                                                    {
                                                                                        if (comboBox_friday2l.Text != "")
                                                                                        {
                                                                                            id = "";
                                                                                            for (int i = comboBox_friday2l.Text.IndexOf('(') + 1; i < comboBox_friday2l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                                                                            {
                                                                                                id += comboBox_friday2l.Text[i];
                                                                                            }
                                                                                            lesson_id = Convert.ToInt32(id);
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            lesson_id = 0;
                                                                                        }
                                                                                        if (lesson_id != 0)
                                                                                        {
                                                                                            id = "";
                                                                                            for (int i = comboBox_friday2t.Text.IndexOf('(') + 1; i < comboBox_friday2t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                                                                            {
                                                                                                id += comboBox_friday2t.Text[i];
                                                                                            }
                                                                                            int teacher_id = Convert.ToInt32(id);
                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                            {
                                                                                                if (teachers[i].id == teacher_id)
                                                                                                {
                                                                                                    if (teachers[i].friday[1] == 0 || teachers[i].friday[1] == group_id)
                                                                                                    {
                                                                                                        id = "";
                                                                                                        for (int j = comboBox_friday2r.Text.IndexOf('(') + 1; j < comboBox_friday2r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                                                                        {
                                                                                                            id += comboBox_friday2r.Text[j];
                                                                                                        }
                                                                                                        int room_id = Convert.ToInt32(id);
                                                                                                        for (int j = 0; j < rooms.Length; j++)
                                                                                                        {
                                                                                                            if (rooms[j].id == room_id)
                                                                                                            {
                                                                                                                if (rooms[i].friday[1] == 0 || rooms[i].friday[1] == group_id)
                                                                                                                {
                                                                                                                    break;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    room_unavailable(rooms[i], 5, 2);
                                                                                                                    schedule = false;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                        break;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        teacher_unavailable(teachers[i], 5, 2);
                                                                                                        schedule = false;
                                                                                                        break;
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                        if (schedule == true)
                                                                                        {
                                                                                            if (comboBox_friday3l.Text != "")
                                                                                            {
                                                                                                id = "";
                                                                                                for (int i = comboBox_friday3l.Text.IndexOf('(') + 1; i < comboBox_friday3l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                                                                                {
                                                                                                    id += comboBox_friday3l.Text[i];
                                                                                                }
                                                                                                lesson_id = Convert.ToInt32(id);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                lesson_id = 0;
                                                                                            }
                                                                                            if (lesson_id != 0)
                                                                                            {
                                                                                                id = "";
                                                                                                for (int i = comboBox_friday3t.Text.IndexOf('(') + 1; i < comboBox_friday3t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                                                                                {
                                                                                                    id += comboBox_friday3t.Text[i];
                                                                                                }
                                                                                                int teacher_id = Convert.ToInt32(id);
                                                                                                for (int i = 0; i < teachers.Length; i++)
                                                                                                {
                                                                                                    if (teachers[i].id == teacher_id)
                                                                                                    {
                                                                                                        if (teachers[i].friday[2] == 0 || teachers[i].friday[2] == group_id)
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int j = comboBox_friday3r.Text.IndexOf('(') + 1; j < comboBox_friday3r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                                                                            {
                                                                                                                id += comboBox_friday1r.Text[j];
                                                                                                            }
                                                                                                            int room_id = Convert.ToInt32(id);
                                                                                                            for (int j = 0; j < rooms.Length; j++)
                                                                                                            {
                                                                                                                if (rooms[j].id == room_id)
                                                                                                                {
                                                                                                                    if (rooms[i].friday[2] == 0 || rooms[i].friday[2] == group_id)
                                                                                                                    {
                                                                                                                        break;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        room_unavailable(rooms[i], 5, 3);
                                                                                                                        schedule = false;
                                                                                                                        break;
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                            break;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            teacher_unavailable(teachers[i], 5, 3);
                                                                                                            schedule = false;
                                                                                                            break;
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                            if (schedule == true)
                                                                                            {
                                                                                                if (comboBox_friday4l.Text != "")
                                                                                                {
                                                                                                    id = "";
                                                                                                    for (int i = comboBox_friday4l.Text.IndexOf('(') + 1; i < comboBox_friday4l.Text.IndexOf(')'); i++) //monday lesson 1 id
                                                                                                    {
                                                                                                        id += comboBox_friday4l.Text[i];
                                                                                                    }
                                                                                                    lesson_id = Convert.ToInt32(id);
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    lesson_id = 0;
                                                                                                }
                                                                                                if (lesson_id != 0)
                                                                                                {
                                                                                                    id = "";
                                                                                                    for (int i = comboBox_friday4t.Text.IndexOf('(') + 1; i < comboBox_friday4t.Text.IndexOf(')'); i++) //id of teacher on monday 2 lesson
                                                                                                    {
                                                                                                        id += comboBox_friday4t.Text[i];
                                                                                                    }
                                                                                                    int teacher_id = Convert.ToInt32(id);
                                                                                                    for (int i = 0; i < teachers.Length; i++)
                                                                                                    {
                                                                                                        if (teachers[i].id == teacher_id)
                                                                                                        {
                                                                                                            if (teachers[i].friday[3] == 0 || teachers[i].friday[3] == group_id)
                                                                                                            {
                                                                                                                id = "";
                                                                                                                for (int j = comboBox_friday4r.Text.IndexOf('(') + 1; j < comboBox_friday4r.Text.IndexOf(')'); j++) //id of room on monday 1 lesson
                                                                                                                {
                                                                                                                    id += comboBox_friday4r.Text[j];
                                                                                                                }
                                                                                                                int room_id = Convert.ToInt32(id);
                                                                                                                for (int j = 0; j < rooms.Length; j++)
                                                                                                                {
                                                                                                                    if (rooms[j].id == room_id)
                                                                                                                    {
                                                                                                                        if (rooms[i].friday[3] == 0 || rooms[i].friday[3] == group_id)
                                                                                                                        {
                                                                                                                            break;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            room_unavailable(rooms[i], 5, 4);
                                                                                                                            schedule = false;
                                                                                                                            break;
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                                break;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                teacher_unavailable(teachers[i], 5, 4);
                                                                                                                schedule = false;
                                                                                                                break;
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                                if (schedule == true)
                                                                                                {
                                                                                                    string teacher_id;
                                                                                                    string room_id;

                                                                                                    int group_to_change = 0;
                                                                                                    for (int i = 0; i < group.Length; i++)
                                                                                                    {
                                                                                                        if(group[i].id == group_id)
                                                                                                        {
                                                                                                            group_to_change = i;
                                                                                                        }
                                                                                                    }
                                                                                                    //write 'Continue? Y/N'
                                                                                                    if (true) //here must be result of "Continue"
                                                                                                    {
                                                                                                        for (int i = 0; i < 4; i++)
                                                                                                        {
                                                                                                            group[group_to_change].monday[i] = 0;
                                                                                                            group[group_to_change].tuesday[i] = 0;
                                                                                                            group[group_to_change].wednesday[i] = 0;
                                                                                                            group[group_to_change].thursday[i] = 0;
                                                                                                            group[group_to_change].friday[i] = 0;
                                                                                                            group[group_to_change].monday_teacher[i] = 0;
                                                                                                            group[group_to_change].tuesday_teacher[i] = 0;
                                                                                                            group[group_to_change].wednesday_teacher[i] = 0;
                                                                                                            group[group_to_change].thursday_teacher[i] = 0;
                                                                                                            group[group_to_change].friday_teacher[i] = 0;
                                                                                                            group[group_to_change].monday_room[i] = 0;
                                                                                                            group[group_to_change].tuesday_room[i] = 0;
                                                                                                            group[group_to_change].wednesday_room[i] = 0;
                                                                                                            group[group_to_change].thursday_room[i] = 0;
                                                                                                            group[group_to_change].friday_room[i] = 0;
                                                                                                        }
                                                                                                        for (int i = 0; i < teachers.Length; i++)
                                                                                                        {
                                                                                                            for(int j = 0; j < 4; j++)
                                                                                                            {
                                                                                                                if(teachers[i].monday[j] == group_id)
                                                                                                                {
                                                                                                                    teachers[i].monday[j] = 0;
                                                                                                                }
                                                                                                                if (teachers[i].tuesday[j] == group_id)
                                                                                                                {
                                                                                                                    teachers[i].tuesday[j] = 0;
                                                                                                                }
                                                                                                                if (teachers[i].wednesday[j] == group_id)
                                                                                                                {
                                                                                                                    teachers[i].wednesday[j] = 0;
                                                                                                                }
                                                                                                                if (teachers[i].thursday[j] == group_id)
                                                                                                                {
                                                                                                                    teachers[i].thursday[j] = 0;
                                                                                                                }
                                                                                                                if (teachers[i].friday[j] == group_id)
                                                                                                                {
                                                                                                                    teachers[i].friday[j] = 0;
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                        for (int i = 0; i < rooms.Length; i++)
                                                                                                        {
                                                                                                            for (int j = 0; j < 4; j++)
                                                                                                            {
                                                                                                                if (rooms[i].monday[j] == group_id)
                                                                                                                {
                                                                                                                    rooms[i].monday[j] = 0;
                                                                                                                }
                                                                                                                if (rooms[i].tuesday[j] == group_id)
                                                                                                                {
                                                                                                                    rooms[i].tuesday[j] = 0;
                                                                                                                }
                                                                                                                if (rooms[i].wednesday[j] == group_id)
                                                                                                                {
                                                                                                                    rooms[i].wednesday[j] = 0;
                                                                                                                }
                                                                                                                if (rooms[i].thursday[j] == group_id)
                                                                                                                {
                                                                                                                    rooms[i].thursday[j] = 0;
                                                                                                                }
                                                                                                                if (rooms[i].friday[j] == group_id)
                                                                                                                {
                                                                                                                    rooms[i].friday[j] = 0;
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                        if (comboBox_monday1l.Text != "(0)" && comboBox_monday1l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_monday1l.Text.IndexOf("(") + 1; i < comboBox_monday1l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_monday1l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].monday[0] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_monday1t.Text.IndexOf("(") + 1; i < comboBox_monday1t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_monday1t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].monday[0] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].monday_teacher[0] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_monday1r.Text.IndexOf("(") + 1; i < comboBox_monday1r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_monday1r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].monday[0] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].monday_room[0] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_monday2l.Text != "(0)" && comboBox_monday2l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_monday2l.Text.IndexOf("(") + 1; i < comboBox_monday2l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_monday2l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].monday[1] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_monday2t.Text.IndexOf("(") + 1; i < comboBox_monday2t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_monday2t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].monday[1] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].monday_teacher[1] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_monday2r.Text.IndexOf("(") + 1; i < comboBox_monday2r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_monday2r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].monday[1] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].monday_room[1] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_monday3l.Text != "(0)" && comboBox_monday3l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_monday3l.Text.IndexOf("(") + 1; i < comboBox_monday3l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_monday3l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].monday[2] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_monday3t.Text.IndexOf("(") + 1; i < comboBox_monday3t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_monday3t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].monday[2] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].monday_teacher[2] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_monday3r.Text.IndexOf("(") + 1; i < comboBox_monday3r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_monday3r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].monday[2] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].monday_room[2] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_monday4l.Text != "(0)" && comboBox_monday4l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_monday4l.Text.IndexOf("(") + 1; i < comboBox_monday4l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_monday4l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].monday[3] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_monday4t.Text.IndexOf("(") + 1; i < comboBox_monday4t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_monday4t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].monday[3] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].monday_teacher[3] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_monday4r.Text.IndexOf("(") + 1; i < comboBox_monday4r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_monday4r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].monday[3] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].monday_room[3] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_tuesday1l.Text != "(0)" && comboBox_tuesday1l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_tuesday1l.Text.IndexOf("(") + 1; i < comboBox_tuesday1l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_tuesday1l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].tuesday[0] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_tuesday1t.Text.IndexOf("(") + 1; i < comboBox_tuesday1t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_tuesday1t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].tuesday[0] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].tuesday_teacher[0] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_tuesday1r.Text.IndexOf("(") + 1; i < comboBox_tuesday1r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_tuesday1r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].tuesday[0] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].tuesday_room[0] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_tuesday2l.Text != "(0)" && comboBox_tuesday2l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_tuesday2l.Text.IndexOf("(") + 1; i < comboBox_tuesday2l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_tuesday2l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].tuesday[1] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_tuesday2t.Text.IndexOf("(") + 1; i < comboBox_tuesday2t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_tuesday2t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].tuesday[1] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].tuesday_teacher[1] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_tuesday2r.Text.IndexOf("(") + 1; i < comboBox_tuesday2r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_tuesday2r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].tuesday[1] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].tuesday_room[1] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_tuesday3l.Text != "(0)" && comboBox_tuesday3l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_tuesday3l.Text.IndexOf("(") + 1; i < comboBox_tuesday3l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_tuesday3l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].tuesday[2] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_tuesday3t.Text.IndexOf("(") + 1; i < comboBox_tuesday3t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_tuesday3t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].tuesday[2] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].tuesday_teacher[2] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_tuesday3r.Text.IndexOf("(") + 1; i < comboBox_tuesday3r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_tuesday3r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].tuesday[2] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].tuesday_room[2] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_tuesday4l.Text != "(0)" && comboBox_tuesday4l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_tuesday4l.Text.IndexOf("(") + 1; i < comboBox_tuesday4l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_tuesday4l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].tuesday[3] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_tuesday4t.Text.IndexOf("(") + 1; i < comboBox_tuesday4t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_tuesday4t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].tuesday[3] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].tuesday_teacher[3] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_tuesday4r.Text.IndexOf("(") + 1; i < comboBox_tuesday4r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_tuesday4r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].tuesday[3] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].tuesday_room[3] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_wednesday1l.Text != "(0)" && comboBox_wednesday1l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_wednesday1l.Text.IndexOf("(") + 1; i < comboBox_wednesday1l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_wednesday1l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].wednesday[0] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_wednesday1t.Text.IndexOf("(") + 1; i < comboBox_wednesday1t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_wednesday1t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].wednesday[0] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].wednesday_teacher[0] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_wednesday1r.Text.IndexOf("(") + 1; i < comboBox_wednesday1r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_wednesday1r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].wednesday[0] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].wednesday_room[0] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_wednesday2l.Text != "(0)" && comboBox_wednesday2l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_wednesday2l.Text.IndexOf("(") + 1; i < comboBox_wednesday2l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_wednesday2l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].wednesday[1] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_wednesday2t.Text.IndexOf("(") + 1; i < comboBox_wednesday2t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_wednesday2t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].wednesday[1] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].wednesday_teacher[1] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_wednesday2r.Text.IndexOf("(") + 1; i < comboBox_wednesday2r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_wednesday2r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].wednesday[1] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].wednesday_room[1] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_wednesday3l.Text != "(0)" && comboBox_wednesday3l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_wednesday3l.Text.IndexOf("(") + 1; i < comboBox_wednesday3l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_wednesday3l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].wednesday[2] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_wednesday3t.Text.IndexOf("(") + 1; i < comboBox_wednesday3t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_wednesday3t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].wednesday[2] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].wednesday_teacher[2] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_wednesday3r.Text.IndexOf("(") + 1; i < comboBox_wednesday3r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_wednesday3r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].wednesday[2] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].wednesday_room[2] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_wednesday4l.Text != "(0)" && comboBox_wednesday4l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_wednesday4l.Text.IndexOf("(") + 1; i < comboBox_wednesday4l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_wednesday4l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].wednesday[3] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_wednesday4t.Text.IndexOf("(") + 1; i < comboBox_wednesday4t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_wednesday4t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].wednesday[3] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].wednesday_teacher[3] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_wednesday4r.Text.IndexOf("(") + 1; i < comboBox_wednesday4r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_wednesday4r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].wednesday[3] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].wednesday_room[3] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_thursday1l.Text != "(0)" && comboBox_thursday1l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_thursday1l.Text.IndexOf("(") + 1; i < comboBox_thursday1l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_thursday1l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].thursday[0] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_thursday1t.Text.IndexOf("(") + 1; i < comboBox_thursday1t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_thursday1t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].thursday[0] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].thursday_teacher[0] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_thursday1r.Text.IndexOf("(") + 1; i < comboBox_thursday1r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_thursday1r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].thursday[0] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].thursday_room[0] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_thursday2l.Text != "(0)" && comboBox_thursday2l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_thursday2l.Text.IndexOf("(") + 1; i < comboBox_thursday2l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_thursday2l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].thursday[1] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_thursday2t.Text.IndexOf("(") + 1; i < comboBox_thursday2t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_thursday2t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].thursday[1] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].thursday_teacher[1] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_thursday2r.Text.IndexOf("(") + 1; i < comboBox_thursday2r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_thursday2r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].thursday[1] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].thursday_room[1] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_thursday3l.Text != "(0)" && comboBox_thursday3l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_thursday3l.Text.IndexOf("(") + 1; i < comboBox_thursday3l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_thursday3l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].thursday[2] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_thursday3t.Text.IndexOf("(") + 1; i < comboBox_thursday3t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_thursday3t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].thursday[2] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].thursday_teacher[2] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_thursday3r.Text.IndexOf("(") + 1; i < comboBox_thursday3r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_thursday3r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].thursday[2] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].thursday_room[2] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_thursday4l.Text != "(0)" && comboBox_thursday4l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_thursday4l.Text.IndexOf("(") + 1; i < comboBox_thursday4l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_thursday4l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].thursday[3] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_thursday4t.Text.IndexOf("(") + 1; i < comboBox_thursday4t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_thursday4t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].thursday[3] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].thursday_teacher[3] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_thursday4r.Text.IndexOf("(") + 1; i < comboBox_thursday4r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_thursday4r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].thursday[3] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].thursday_room[3] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_friday1l.Text != "(0)" && comboBox_friday1l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_friday1l.Text.IndexOf("(") + 1; i < comboBox_friday1l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_friday1l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].friday[0] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_friday1t.Text.IndexOf("(") + 1; i < comboBox_friday1t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_friday1t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].friday[0] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].friday_teacher[0] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_friday1r.Text.IndexOf("(") + 1; i < comboBox_friday1r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_friday1r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].friday[0] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].friday_room[0] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_friday2l.Text != "(0)" && comboBox_friday2l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_friday2l.Text.IndexOf("(") + 1; i < comboBox_friday2l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_friday2l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].friday[1] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_friday2t.Text.IndexOf("(") + 1; i < comboBox_friday2t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_friday2t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].friday[1] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].friday_teacher[1] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_friday2r.Text.IndexOf("(") + 1; i < comboBox_friday2r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_friday2r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].friday[1] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].friday_room[1] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_friday3l.Text != "(0)" && comboBox_friday3l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_friday3l.Text.IndexOf("(") + 1; i < comboBox_friday3l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_friday3l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].friday[2] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_friday3t.Text.IndexOf("(") + 1; i < comboBox_friday3t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_friday3t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].friday[2] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].friday_teacher[2] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_friday3r.Text.IndexOf("(") + 1; i < comboBox_friday3r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_friday3r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].friday[2] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].friday_room[2] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        if (comboBox_friday4l.Text != "(0)" && comboBox_friday4l.Text != "")
                                                                                                        {
                                                                                                            id = "";
                                                                                                            for (int i = comboBox_friday4l.Text.IndexOf("(") + 1; i < comboBox_friday4l.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                id += comboBox_friday4l.Text[i];
                                                                                                            }
                                                                                                            group[group_to_change].friday[3] = Convert.ToInt32(id);
                                                                                                            teacher_id = "";
                                                                                                            for (int i = comboBox_friday4t.Text.IndexOf("(") + 1; i < comboBox_friday4t.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                teacher_id += comboBox_friday4t.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < teachers.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(teachers[i].id) == teacher_id)
                                                                                                                {
                                                                                                                    teachers[i].friday[3] = group_id;
                                                                                                                    break;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].friday_teacher[3] = Convert.ToInt32(teacher_id);
                                                                                                            room_id = "";
                                                                                                            for (int i = comboBox_friday4r.Text.IndexOf("(") + 1; i < comboBox_friday4r.Text.IndexOf(")"); i++)
                                                                                                            {
                                                                                                                room_id += comboBox_friday4r.Text[i];
                                                                                                            }
                                                                                                            for (int i = 0; i < rooms.Length; i++)
                                                                                                            {
                                                                                                                if (Convert.ToString(rooms[i].id) == room_id)
                                                                                                                {
                                                                                                                    rooms[i].friday[3] = group_id;
                                                                                                                }
                                                                                                            }
                                                                                                            group[group_to_change].friday_room[3] = Convert.ToInt32(room_id);
                                                                                                        }
                                                                                                        group[group_to_change].update_data();
                                                                                                        for (int i = 0; i < teachers.Length; i++)
                                                                                                        {
                                                                                                            teachers[i].update_data();
                                                                                                        }
                                                                                                        for(int i = 0; i < rooms.Length; i++)
                                                                                                        {
                                                                                                            rooms[i].update_data();
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                string log;
                log = ex.Message;
                //write "Some fields for teachers or rooms are empty"
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                comboBox_monday1l.Items.Clear();
                comboBox_monday2l.Items.Clear();
                comboBox_monday3l.Items.Clear();
                comboBox_monday4l.Items.Clear();
                comboBox_tuesday1l.Items.Clear();
                comboBox_tuesday2l.Items.Clear();
                comboBox_tuesday3l.Items.Clear();
                comboBox_tuesday4l.Items.Clear();
                comboBox_wednesday1l.Items.Clear();
                comboBox_wednesday2l.Items.Clear();
                comboBox_wednesday3l.Items.Clear();
                comboBox_wednesday4l.Items.Clear();
                comboBox_thursday1l.Items.Clear();
                comboBox_thursday2l.Items.Clear();
                comboBox_thursday3l.Items.Clear();
                comboBox_thursday4l.Items.Clear();
                comboBox_friday1l.Items.Clear();
                comboBox_friday2l.Items.Clear();
                comboBox_friday3l.Items.Clear();
                comboBox_friday4l.Items.Clear();
                comboBox_monday1t.Items.Clear();
                comboBox_monday2t.Items.Clear();
                comboBox_monday3t.Items.Clear();
                comboBox_monday4t.Items.Clear();
                comboBox_tuesday1t.Items.Clear();
                comboBox_tuesday2t.Items.Clear();
                comboBox_tuesday3t.Items.Clear();
                comboBox_tuesday4t.Items.Clear();
                comboBox_wednesday1t.Items.Clear();
                comboBox_wednesday2t.Items.Clear();
                comboBox_wednesday3t.Items.Clear();
                comboBox_wednesday4t.Items.Clear();
                comboBox_thursday1t.Items.Clear();
                comboBox_thursday2t.Items.Clear();
                comboBox_thursday3t.Items.Clear();
                comboBox_thursday4t.Items.Clear();
                comboBox_friday1t.Items.Clear();
                comboBox_friday2t.Items.Clear();
                comboBox_friday3t.Items.Clear();
                comboBox_friday4t.Items.Clear();
                comboBox_monday1r.Items.Clear();
                comboBox_monday2r.Items.Clear();
                comboBox_monday3r.Items.Clear();
                comboBox_monday4r.Items.Clear();
                comboBox_tuesday1r.Items.Clear();
                comboBox_tuesday2r.Items.Clear();
                comboBox_tuesday3r.Items.Clear();
                comboBox_tuesday4r.Items.Clear();
                comboBox_wednesday1r.Items.Clear();
                comboBox_wednesday2r.Items.Clear();
                comboBox_wednesday3r.Items.Clear();
                comboBox_wednesday4r.Items.Clear();
                comboBox_thursday1r.Items.Clear();
                comboBox_thursday2r.Items.Clear();
                comboBox_thursday3r.Items.Clear();
                comboBox_thursday4r.Items.Clear();
                comboBox_friday1r.Items.Clear();
                comboBox_friday2r.Items.Clear();
                comboBox_friday3r.Items.Clear();
                comboBox_friday4r.Items.Clear();
                comboBox_monday1l.Text = "";
                comboBox_monday2l.Text = "";
                comboBox_monday3l.Text = "";
                comboBox_monday4l.Text = "";
                comboBox_tuesday1l.Text = "";
                comboBox_tuesday2l.Text = "";
                comboBox_tuesday3l.Text = "";
                comboBox_tuesday4l.Text = "";
                comboBox_wednesday1l.Text = "";
                comboBox_wednesday2l.Text = "";
                comboBox_wednesday3l.Text = "";
                comboBox_wednesday4l.Text = "";
                comboBox_thursday1l.Text = "";
                comboBox_thursday2l.Text = "";
                comboBox_thursday3l.Text = "";
                comboBox_thursday4l.Text = "";
                comboBox_friday1l.Text = "";
                comboBox_friday2l.Text = "";
                comboBox_friday3l.Text = "";
                comboBox_friday4l.Text = "";
                comboBox_monday1t.Text = "";
                comboBox_monday2t.Text = "";
                comboBox_monday3t.Text = "";
                comboBox_monday4t.Text = "";
                comboBox_tuesday1t.Text = "";
                comboBox_tuesday2t.Text = "";
                comboBox_tuesday3t.Text = "";
                comboBox_tuesday4t.Text = "";
                comboBox_wednesday1t.Text = "";
                comboBox_wednesday2t.Text = "";
                comboBox_wednesday3t.Text = "";
                comboBox_wednesday4t.Text = "";
                comboBox_thursday1t.Text = "";
                comboBox_thursday2t.Text = "";
                comboBox_thursday3t.Text = "";
                comboBox_thursday4t.Text = "";
                comboBox_friday1t.Text = "";
                comboBox_friday2t.Text = "";
                comboBox_friday3t.Text = "";
                comboBox_friday4t.Text = "";
                comboBox_monday1r.Text = "";
                comboBox_monday2r.Text = "";
                comboBox_monday3r.Text = "";
                comboBox_monday4r.Text = "";
                comboBox_tuesday1r.Text = "";
                comboBox_tuesday2r.Text = "";
                comboBox_tuesday3r.Text = "";
                comboBox_tuesday4r.Text = "";
                comboBox_wednesday1r.Text = "";
                comboBox_wednesday2r.Text = "";
                comboBox_wednesday3r.Text = "";
                comboBox_wednesday4r.Text = "";
                comboBox_thursday1r.Text = "";
                comboBox_thursday2r.Text = "";
                comboBox_thursday3r.Text = "";
                comboBox_thursday4r.Text = "";
                comboBox_friday1r.Text = "";
                comboBox_friday2r.Text = "";
                comboBox_friday3r.Text = "";
                comboBox_friday4r.Text = "";
                string id = "";
                for (int i = comboBox1.Text.IndexOf('(') + 1; i < comboBox1.Text.IndexOf(')'); i++)
                {
                    id += comboBox1.Text[i];
                }
                for (int i = 0; i < group.Length; i++)
                {
                    if (Convert.ToString(group[i].id) == id)
                    {
                        for(int j = 0; j < group[i].number_of_lessons; j++)
                        {
                            Lesson lesson = new Lesson();
                            lesson.id = group[i].lesson[j];
                            lesson.read_data();
                            comboBox_monday1l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_monday2l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_monday3l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_monday4l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_tuesday1l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_tuesday2l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_tuesday3l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_tuesday4l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_wednesday1l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_wednesday2l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_wednesday3l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_wednesday4l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_thursday1l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_thursday2l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_thursday3l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_thursday4l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_friday1l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_friday2l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_friday3l.Items.Add(lesson.name + " (" + lesson.id + ")");
                            comboBox_friday4l.Items.Add(lesson.name + " (" + lesson.id + ")");
                        }
                        comboBox_monday1l.Items.Add("(0)");
                        comboBox_monday2l.Items.Add("(0)");
                        comboBox_monday3l.Items.Add("(0)");
                        comboBox_monday4l.Items.Add("(0)");
                        comboBox_tuesday1l.Items.Add("(0)");
                        comboBox_tuesday2l.Items.Add("(0)");
                        comboBox_tuesday3l.Items.Add("(0)");
                        comboBox_tuesday4l.Items.Add("(0)");
                        comboBox_wednesday1l.Items.Add("(0)");
                        comboBox_wednesday2l.Items.Add("(0)");
                        comboBox_wednesday3l.Items.Add("(0)");
                        comboBox_wednesday4l.Items.Add("(0)");
                        comboBox_thursday1l.Items.Add("(0)");
                        comboBox_thursday2l.Items.Add("(0)");
                        comboBox_thursday3l.Items.Add("(0)");
                        comboBox_thursday4l.Items.Add("(0)");
                        comboBox_friday1l.Items.Add("(0)");
                        comboBox_friday2l.Items.Add("(0)");
                        comboBox_friday3l.Items.Add("(0)");
                        comboBox_friday4l.Items.Add("(0)");
                        if (group[i].monday[0] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if(lessons[j].id == group[i].monday[0])
                                {
                                    comboBox_monday1l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].monday_teacher[0])
                                {
                                    comboBox_monday1t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].monday_room[0])
                                {
                                    comboBox_monday1r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].monday[1] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].monday[1])
                                {
                                    comboBox_monday2l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].monday_teacher[1])
                                {
                                    comboBox_monday2t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].monday_room[1])
                                {
                                    comboBox_monday2r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].monday[2] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].monday[2])
                                {
                                    comboBox_monday3l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].monday_teacher[2])
                                {
                                    comboBox_monday3t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].monday_room[2])
                                {
                                    comboBox_monday3r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].monday[3] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].monday[3])
                                {
                                    comboBox_monday4l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].monday_teacher[3])
                                {
                                    comboBox_monday4t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].monday_room[3])
                                {
                                    comboBox_monday4r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].tuesday[0] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].tuesday[0])
                                {
                                    comboBox_tuesday1l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].tuesday_teacher[0])
                                {
                                    comboBox_tuesday1t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].tuesday_room[0])
                                {
                                    comboBox_tuesday1r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].tuesday[1] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].tuesday[1])
                                {
                                    comboBox_tuesday2l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].tuesday_teacher[1])
                                {
                                    comboBox_tuesday2t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].tuesday_room[1])
                                {
                                    comboBox_tuesday2r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].tuesday[2] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].tuesday[2])
                                {
                                    comboBox_tuesday3l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].tuesday_teacher[2])
                                {
                                    comboBox_tuesday3t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].tuesday_room[2])
                                {
                                    comboBox_tuesday3r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].tuesday[3] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].tuesday[3])
                                {
                                    comboBox_tuesday4l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].tuesday_teacher[3])
                                {
                                    comboBox_tuesday4t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].tuesday_room[3])
                                {
                                    comboBox_tuesday4r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].wednesday[0] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].wednesday[0])
                                {
                                    comboBox_wednesday1l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].wednesday_teacher[0])
                                {
                                    comboBox_wednesday1t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].wednesday_room[0])
                                {
                                    comboBox_wednesday1r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].wednesday[1] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].wednesday[1])
                                {
                                    comboBox_wednesday2l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].wednesday_teacher[1])
                                {
                                    comboBox_wednesday2t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].wednesday_room[1])
                                {
                                    comboBox_wednesday2r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].wednesday[2] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].wednesday[2])
                                {
                                    comboBox_wednesday3l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].wednesday_teacher[2])
                                {
                                    comboBox_wednesday3t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].wednesday_room[2])
                                {
                                    comboBox_wednesday3r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].wednesday[3] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].wednesday[3])
                                {
                                    comboBox_wednesday4l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].wednesday_teacher[3])
                                {
                                    comboBox_wednesday4t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].wednesday_room[3])
                                {
                                    comboBox_wednesday4r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].thursday[0] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].thursday[0])
                                {
                                    comboBox_thursday1l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].thursday_teacher[0])
                                {
                                    comboBox_thursday1t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].thursday_room[0])
                                {
                                    comboBox_thursday1r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].thursday[1] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].thursday[1])
                                {
                                    comboBox_thursday2l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].thursday_teacher[1])
                                {
                                    comboBox_thursday2t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].thursday_room[1])
                                {
                                    comboBox_thursday2r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].thursday[2] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].thursday[2])
                                {
                                    comboBox_thursday3l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].thursday_teacher[2])
                                {
                                    comboBox_thursday3t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].thursday_room[2])
                                {
                                    comboBox_thursday3r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].thursday[3] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].thursday[3])
                                {
                                    comboBox_thursday4l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].thursday_teacher[3])
                                {
                                    comboBox_thursday4t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].thursday_room[3])
                                {
                                    comboBox_thursday4r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].friday[0] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].friday[0])
                                {
                                    comboBox_friday1l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].friday_teacher[0])
                                {
                                    comboBox_friday1t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].friday_room[0])
                                {
                                    comboBox_friday1r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].friday[1] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].friday[1])
                                {
                                    comboBox_friday2l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].friday_teacher[1])
                                {
                                    comboBox_friday2t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].friday_room[1])
                                {
                                    comboBox_friday2r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].friday[2] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].friday[2])
                                {
                                    comboBox_friday3l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].friday_teacher[2])
                                {
                                    comboBox_friday3t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].friday_room[2])
                                {
                                    comboBox_friday3r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        if (group[i].friday[3] != 0)
                        {
                            for (int j = 0; j < lessons.Length; j++)
                            {
                                if (lessons[j].id == group[i].friday[3])
                                {
                                    comboBox_friday4l.Text = lessons[j].name + " (" + lessons[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < teachers.Length; j++)
                            {
                                if (teachers[j].id == group[i].friday_teacher[3])
                                {
                                    comboBox_friday4t.Text = teachers[j].surename + " " + teachers[j].name + " " + teachers[j].middlename + " (" + teachers[j].id + ")";
                                    break;
                                }
                            }
                            for (int j = 0; j < rooms.Length; j++)
                            {
                                if (rooms[j].id == group[i].friday_room[3])
                                {
                                    comboBox_friday4r.Text = rooms[j].name + " (" + rooms[j].id + ")";
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                //write 'group not chosen' error
            }
        }

        public void set_form() //to be used after changes to database
        {
            comboBox1.Items.Clear();
            Queue<int> queue = new Queue<int>();
            queue = Program.select_id("groups");
            int group_count = queue.Count;
            group = new Group[group_count]; //this one is global
            for (int i = 0; i < group_count; i++)
            {
                group[i] = new Group();
                group[i].id = queue.Peek();
                queue.Dequeue();
                group[i].read_data();
                string element = group[i].name + " (" + Convert.ToString(group[i].id) + ")";
                comboBox1.Items.Add(element);
            }
        }

        Teacher[] set_teacher()
        {
            Queue<int> queue = Program.select_id("teachers");
            int number_of_teachers = queue.Count;
            Teacher[] teacher = new Teacher[number_of_teachers];
            for(int i = 0; i < number_of_teachers; i++)
            {
                teacher[i] = new Teacher();
                teacher[i].id = queue.Peek();
                queue.Dequeue();
                teacher[i].read_data();
            }
            return teacher;
        }

        Lesson[] set_lesson()
        {
            Queue<int> queue = Program.select_id("lessons");
            int number_of_lessons = queue.Count;
            Lesson[] lesson = new Lesson[number_of_lessons];
            for (int i = 0; i < number_of_lessons; i++)
            {
                lesson[i] = new Lesson();
                lesson[i].id = queue.Peek();
                queue.Dequeue();
                lesson[i].read_data();
            }
            return lesson;
        }

        Room[] set_room()
        {
            Queue<int> queue = Program.select_id("rooms");
            int number_of_rooms = queue.Count;
            Room[] room = new Room[number_of_rooms];
            for (int i = 0; i < number_of_rooms; i++)
            {
                room[i] = new Room();
                room[i].id = queue.Peek();
                queue.Dequeue();
                room[i].read_data();
            }
            return room;
        }

        private void comboBox_monday1l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_monday1t.Items.Clear();
            comboBox_monday1r.Items.Clear();
            string id = "";
            for (int i = comboBox_monday1l.Text.IndexOf('(') + 1; i < comboBox_monday1l.Text.IndexOf(')'); i++)
            {
                id += comboBox_monday1l.Text[i];
            }
            if (id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_monday1t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }

                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_monday1r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_monday1r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
            
        }

        private void comboBox_monday2l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_monday2t.Items.Clear();
            comboBox_monday2r.Items.Clear();
            string id = "";
            for (int i = comboBox_monday2l.Text.IndexOf('(') + 1; i < comboBox_monday2l.Text.IndexOf(')'); i++)
            {
                id += comboBox_monday2l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_monday2t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }

                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_monday2r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_monday2r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_monday3l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_monday3t.Items.Clear();
            comboBox_monday3r.Items.Clear();
            string id = "";
            for (int i = comboBox_monday3l.Text.IndexOf('(') + 1; i < comboBox_monday3l.Text.IndexOf(')'); i++)
            {
                id += comboBox_monday3l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_monday3t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_monday3r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_monday3r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_monday4l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_monday4t.Items.Clear();
            comboBox_monday4r.Items.Clear();
            string id = "";
            for (int i = comboBox_monday4l.Text.IndexOf('(') + 1; i < comboBox_monday4l.Text.IndexOf(')'); i++)
            {
                id += comboBox_monday4l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_monday4t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_monday4r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_monday4r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_tuesday1l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_tuesday1t.Items.Clear();
            comboBox_tuesday1r.Items.Clear();
            string id = "";
            for (int i = comboBox_tuesday1l.Text.IndexOf('(') + 1; i < comboBox_tuesday1l.Text.IndexOf(')'); i++)
            {
                id += comboBox_tuesday1l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_tuesday1t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_tuesday1r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_tuesday1r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_tuesday2l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_tuesday2t.Items.Clear();
            comboBox_tuesday2r.Items.Clear();
            string id = "";
            for (int i = comboBox_tuesday2l.Text.IndexOf('(') + 1; i < comboBox_tuesday2l.Text.IndexOf(')'); i++)
            {
                id += comboBox_tuesday2l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_tuesday2t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_tuesday2r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_tuesday2r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }

            }
        }

        private void comboBox_tuesday3l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_tuesday3t.Items.Clear();
            comboBox_tuesday3r.Items.Clear();
            string id = "";
            for (int i = comboBox_tuesday3l.Text.IndexOf('(') + 1; i < comboBox_tuesday3l.Text.IndexOf(')'); i++)
            {
                id += comboBox_tuesday3l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_tuesday3t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_tuesday3r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_tuesday3r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_tuesday4l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_tuesday4t.Items.Clear();
            comboBox_tuesday4r.Items.Clear();
            string id = "";
            for (int i = comboBox_tuesday4l.Text.IndexOf('(') + 1; i < comboBox_tuesday4l.Text.IndexOf(')'); i++)
            {
                id += comboBox_tuesday4l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_tuesday4t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_tuesday4r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_tuesday4r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_wednesday1l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_wednesday1t.Items.Clear();
            comboBox_wednesday1r.Items.Clear();
            string id = "";
            for (int i = comboBox_wednesday1l.Text.IndexOf('(') + 1; i < comboBox_wednesday1l.Text.IndexOf(')'); i++)
            {
                id += comboBox_wednesday1l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_wednesday1t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_wednesday1r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_wednesday1r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }

            }
        }

        private void comboBox_wednesday2l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_wednesday2t.Items.Clear();
            comboBox_wednesday2r.Items.Clear();
            string id = "";
            for (int i = comboBox_wednesday2l.Text.IndexOf('(') + 1; i < comboBox_wednesday2l.Text.IndexOf(')'); i++)
            {
                id += comboBox_wednesday2l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_wednesday2t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_wednesday2r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_wednesday2r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_wednesday3l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_wednesday3t.Items.Clear();
            comboBox_wednesday3r.Items.Clear();
            string id = "";
            for (int i = comboBox_wednesday3l.Text.IndexOf('(') + 1; i < comboBox_wednesday3l.Text.IndexOf(')'); i++)
            {
                id += comboBox_wednesday3l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_wednesday3t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_wednesday3r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_wednesday3r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_wednesday4l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_wednesday4t.Items.Clear();
            comboBox_wednesday4r.Items.Clear();
            string id = "";
            for (int i = comboBox_wednesday4l.Text.IndexOf('(') + 1; i < comboBox_wednesday4l.Text.IndexOf(')'); i++)
            {
                id += comboBox_wednesday4l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_wednesday4t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_wednesday4r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_wednesday4r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_thursday1l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_thursday1t.Items.Clear();
            comboBox_thursday1r.Items.Clear();
            string id = "";
            for (int i = comboBox_thursday1l.Text.IndexOf('(') + 1; i < comboBox_thursday1l.Text.IndexOf(')'); i++)
            {
                id += comboBox_thursday1l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_thursday1t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_thursday1r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_thursday1r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_thursday2l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_thursday2t.Items.Clear();
            comboBox_thursday2r.Items.Clear();
            string id = "";
            for (int i = comboBox_thursday2l.Text.IndexOf('(') + 1; i < comboBox_thursday2l.Text.IndexOf(')'); i++)
            {
                id += comboBox_thursday2l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_thursday2t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_thursday2r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_thursday2r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_thursday3l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_thursday3t.Items.Clear();
            comboBox_thursday3r.Items.Clear();
            string id = "";
            for (int i = comboBox_thursday3l.Text.IndexOf('(') + 1; i < comboBox_thursday3l.Text.IndexOf(')'); i++)
            {
                id += comboBox_thursday3l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_thursday3t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_thursday3r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_thursday3r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_thursday4l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_thursday4t.Items.Clear();
            comboBox_thursday4r.Items.Clear();
            string id = "";
            for (int i = comboBox_thursday4l.Text.IndexOf('(') + 1; i < comboBox_thursday4l.Text.IndexOf(')'); i++)
            {
                id += comboBox_thursday4l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_thursday4t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_thursday4r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_thursday4r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_friday1l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_friday1t.Items.Clear();
            comboBox_friday1r.Items.Clear();
            string id = "";
            for (int i = comboBox_friday1l.Text.IndexOf('(') + 1; i < comboBox_friday1l.Text.IndexOf(')'); i++)
            {
                id += comboBox_friday1l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_friday1t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_friday1r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_friday1r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_friday2l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_friday2t.Items.Clear();
            comboBox_friday2r.Items.Clear();
            string id = "";
            for (int i = comboBox_friday2l.Text.IndexOf('(') + 1; i < comboBox_friday2l.Text.IndexOf(')'); i++)
            {
                id += comboBox_friday2l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_friday2t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_friday2r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_friday2r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_friday3l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_friday3t.Items.Clear();
            comboBox_friday3r.Items.Clear();
            string id = "";
            for (int i = comboBox_friday3l.Text.IndexOf('(') + 1; i < comboBox_friday3l.Text.IndexOf(')'); i++)
            {
                id += comboBox_friday3l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_friday3t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_friday3r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_friday3r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void comboBox_friday4l_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_friday4t.Items.Clear();
            comboBox_friday4r.Items.Clear();
            string id = "";
            for (int i = comboBox_friday4l.Text.IndexOf('(') + 1; i < comboBox_friday4l.Text.IndexOf(')'); i++)
            {
                id += comboBox_friday4l.Text[i];
            }
            if(id != "0")
            {
                for (int i = 0; i < teachers.Length; i++)
                {
                    for (int j = 0; j < teachers[i].number_of_lessons; j++)
                    {
                        if (Convert.ToString(teachers[i].lesson[j]) == id)
                        {
                            comboBox_friday4t.Items.Add(teachers[i].surename + " " + teachers[i].name + " " + teachers[i].middlename + " (" + teachers[i].id + ")");
                        }
                    }
                }
                Lesson lesson = new Lesson();
                lesson.id = Convert.ToInt32(id);
                lesson.read_data();
                if (lesson.equipment != 0)
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].equipment == lesson.equipment)
                        {
                            comboBox_friday4r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rooms.Length; i++)
                    {
                        comboBox_friday1r.Items.Add(rooms[i].name + " (" + rooms[i].id + ")");
                    }
                }
            }
        }

        private void teacher_unavailable(Teacher teacher, int day, int lesson)
        {
            string current_day = "";
            switch(day) //translate this
            {
                case 1: current_day = "monday"; break;
                case 2: current_day = "tuesday"; break;
                case 3: current_day = "wednesday"; break;
                case 4: current_day = "thursday"; break;
                case 5: current_day = "friday"; break;
            }
            //write "Teacher " + teacher.surename + " " + teacher.name + " " + teacher.surename + " unavailable at " + current_day " on " + lesson + "lesson"
        }

        private void room_unavailable(Room room, int day, int lesson)
        {
            string current_day = "";
            switch (day) //translate this
            {
                case 1: current_day = "monday"; break;
                case 2: current_day = "tuesday"; break;
                case 3: current_day = "wednesday"; break;
                case 4: current_day = "thursday"; break;
                case 5: current_day = "friday"; break;
            }
            //write "Room " + room.name + " unavailable at " + current_day + " on " + lesson + " lesson"
        }
    }
}