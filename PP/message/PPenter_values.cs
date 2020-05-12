using PP.message;
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
    public partial class PPenter_values : Form
    {
        public PPenter_values()
        {
            InitializeComponent();
        }
        public int change; //great idea, poor implementation
        public bool update; //it will be loaded from previous form
        public int sent_id; //work for all forms
        public string sent_name; //work for all forms
        public string sent_surename; //work for teacher only
        public string sent_middlename; //work for teacher only
        public int sent_equipment; //work for rooms and lessons
        public int sent_number_of_lessons; //work for teachers and groups
        public int[] sent_lesson; //work for teachers and groups
        public int[] sent_monday; //work for teachers and groups
        public int[] sent_tuesday; //work for teachers and groups
        public int[] sent_wednesday; //work for teachers and groups
        public int[] sent_thursday; //work for teachers and groups
        public int[] sent_friday; //work for teachers and groups
        Group group = new Group(); //and all this classes explain why is this idea sucks
        Room room = new Room(); //you literaly need to create everything that could be in this form 
        Lesson lesson = new Lesson(); //and it eats a lot (i think) more memory (and code cleaningness) than 4 separate forms
        Teacher teacher = new Teacher(); //and this code is a mess
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
              warn = "Warning",


            //new
            addgroup = "Add group",
            addlesson = "Add lesson",
            addclass = "Add audience",
            addteacher = "Add teacher",
            l1t = "Surname",
            l1g = "Name",
            l1l = "Name",
            l1c = "Name",
            l2t = "Name",
            l3t = "Middle name",
            rb1 = "Computer",
            rb2 = "Chemic. lab",
            rb3 = "Gym";

            //buttons
            button4.Text = savebutton;
            button3.Text = backbutton;
            button2.Text = add;
            button1.Text = dell;

            radioButton1.Text = rb1;
            radioButton2.Text = rb2;
            radioButton3.Text = rb3;

            switch (change) {
                //teacher
                case 1: 
                    {
                        this.Text = addteacher;
                        label1.Text = l1t;
                        label2.Text = l2t;
                        label3.Text = l3t;
                        break; 
                    }
                //group
                case 2: 
                    {
                        this.Text = addgroup;
                        label1.Text = l1g;
                        break;
                    }
                //class
                case 3: 
                    {
                        this.Text = addclass;
                        label1.Text = l1c;
                        break; 
                    }
                //lesson
                case 4: 
                    {
                        this.Text = addlesson;
                        label1.Text = l1l;
                        break; 
                    }
            }
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
              warn = "Предупреждение",
              addgroup = "Добавить группу",
              addlesson = "Добавить предмет",
              addclass = "Добавить аудиторию",
              addteacher = "Добавить преподавателя",
              l1t = "Фамилия",
              l1g = "Название",
              l1l = "Название",
              l1c = "Название",
              l2t = "Имя",
              l3t = "Отчество",
              rb1 = "Компьютеры",
              rb2 = "Хим. лаб.",
              rb3 = "Спортзал";
 
            //buttons
            button4.Text = savebutton;
            button3.Text = backbutton;
            button2.Text = add;
            button1.Text = dell;

            radioButton1.Text = rb1;
            radioButton2.Text = rb2;
            radioButton3.Text = rb3;

            switch (change)
            {
                //teacher
                case 1:
                    {
                        this.Text = addteacher;
                        label1.Text = l1t;
                        label2.Text = l2t;
                        label3.Text = l3t;
                        break;
                    }
                //group
                case 2:
                    {
                        this.Text = addgroup;
                        label1.Text = l1g;
                        break;
                    }
                //class
                case 3:
                    {
                        this.Text = addclass;
                        label1.Text = l1c;
                        break;
                    }
                //lesson
                case 4:
                    {
                        this.Text = addlesson;
                        label1.Text = l1l;
                        break;
                    }
            }
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
              warn = "Попередження",

              addgroup = "Додати групу",
              addlesson = "Додати предмет",
              addclass = "Додати аудиторію",
              addteacher = "Додати викладча",
              l1t = "Прізвище",
              l1g = "Назва",
              l1l = "Назва",
              l1c = "Назва",
              l2t = "Ім'я", 
              l3t = "По батькові",
              rb1 = "Комп'ютери",
              rb2 = "Хім. лаб.",
              rb3 = "Спортзал";

            //buttons
            button4.Text = savebutton;
            button3.Text = backbutton;
            button2.Text = add;
            button1.Text = dell;

            radioButton1.Text = rb1;
            radioButton2.Text = rb2;
            radioButton3.Text = rb3;

            switch (change)
            {
                //teacher
                case 1:
                    {
                        this.Text = addteacher;
                        label1.Text = l1t;
                        label2.Text = l2t;
                        label3.Text = l3t;
                        break;
                    }
                //group
                case 2:
                    {
                        this.Text = addgroup;
                        label1.Text = l1g;
                        break;
                    }
                //class
                case 3:
                    {
                        this.Text = addclass;
                        label1.Text = l1c;
                        break;
                    }
                //lesson
                case 4:
                    {
                        this.Text = addlesson;
                        label1.Text = l1l;
                        break;
                    }
            }
        }
        public int lang = 0;
        private void PPenter_values_Load(object sender, EventArgs e)
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
            switch (change)
            {
                //teacher
                case 1: label1.Visible = true; label1.Enabled = true; textBox1.Visible = true; textBox1.Enabled = true; label2.Visible = true; label2.Enabled = true; textBox2.Visible = true; textBox2.Enabled = true; label3.Visible = true; label3.Enabled = true; textBox3.Visible = true; textBox3.Enabled = true; groupBox1.Visible = true; textBox4.Visible = true; textBox4.Enabled = true; button4.Location = new Point(257, 202); this.Size = new Size(360, 275); comboBox1.Visible = true; comboBox1.Enabled = true; button1.Visible = true; button1.Enabled = true; button2.Visible = true; button2.Enabled = true; break;
                //grup
                case 2: label1.Visible = true; label1.Enabled = true; textBox1.Visible = true; textBox1.Enabled = true; groupBox1.Visible = true; textBox4.Visible = true; textBox4.Enabled = true; button4.Location = new Point(257, 202); this.Size = new Size(360, 275); comboBox1.Visible = true; comboBox1.Enabled = true; button1.Visible = true; button1.Enabled = true; button2.Visible = true; button2.Enabled = true; break;
                //lesson and class
                default: label1.Visible = true; label1.Enabled = true; textBox1.Visible = true; textBox1.Enabled = true; groupBox1.Visible = true; groupBox1.Enabled = true; label1.Location = new Point(12, 12); textBox1.Enabled = true; textBox1.Location = new Point(12, 28); groupBox1.Location = new Point(12, 48); groupBox1.Size = new Size(157, 90); button4.Location = new Point(94, 140); button3.Location = new Point(12, 140); this.Size = new Size(200, 220); break;
            }

            lang = Convert.ToInt32(set[2]) - 48;
            if (lang == 1) { rulanguge(); }
            else if (lang == 2) { ualanguge(); }
            else
            {
                englanguge();
            }
            
            if(update == true)
            {
                switch (change) //set values
                {
                    case 1: set_lessons(); teacher.id = sent_id; teacher.name = sent_name; teacher.surename = sent_surename; teacher.middlename = sent_middlename; teacher.number_of_lessons = sent_number_of_lessons; teacher.lesson = sent_lesson; teacher.monday = sent_monday; teacher.tuesday = sent_tuesday; teacher.wednesday = sent_wednesday; teacher.thursday = sent_thursday; teacher.friday = sent_friday; break;
                    case 2: set_lessons(); group.id = sent_id; group.name = sent_name; group.number_of_lessons = sent_number_of_lessons; group.lesson = sent_lesson; group.monday = sent_monday; group.tuesday = sent_tuesday; group.wednesday = sent_wednesday;  group.thursday = sent_thursday; group.friday = sent_friday; break;
                    case 3: room.id = sent_id; room.name = sent_name; room.equipment = sent_equipment; room.monday = sent_monday; room.tuesday = sent_tuesday; room.wednesday = sent_wednesday; room.thursday = sent_thursday; room.friday = sent_friday; break;
                    case 4: lesson.id = sent_id; lesson.name = sent_name; lesson.equipment = sent_equipment; break;
                }
                if(change == 1)
                {
                    textBox1.Text = teacher.surename;
                    textBox2.Text = teacher.name;
                    textBox3.Text = teacher.middlename;
                }
                else
                {
                    textBox1.Text = sent_name;
                }
                if(sent_equipment == 1)
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    if(sent_equipment == 2)
                    {
                        radioButton2.Checked = true;
                    }
                    else
                    {
                        if(sent_equipment == 3)
                        {
                            radioButton3.Checked = true;
                        }
                    }
                }
                if(sent_lesson != null)
                {
                    refresh_lesson();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string id = "";
            for (int i = comboBox1.Text.IndexOf('(') + 1; i < comboBox1.Text.IndexOf(')'); i++)
            {
                id += comboBox1.Text[i];
            }
            Queue<int> queue = new Queue<int>();
            queue = Program.select_id("lessons");
            int lesson_count = queue.Count;
            Lesson temporary_lesson = new Lesson(); //this one is global
            for (int i = 0; i < lesson_count; i++)
            {
                temporary_lesson = new Lesson();
                temporary_lesson.id = queue.Peek();
                if (Convert.ToString(temporary_lesson.id) == id)
                {
                    if (change == 1)
                    {
                        if (teacher.delete_lesson(temporary_lesson.id) == false)
                        {
                            using (var form = new PPerr_massege())
                            {
                                form.change = 2;
                                var result = form.ShowDialog();
                            }
                        }
                        textBox4.Text = "";
                        for (int j = 0; j < teacher.number_of_lessons; j++)
                        {
                            temporary_lesson.id = teacher.lesson[j];
                            if (temporary_lesson.read_data() == false)
                            {
                                refresh_lesson();
                                using (var form = new PPerr_massege())
                                {
                                    form.change = 3;
                                    var result = form.ShowDialog();
                                }
                                break;
                            }
                            textBox4.Text += temporary_lesson.name + "\r\n";
                        }
                        break;
                    }
                    else
                    {
                        if (group.delete_lesson(temporary_lesson.id) == false)
                        {
                            using (var form = new PPerr_massege())
                            {
                                form.change = 2;
                                var result = form.ShowDialog();
                            }
                        }
                        textBox4.Text = "";
                        for (int j = 0; j < group.number_of_lessons; j++)
                        {
                            temporary_lesson.id = group.lesson[j];
                            if (temporary_lesson.read_data() == false)
                            {
                                refresh_lesson();
                                using (var form = new PPerr_massege())
                                {
                                    form.change = 3;
                                    var result = form.ShowDialog();
                                }
                                break;
                            }
                            textBox4.Text += temporary_lesson.name + "\r\n";
                        }
                        break;
                    }
                }
                queue.Dequeue();
            }
        }

        private void button2_Click(object sender, EventArgs e) //add lessons to teachers and groups
        {
            string id = "";
            for (int i = comboBox1.Text.IndexOf('(') + 1; i < comboBox1.Text.IndexOf(')'); i++)
            {
                id += comboBox1.Text[i];
            }
            Queue<int> queue = new Queue<int>();
            queue = Program.select_id("lessons");
            int lesson_count = queue.Count;
            Lesson temporary_lesson = new Lesson(); //this one is global
            for (int i = 0; i < lesson_count; i++)
            {
                temporary_lesson = new Lesson();
                temporary_lesson.id = queue.Peek();
                if(Convert.ToString(temporary_lesson.id) == id)
                {
                    if(change == 1)
                    {
                        if (teacher.add_lesson(temporary_lesson.id) == false)
                        {
                            using (var form = new PPerr_massege())
                            {
                                form.change = 2;
                                var result = form.ShowDialog();
                            }
                        }
                        textBox4.Text = "";
                        for (int j = 0; j < teacher.number_of_lessons; j++)
                        {
                            temporary_lesson.id = teacher.lesson[j];
                            if (temporary_lesson.read_data() == false)
                            {
                                refresh_lesson();
                                using (var form = new PPerr_massege())
                                {
                                    form.change = 3;
                                    var result = form.ShowDialog();
                                }
                                break;
                            }
                            textBox4.Text += temporary_lesson.name + "\r\n";
                        }
                        break;
                    }
                    else
                    {
                        if(group.add_lesson(temporary_lesson.id) == false)
                        {
                            using (var form = new PPerr_massege())
                            {
                                form.change = 2;
                                var result = form.ShowDialog();
                            }
                        }
                        textBox4.Text = "";
                        for (int j = 0; j < group.number_of_lessons; j++)
                        {
                            temporary_lesson.id = group.lesson[j];
                            if(temporary_lesson.read_data() == false)
                            {
                                refresh_lesson();
                                using (var form = new PPerr_massege())
                                {
                                    form.change = 3;
                                    var result = form.ShowDialog();
                                }
                                break;
                            }
                            textBox4.Text += temporary_lesson.name + "\r\n";
                        }
                        break;
                    }
                }
                queue.Dequeue();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //close
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //save
            switch (change)
            {
                case 1:
                    {
                        if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                        {
                            teacher.surename = textBox1.Text;
                            teacher.name = textBox2.Text;
                            teacher.middlename = textBox3.Text;
                            if (update == true)
                            {
                                if (teacher.update_data() == false)
                                {
                                    using (var form = new PPerr_massege())
                                    {
                                        form.change = 3;
                                        var result = form.ShowDialog();
                                    }
                                }
                                else
                                {
                                    Close();
                                }
                            }
                            else
                            {
                                if (teacher.write_data() == false)
                                {
                                    using (var form = new PPerr_massege())
                                    {
                                        form.change = 3;
                                        var result = form.ShowDialog();
                                    }
                                }
                                else
                                {
                                    Close();
                                }
                            }
                        }
                        else
                        {
                            using (var form = new PPerr_massege())
                            {
                                form.change = 4;
                                var result = form.ShowDialog();
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        if (textBox1.Text != "")
                        {
                            group.name = textBox1.Text;
                            if (update == true)
                            {
                                if (group.update_data() == false)
                                {
                                    using (var form = new PPerr_massege())
                                    {
                                        form.change = 3;
                                        var result = form.ShowDialog();
                                    }
                                }
                                else
                                {
                                    Close();
                                }
                            }
                            else
                            {
                                if (group.write_data() == false)
                                {
                                    using (var form = new PPerr_massege())
                                    {
                                        form.change = 3;
                                        var result = form.ShowDialog();
                                    }
                                }
                                else
                                {
                                    Close();
                                }
                            }
                        }
                        else
                        {
                            using (var form = new PPerr_massege())
                            {
                                form.change = 4;
                                var result = form.ShowDialog();
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        if (textBox1.Text != "")
                        {
                            room.name = textBox1.Text;
                            if (radioButton1.Checked == true)
                            {
                                room.equipment = 1;
                            }
                            else
                            {
                                if (radioButton2.Checked == true)
                                {
                                    room.equipment = 2;
                                }
                                else
                                {
                                    if (radioButton3.Checked == true)
                                    {
                                        room.equipment = 3;
                                    }
                                }
                            }
                            if (update == true)
                            {
                                if (room.update_data() == false)
                                {
                                    using (var form = new PPerr_massege())
                                    {
                                        form.change = 3;
                                        var result = form.ShowDialog();
                                    }
                                }
                                else
                                {
                                    Close();
                                }
                            }
                            else
                            {
                                if (room.write_data() == false)
                                {
                                    using (var form = new PPerr_massege())
                                    {
                                        form.change = 3;
                                        var result = form.ShowDialog();
                                    }
                                }
                                else
                                {
                                    Close();
                                }
                            }
                        }
                        else
                        {
                            using (var form = new PPerr_massege())
                            {
                                form.change = 4;
                                var result = form.ShowDialog();
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        if (textBox1.Text != "")
                        {
                            lesson.name = textBox1.Text;
                            if (radioButton1.Checked == true)
                            {
                                lesson.equipment = 1;
                            }
                            else
                            {
                                if (radioButton2.Checked == true)
                                {
                                    lesson.equipment = 2;
                                }
                                else
                                {
                                    if (radioButton3.Checked == true)
                                    {
                                        lesson.equipment = 3;
                                    }
                                }
                            }
                            if (update == true)
                            {
                                if (lesson.update_data() == false)
                                {
                                    using (var form = new PPerr_massege())
                                    {
                                        form.change = 3;
                                        var result = form.ShowDialog();
                                    }
                                }
                                else
                                {
                                    Close();
                                }
                            }
                            else
                            {
                                if (lesson.write_data() == false)
                                {
                                    using (var form = new PPerr_massege())
                                    {
                                        form.change = 3;
                                        var result = form.ShowDialog();
                                    }
                                }
                                else
                                {
                                    Close();
                                }
                            }
                        }
                        else
                        {
                            using (var form = new PPerr_massege())
                            {
                                form.change = 4;
                                var result = form.ShowDialog();
                            }
                        }
                        break;
                    }
            }
        }

        public void refresh_lesson()
        {
            textBox4.Text = "";
            Lesson temporary_lesson = new Lesson();
            for (int i = 0; i < sent_lesson.Length; i++)
            {
                temporary_lesson.id = sent_lesson[i];
                if(temporary_lesson.id != 0)
                {
                    if (temporary_lesson.read_data() == true)
                    {
                        textBox4.Text += temporary_lesson.name + "\r\n";
                    }
                    else
                    {
                        using (var form = new PPerr_massege())
                        {
                            form.change = 3;
                            var result = form.ShowDialog();
                        }
                    }
                }
            }
        }

        public void set_lessons()
        {
            comboBox1.Items.Clear();
            Queue<int> queue = new Queue<int>();
            queue = Program.select_id("lessons");
            int lesson_count = queue.Count;
            Lesson[] temporary_lesson = new Lesson[lesson_count]; //this one is global
            for (int i = 0; i < lesson_count; i++)
            {
                temporary_lesson[i] = new Lesson();
                temporary_lesson[i].id = queue.Peek();
                queue.Dequeue();
                temporary_lesson[i].read_data();
                string element = temporary_lesson[i].name + " (" + Convert.ToString(temporary_lesson[i].id) + ")";
                comboBox1.Items.Add(element);
            }
        }
    }
}