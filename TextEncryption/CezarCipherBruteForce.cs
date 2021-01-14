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
        readonly string[] dictionary;
        readonly string text;
        readonly CezarCipher cipher = new CezarCipher();
        BackgroundWorker worker;
        DoWorkEventArgs arguments;

        public CezarCipherBruteForce(string[] dictionary, string text)
        {
            this.dictionary = dictionary;
            this.text = text;
        }

        public void SetWorcker(BackgroundWorker worker)
        {
            this.worker = worker;
        }

        public void UpdateProgressIfWorcker(int percentComplete)
        {
            if (worker != null)
            {
                worker.ReportProgress(percentComplete);
            }
        }

        public void SetDoWorkEventArgs(DoWorkEventArgs arguments)
        {
            this.arguments = arguments;
        }

        public bool IsCanceled()
        {
            if (arguments != null && worker.CancellationPending)
            {
                arguments.Cancel = true;
                return true;
            }

            return false;
        }

        public string GetResult()
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
                            UpdateProgressIfWorcker(100);
                            MessageBox.Show($"Ключ: {-i}\nЗбіг по слову: {s}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return decodedText;
                        }

                        if (IsCanceled())
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
