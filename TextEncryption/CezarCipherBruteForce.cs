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

        public void SetWorker(BackgroundWorker worker)
        {
            this.worker = worker;
        }

        public void UpdateProgressIfWorker(int percentComplete)
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

        private string GetDecodedTextByKey(int key)
        {
            return cipher.Codeс(text, key);
        }

        private string[] GetDecodedWordsByKey(int key)
        {
            return GetDecodedTextByKey(key).Split(' ', '\n');
        }

        private void ShowSuccessMessageBox(int key, string word)
        {
            MessageBox.Show($"Ключ: {-key}\nЗбіг по слову: {word}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsWordsSame(string firstWord, string secondWord)
        {
            return firstWord.ToLower() == secondWord.ToLower();
        }

        public string GetResult()
        {
            for (int key = -1; key >= -32; key--)
            {
                string[] decodedWords = GetDecodedWordsByKey(key);
                UpdateProgressIfWorker(Convert.ToInt32((-key * 100 / 32)));

                foreach (string decodedWord in decodedWords)
                {
                    foreach (string dictionaryWord in dictionary)
                    {
                        if (IsWordsSame(decodedWord, dictionaryWord) & decodedWord != "")
                        {
                            UpdateProgressIfWorker(100);
                            ShowSuccessMessageBox(key, decodedWord);
                            return GetDecodedTextByKey(key);
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
