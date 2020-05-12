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
    public partial class PPsettings : Form
    {
        public PPsettings()
        {
            InitializeComponent();
        }

       
        
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

                //texts
                warnrel = "Reload program and save sattings",

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
                warn = "Warning";

            this.Text = settings;
            label1.Text = setting1;
            label2.Text = setting2;
            label3.Text = setting3;
            button1.Text = backbutton;
            button2.Text = savebutton;
        }
        private void rulanguge()
        {
            ///langpack///
            string
                setting1 = "Отображение времени в центре",
                setting2 = "Шкала прогресса пары",
                setting3 = "Язык",
                savebutton = "Сохранить",
                backbutton = "Назад",
                settingstitle = "Настройки";

            this.Text = settingstitle;
            label1.Text = setting1;
            label2.Text = setting2;
            label3.Text = setting3;
            button1.Text = backbutton;
            button2.Text = savebutton;

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
                name = "Ім'я",
                surname = "Прізвище",
                patronymic = "По батькові",
                editpass = "Редагувати пароль",
                newpass = "Новий пароль",
                confirmpass = "Підтвердіть пароль",
                yid = "Ваш ID",
                foraccept = "Для підтвердження змін в профілі або його видалення, введіть пароль",
                id = "Ідентифікаційний код",
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

            this.Text = settings;
            label1.Text = setting1;
            label2.Text = setting2;
            label3.Text = setting3;
            button1.Text = backbutton;
            button2.Text = savebutton;
        }

        public int lang = 0; 
        private void PPsettings_Load(object sender, EventArgs e)
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
                checkBox1.Checked = true;
            }
            if (Convert.ToInt32(set[1]) == 49)
            {
                checkBox2.Checked = true;
            }
            comboBox1.SelectedIndex = Convert.ToInt32(set[2]) - 48;
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
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool chose=false;
            using (var form = new PPsave_settings())
            {
                var result = form.ShowDialog();
                chose = form.chose;
            }
            if (chose)
            {
                string settings = "";
                var path = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                using (FileStream fstream = new FileStream($"{path}/settings.txt", FileMode.OpenOrCreate))
                {
                    if (checkBox1.Checked)
                    {
                        settings += "time = 1\n";
                    }
                    else settings += "time = 0\n"; ;
                    if (checkBox2.Checked)
                    {
                        settings += "progressbar = 1\n";
                    }
                    else settings += "progressbar = 0\n";
                    if (comboBox1.SelectedIndex == 1) settings += "languge = 1";
                    else if (comboBox1.SelectedIndex == 2) settings += "languge = 2";
                    else settings += "languge = 0";

                    byte[] array = System.Text.Encoding.Default.GetBytes(settings);

                    fstream.Write(array, 0, array.Length);
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
