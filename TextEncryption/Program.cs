using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEncryption
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
            Application.Run(new Form1());
        }
    }

    class Clent
    {
        string le;

        public Clent(string m)
        {
            le = m;
        }

        public string Repl(string m, int key) //замена символа m на символ со смещением
        {
            int pos = le.IndexOf(m);
            if (pos == -1) return ""; //символ в этой ленте не найден
            pos = (pos + key) % le.Length; //если смещение больше одного круга
            if (pos < 0) pos += le.Length;
            return le.Substring(pos, 1);
        }
    }

    class Cezar : System.Collections.Generic.List<Clent>
    {
        public Cezar()
        { //в конструкторе формирую коллекцию лент
            this.Add(new Clent("abcdefghijklmnopqrstuvwxyz"));
            this.Add(new Clent("ABCDEFGHIJKLMNOPQRSTUVWXYZ"));
            this.Add(new Clent("абвгдеёжзийклмнопрстуфхцчшщъыьэюя"));
            this.Add(new Clent("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"));
            this.Add(new Clent("0123456789"));
            this.Add(new Clent("!\"#$%^&*()+=-_'?.,|/`~№:;@[]{}"));
        }

        public string Codeс(string m, int key) //кодирование и декодирование в зависимости от знака ключа
        {
            string res = "", tmp = "";
            for (int i = 0; i < m.Length; i++)
            {
                foreach (Clent v in this)
                {
                    tmp = v.Repl(m.Substring(i, 1), key);
                    if (tmp != "") //нужная лента найдена, замена символу определена
                    {
                        res += tmp;
                        break; // прерывается foreach (перебор лент)
                    }
                }
                if (tmp == "") res += m.Substring(i, 1); //незнакомый символ оставляю без изменений
            }
            return res;
        }
    }
}
