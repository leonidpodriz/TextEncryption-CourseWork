using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextEncryption
{
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
                            MessageBox.Show($"Ключ: {-i}\nЗбіг по слову: {s}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return decodedText;
                        }

                        if (isCanceled())
                        {
                            return "";
                        }
                    }
                }

            }
            return "Шифр не розпізнано";
        }
    }
}
