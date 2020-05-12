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

namespace PP.message
{
    public partial class PPconfirm : Form
    {
        public PPconfirm()
        {
            InitializeComponent();
        }
        public bool confirm { get; set; }
        private void englanguge()
        {
            ///langpack///

            string

                //settings
                setting1 = "Time at center",
                setting2 = "Progress bar",
                setting3 = "Languge",

                //button
                savebutton = "Save",
                backbutton = "Back",
                ok = "OK",
                //texts
                warnrel = "Reload program and save sattings",
                errpass = "Wrong password",

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
                    exit = "Exit",
               view = "View",
                    statistics = "Statistics",
                        students = "Students",
                        teacherss = "Teachers",
                            employment = "Employment",
                    thismoment = "At this moment",
                        couples = "Couples",
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
                settingstitle = "Settings",
                warn = "Warning",
                err = "Error",
                toomany = "Too many values",
                entrall = "Enter all values",

                //new
                yes = "Yes",
                no = "No",
                conf = "Do you confirm the action?",
                titleconf = "Confirm";

            this.Text = titleconf;
            label1.Text = conf;
            button1.Text = no;
            button2.Text = yes;
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
                errpass = "Wrong password",

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
              err = "Ошибка",
              toomany = "Слишком много значений",
              entrall = "Введите все данные",
              yes = "Yes",
              no = "Нет",
              conf = "Продолжить?",
              titleconf = "Да";

            this.Text = titleconf;
            label1.Text = conf;
            button1.Text = no;
            button2.Text = yes;
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
                errpass = "Wrong password",

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
              err = "Помилка",
              toomany = "Занадто багато значень",
              entrall = "Заповніть всі поля",
              yes = "Так",
              no = "Скасувати",
              conf = "Підтвердіть дію.",
              titleconf = "Підтвердити";

            this.Text = titleconf;
            label1.Text = conf;
            button1.Text = no;
            button2.Text = yes;

        }

        public int lang = 0;
        private void PPconfirm_Load(object sender, EventArgs e)
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
            lang = Convert.ToInt32(set[2]) - 48;
            if (lang == 1) { rulanguge(); }
            else if (lang == 2) { ualanguge(); }
            else
            {
                englanguge();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            confirm = false;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            confirm = true;
            Close();
        }
    }
}
