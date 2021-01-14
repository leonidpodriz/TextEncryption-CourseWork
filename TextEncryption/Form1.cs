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
        private readonly CezarCipher cipher = new CezarCipher();
        string[] dictionary;
        private readonly string ENCODE_BUTTON_TEXT = "Кодувати",
               DECODE_BUTTON_TEXT = "Декодувати";

        public MainForm()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            KeyTextBox.Value = CezarCipher.DEFAULT_KEY;
            decodingWorcker.WorkerReportsProgress = true;
            decodingWorcker.WorkerSupportsCancellation = true;
            decodingWorcker.DoWork += new DoWorkEventHandler(DecodingWorker_DoWork);
            decodingWorcker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(DecodingWorcker_RunWorkerCompleted);
            decodingWorcker.ProgressChanged += new ProgressChangedEventHandler(DecodingWorker_ProgressChanged);
        }

        private void UpdateKey(object sender, EventArgs e)
        {
            this.cipher.SetKey(Decimal.ToInt16(this.KeyTextBox.Value));
        }

        private void SetMode(int modeNumber, string buttonText)
        {
            this.workMode = modeNumber;
            this.submitButton.Text = buttonText;
            this.resultTextBox.Text = "";
        }

        private void SetEncodeMode(object sender, EventArgs e)
        {
            SetMode(0, ENCODE_BUTTON_TEXT);
        }

        private void SetDecodeMode(object sender, EventArgs e)
        {
            SetMode(1, DECODE_BUTTON_TEXT);
        }

        private void SetDecodeWithoutKeyMode(object sender, EventArgs e)
        {
            SetMode(2, DECODE_BUTTON_TEXT);
        }

        private void ClearSourceTextBox()
        {
            this.sourceTextBox.Text = "";
        }

        private void ClearResultTextBox()
        {
            this.resultTextBox.Text = "";
        }

        private void ClearTextBoxes(object sender, EventArgs e)
        {
            ClearSourceTextBox();
            ClearResultTextBox();
        }

        private void ProcessText(object sender, EventArgs e)
        {
            switch (workMode)
            {
                case 0:
                    this.resultTextBox.Text = cipher.Encode(sourceTextBox.Text);
                    break;
                case 1:
                    this.resultTextBox.Text = cipher.Decode(sourceTextBox.Text);
                    break;
                case 2:
                    if (dictionary != null)
                    {
                        StartBruteForce();
                        break;
                    }

                    resultTextBox.Text = "Словник не вказаний!";
                    break;
            }
        }

        private void StartBruteForce()
        {
            DecodeRadioButton.Enabled = false;
            EncodeRadioButton.Enabled = false;
            DecodeWithoutKeyRadioButton.Enabled = false;

            CezarCipherBruteForce brutForcer = new CezarCipherBruteForce(dictionary, sourceTextBox.Text);
            decodingWorcker.RunWorkerAsync(brutForcer);
        }

        private void StopBruteForce(object sender, EventArgs e)
        {
            if (decodingWorcker.IsBusy)
            {
                decodingWorcker.CancelAsync();
            }
        }

        private string GetFileNameWithDialog()
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

        private void DecodingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            CezarCipherBruteForce brutForcer = (CezarCipherBruteForce)e.Argument;
            BackgroundWorker worker = sender as BackgroundWorker;

            brutForcer.SetWorcker(worker);
            brutForcer.SetDoWorkEventArgs(e);
            e.Result = brutForcer.GetResult();
        }

        private void DecodingWorcker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                resultTextBox.Text = "Зупинено користувачем.";
            } else
            {
                resultTextBox.Text = e.Result.ToString();
            }
            DecodeRadioButton.Enabled = true;
            EncodeRadioButton.Enabled = true;
            DecodeWithoutKeyRadioButton.Enabled = true;
        }

        private void DecodingWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            buckgroundProcessProgressBar.Value = e.ProgressPercentage;
        }

        private void LoadTextForTextToProcessBox(object sender, EventArgs e)
        {
            this.sourceTextBox.Text = this.GetFileNameWithDialog();
        }

        private void SaveResult(object sender, System.EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt",
                Title = "Зберегти результат"
            };
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        writer.WriteLine(this.resultTextBox.Text);
                        break;
                }

                writer.Dispose();
                writer.Close();
            }
        }

        private void LoadDictionary(object sender, EventArgs e)
        {
            string dictionaryText = GetFileNameWithDialog();
            dictionary = dictionaryText.Split('\n', ' ');
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
