using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEncryption
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    class Sequence
    {
        string value;

        public Sequence(string value)
        {
            this.value = value;
        }

        public string CompareAndReplace(string character, int key) 
        {
            int characterPosition = value.IndexOf(character);
            if (characterPosition == -1) return ""; 

            int replacedCharacterPosition = (characterPosition + key) % value.Length;
            if (replacedCharacterPosition < 0) replacedCharacterPosition += value.Length;

            return value.Substring(replacedCharacterPosition, 1);
        }
    }

    class CezarCipher : System.Collections.Generic.List<Sequence>
    {
        private int key = 13;

        public CezarCipher()
        {
            this.LoadSequences();
        }

        public CezarCipher(int key)
        {
            this.key = key;
            this.LoadSequences();
        }

        private void LoadSequences()
        {
            this.Add(new Sequence("abcdefghijklmnopqrstuvwxyz"));
            this.Add(new Sequence("ABCDEFGHIJKLMNOPQRSTUVWXYZ"));
            this.Add(new Sequence("абвгдеёжзийклмнопрстуфхцчшщъыьэюя"));
            this.Add(new Sequence("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"));
            this.Add(new Sequence("0123456789"));
            this.Add(new Sequence("!\"#$%^&*()+=-_'?.,|/`~№:;@[]{}"));
        }

        public void setKey(int key)
        {
            this.key = key;
        }

        public string Codeс(string text, int key) //кодирование и декодирование в зависимости от знака ключа
        {
            string result = "", replacedCharacter = "";

            for (int characterIndex = 0; characterIndex < text.Length; characterIndex++)
            {
                string character = text.Substring(characterIndex, 1);

                foreach (Sequence sequence in this)
                {
                    replacedCharacter = sequence.CompareAndReplace(character, key);
                    if (replacedCharacter != "") //нужная лента найдена, замена символу определена
                    {
                        result += replacedCharacter;
                        break; // прерывается foreach (перебор лент)
                    }
                }

                if (replacedCharacter == "") result += character; //незнакомый символ оставляю без изменений
            }

            return result;
        }

        public string Encode(string text)
        {
            return this.Codeс(text, this.key);
        }

        public string Decode(string text)
        {
            return this.Codeс(text, -this.key);
        }
    }

    class CezarCipherBruteForce
    {
        string[] dictionary;
        string text;
        BackgroundWorker worker;
        DoWorkEventArgs arguments;
        CezarCipher cipher = new CezarCipher();

        public CezarCipherBruteForce(string[] dictionary, string text)
        {
            this.dictionary = dictionary;
            this.text = text;
        }

        public void setWorcker(BackgroundWorker worker)
        {
            this.worker = worker;
        }

        public void updateProgressIfWorcker(int percentComplete)
        {
            if (worker != null)
            {
                worker.ReportProgress(percentComplete);
            }
        }

        public void setDoWorkEventArgs(DoWorkEventArgs arguments)
        {
            this.arguments = arguments;
        }

        public bool isCanceled()
        {
            if (arguments != null && worker.CancellationPending)
            {
                arguments.Cancel = true;
                return true;
            }

            return false;
        }

        public string getResult()
        {
            for (int i = -1; i >= -32; i--)
            {
                string decodedText = cipher.Codeс(text, i);
                string[] decodedWords = decodedText.Split(' ', '\n');

                int propgressInPercent = Convert.ToInt32((-i * 100 / 32));
                worker.ReportProgress(propgressInPercent);

                for (int di = 0; di < decodedWords.Length; di++)
                {
                    for (int li = 0; li < dictionary.Length; li++)
                    {
                        string s = decodedWords[di].ToLower();
                        string t = dictionary[li].ToLower();


                        if (s == t & s != "")
                        {
                            updateProgressIfWorcker(100);
                            return decodedText;
                        }

                        if (isCanceled())
                        {
                            return "";
                        }
                    }
                }
            }
            return "";
        }
    }
}
