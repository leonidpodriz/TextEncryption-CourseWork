using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TextEncryption
{
    public partial class MainForm : Form
    {
        int workMode = 0; // 0 - encrypt, 1 - decrypt, 2 - decrypt without key
        CezarCipher cipher = new CezarCipher();
        string[] dictionary;
        string ENCODE_BUTTON_TEXT = "Кодувати",
               DECODE_BUTTON_TEXT = "Декодувати";

        public MainForm()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            decodingWorcker.WorkerReportsProgress = true;
            decodingWorcker.WorkerSupportsCancellation = true;
            decodingWorcker.DoWork += new DoWorkEventHandler(decodingWorker_DoWork);
            decodingWorcker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(decodingWorcker_RunWorkerCompleted);
            decodingWorcker.ProgressChanged += new ProgressChangedEventHandler(decodingWorker_ProgressChanged);
        }

        private void updateKey(object sender, EventArgs e)
        {
            this.cipher.setKey(Decimal.ToInt16(this.KeyTextBox.Value));
        }

        private void setMode(int modeNumber, string buttonText)
        {
            this.workMode = modeNumber;
            this.SubmitButton.Text = buttonText;
            this.ResultTextBox.Text = "";
        }

        private void setEncodeMode(object sender, EventArgs e)
        {
            setMode(0, ENCODE_BUTTON_TEXT);
        }

        private void setDecodeMode(object sender, EventArgs e)
        {
            setMode(1, DECODE_BUTTON_TEXT);
        }

        private void setDecodeWithoutKeyMode(object sender, EventArgs e)
        {
            setMode(2, DECODE_BUTTON_TEXT);
        }

        private void clearSourceTextBox()
        {
            this.SourceTextBox.Text = "";
        }

        private void clearResultTextBox()
        {
            this.ResultTextBox.Text = "";
        }

        private void clearTextBoxes(object sender, EventArgs e)
        {
            clearSourceTextBox();
            clearResultTextBox();
        }

        private void processText(object sender, EventArgs e)
        {
            switch (workMode)
            {
                case 0:
                    this.ResultTextBox.Text = cipher.Encode(SourceTextBox.Text);
                    break;
                case 1:
                    this.ResultTextBox.Text = cipher.Decode(SourceTextBox.Text);
                    break;
                case 2:
                    if (dictionary != null)
                    {
                        startBruteForce();
                        break;
                    }

                    ResultTextBox.Text = "Словник не вказаний!";
                    break;
            }
        }

        private void startBruteForce()
        {
            DecodeRadioButton.Enabled = false;
            EncodeRadioButton.Enabled = false;
            DecodeWithoutKeyRadioButton.Enabled = false;

            CezarCipherBruteForce brutForcer = new CezarCipherBruteForce(dictionary, SourceTextBox.Text);
            decodingWorcker.RunWorkerAsync(brutForcer);
        }

        private void stopBruteForce(object sender, EventArgs e)
        {
            if (decodingWorcker.IsBusy)
            {
                decodingWorcker.CancelAsync();
            }
        }

        private string getFileNameWithDialog()
        {
            string fileText = "";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"С:\",
                Title = "Відкрийте текстовоий файл",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileText = System.IO.File.ReadAllText(openFileDialog1.FileName);
                MessageBox.Show("Вміст файлу завантажено!", "Успіх", buttons, MessageBoxIcon.Information);
            }

            return fileText;
        }

        private void decodingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            CezarCipherBruteForce brutForcer = (CezarCipherBruteForce)e.Argument;
            BackgroundWorker worker = sender as BackgroundWorker;

            brutForcer.setWorcker(worker);
            brutForcer.setDoWorkEventArgs(e);
            e.Result = brutForcer.getResult();
        }

        private void decodingWorcker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                ResultTextBox.Text = "Зупинено користувачем.";
            } else
            {
                ResultTextBox.Text = e.Result.ToString();
            }
            DecodeRadioButton.Enabled = true;
            EncodeRadioButton.Enabled = true;
            DecodeWithoutKeyRadioButton.Enabled = true;
        }

        private void decodingWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void LoadTextForTextToProcessBox(object sender, EventArgs e)
        {
            this.SourceTextBox.Text = this.getFileNameWithDialog();
        }

        private void saveResult(object sender, System.EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.Title = "Зберегти результат";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        writer.WriteLine(this.ResultTextBox.Text);
                        break;
                }

                writer.Dispose();
                writer.Close();
            }
        }

        private void LoadDictionary(object sender, EventArgs e)
        {
            string dictionaryText = getFileNameWithDialog();
            dictionary = dictionaryText.Split('\n', ' ');
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
