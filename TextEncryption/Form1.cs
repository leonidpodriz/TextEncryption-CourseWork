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
    public partial class Form1 : Form
    {
        int workMode = 0; // 0 - encrypt, 1 - decrypt, 2 - decrypt without key
        int key = 1;
        Cezar cipher;

        public Form1()
        {
            InitializeComponent();

            this.cipher = new Cezar();
        }

        private void setKey(object sender, EventArgs e)
        {
            try {
                this.key = Int16.Parse(this.KeyTextBox.Text);
            } catch
            {
                if (this.KeyTextBox.Text == "")
                {
                    this.KeyTextBox.Text = "";
                } else
                {
                    this.KeyTextBox.Text = this.key.ToString();
                }
            }
        }

        private void setEncodeMode(object sender, EventArgs e)
        {
            this.workMode = 0;
            this.SubmitButton.Text = "Encode";
            this.ResultTextBox.Text = "";
        }

        private void seDecodeMode(object sender, EventArgs e)
        {
            this.workMode = 1;
            this.SubmitButton.Text = "Decode";
            this.ResultTextBox.Text = "";
        }

        private void setDecodeWithoutKeyMode(object sender, EventArgs e)
        {
            this.workMode = 2;
            this.SubmitButton.Text = "Decode";
            this.ResultTextBox.Text = "";
        }

        private void clearTextBoxes(object sender, EventArgs e)
        {
            this.TextToEncryptBox.Text = "";
            this.ResultTextBox.Text = "";
        }
        private void encodeText(object sender, EventArgs e)
        {
            switch (this.workMode)
            {
                case 0:
                    this.ResultTextBox.Text = cipher.Codeс(this.TextToEncryptBox.Text, this.key);
                    break;
                case 1:
                    this.ResultTextBox.Text = cipher.Codeс(this.TextToEncryptBox.Text, - this.key);
                    break;
                case 2:
                    Console.WriteLine("Start d");
                    for(int i = -1; i >=-32; i--)
                    {
                        string decodedText = cipher.Codeс(this.TextToEncryptBox.Text, i);
                        string[] decodedWords = decodedText.Split(' ', '\n');
                        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\PC\source\repos\TextEncryption\TextEncryption\TextFile1.txt");

                        for (int di = 0; di < decodedWords.Length; di ++)
                        {
                            for (int li = 0; li < lines.Length; li++)
                            {
                                string s = decodedWords[di].ToLower();
                                string t = lines[li].ToLower();
                                Console.WriteLine($"{s} == {t}");

                                if (s == t)
                                {
                                    this.ResultTextBox.Text = decodedText;
                                    break;
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void проПрограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
                string text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.TextToEncryptBox.Text = text;
                MessageBox.Show("Вміст файлу завантажено!", "Успіх", buttons, MessageBoxIcon.Information);
            }
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
    }
}
