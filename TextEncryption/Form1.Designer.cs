
namespace TextEncryption
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.KeyGroupBox = new System.Windows.Forms.GroupBox();
            this.KeyTextBox = new System.Windows.Forms.NumericUpDown();
            this.ModeGroupBox = new System.Windows.Forms.GroupBox();
            this.EncodeRadioButton = new System.Windows.Forms.RadioButton();
            this.DecodeWithoutKeyRadioButton = new System.Windows.Forms.RadioButton();
            this.DecodeRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ClearTextToEncryptBoxButton_1 = new System.Windows.Forms.Button();
            this.SourceTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.ClearTextToEncryptBoxButton_2 = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.проПрограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodingWorcker = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.KeyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyTextBox)).BeginInit();
            this.ModeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyGroupBox
            // 
            this.KeyGroupBox.Controls.Add(this.KeyTextBox);
            this.KeyGroupBox.Location = new System.Drawing.Point(12, 50);
            this.KeyGroupBox.Name = "KeyGroupBox";
            this.KeyGroupBox.Size = new System.Drawing.Size(171, 66);
            this.KeyGroupBox.TabIndex = 1;
            this.KeyGroupBox.TabStop = false;
            this.KeyGroupBox.Text = "Ключ";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(6, 25);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(159, 26);
            this.KeyTextBox.TabIndex = 1;
            this.KeyTextBox.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.KeyTextBox.ValueChanged += new System.EventHandler(this.updateKey);
            // 
            // ModeGroupBox
            // 
            this.ModeGroupBox.Controls.Add(this.EncodeRadioButton);
            this.ModeGroupBox.Controls.Add(this.DecodeWithoutKeyRadioButton);
            this.ModeGroupBox.Controls.Add(this.DecodeRadioButton);
            this.ModeGroupBox.Location = new System.Drawing.Point(201, 50);
            this.ModeGroupBox.Name = "ModeGroupBox";
            this.ModeGroupBox.Size = new System.Drawing.Size(982, 66);
            this.ModeGroupBox.TabIndex = 2;
            this.ModeGroupBox.TabStop = false;
            this.ModeGroupBox.Text = "Режим";
            // 
            // EncodeRadioButton
            // 
            this.EncodeRadioButton.AutoSize = true;
            this.EncodeRadioButton.Checked = true;
            this.EncodeRadioButton.Location = new System.Drawing.Point(6, 25);
            this.EncodeRadioButton.Name = "EncodeRadioButton";
            this.EncodeRadioButton.Size = new System.Drawing.Size(107, 24);
            this.EncodeRadioButton.TabIndex = 3;
            this.EncodeRadioButton.TabStop = true;
            this.EncodeRadioButton.Text = "Кодувати";
            this.EncodeRadioButton.UseVisualStyleBackColor = true;
            this.EncodeRadioButton.CheckedChanged += new System.EventHandler(this.setEncodeMode);
            // 
            // DecodeWithoutKeyRadioButton
            // 
            this.DecodeWithoutKeyRadioButton.AutoSize = true;
            this.DecodeWithoutKeyRadioButton.Location = new System.Drawing.Point(361, 25);
            this.DecodeWithoutKeyRadioButton.Name = "DecodeWithoutKeyRadioButton";
            this.DecodeWithoutKeyRadioButton.Size = new System.Drawing.Size(208, 24);
            this.DecodeWithoutKeyRadioButton.TabIndex = 2;
            this.DecodeWithoutKeyRadioButton.TabStop = true;
            this.DecodeWithoutKeyRadioButton.Text = "Декодувати без ключа";
            this.DecodeWithoutKeyRadioButton.UseVisualStyleBackColor = true;
            this.DecodeWithoutKeyRadioButton.CheckedChanged += new System.EventHandler(this.setDecodeWithoutKeyMode);
            // 
            // DecodeRadioButton
            // 
            this.DecodeRadioButton.AutoSize = true;
            this.DecodeRadioButton.Location = new System.Drawing.Point(173, 25);
            this.DecodeRadioButton.Name = "DecodeRadioButton";
            this.DecodeRadioButton.Size = new System.Drawing.Size(126, 24);
            this.DecodeRadioButton.TabIndex = 1;
            this.DecodeRadioButton.TabStop = true;
            this.DecodeRadioButton.Text = "Декодувати";
            this.DecodeRadioButton.UseVisualStyleBackColor = true;
            this.DecodeRadioButton.CheckedChanged += new System.EventHandler(this.setDecodeMode);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.SubmitButton);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ClearTextToEncryptBoxButton_1);
            this.groupBox1.Controls.Add(this.SourceTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1177, 419);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вхідний текст";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Вибрати словник";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadDictionary);
            // 
            // SubmitButton
            // 
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitButton.Location = new System.Drawing.Point(1009, 367);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(168, 46);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Кодувати";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.processText);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Завантажити з файлу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LoadTextForTextToProcessBox);
            // 
            // ClearTextToEncryptBoxButton_1
            // 
            this.ClearTextToEncryptBoxButton_1.Location = new System.Drawing.Point(6, 367);
            this.ClearTextToEncryptBoxButton_1.Name = "ClearTextToEncryptBoxButton_1";
            this.ClearTextToEncryptBoxButton_1.Size = new System.Drawing.Size(46, 46);
            this.ClearTextToEncryptBoxButton_1.TabIndex = 1;
            this.ClearTextToEncryptBoxButton_1.Text = "X";
            this.ClearTextToEncryptBoxButton_1.UseVisualStyleBackColor = true;
            this.ClearTextToEncryptBoxButton_1.Click += new System.EventHandler(this.clearTextBoxes);
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(6, 25);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(1165, 336);
            this.SourceTextBox.TabIndex = 0;
            this.SourceTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.ClearTextToEncryptBoxButton_2);
            this.groupBox2.Controls.Add(this.ResultTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 567);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1177, 383);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(58, 331);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 46);
            this.button5.TabIndex = 2;
            this.button5.Text = "Зберегти до файлу";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.saveResult);
            // 
            // ClearTextToEncryptBoxButton_2
            // 
            this.ClearTextToEncryptBoxButton_2.Location = new System.Drawing.Point(6, 331);
            this.ClearTextToEncryptBoxButton_2.Name = "ClearTextToEncryptBoxButton_2";
            this.ClearTextToEncryptBoxButton_2.Size = new System.Drawing.Size(46, 46);
            this.ClearTextToEncryptBoxButton_2.TabIndex = 1;
            this.ClearTextToEncryptBoxButton_2.Text = "X";
            this.ClearTextToEncryptBoxButton_2.UseVisualStyleBackColor = true;
            this.ClearTextToEncryptBoxButton_2.Click += new System.EventHandler(this.clearTextBoxes);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(6, 25);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(1165, 300);
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.Text = "";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограммуToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1201, 33);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // проПрограммуToolStripMenuItem
            // 
            this.проПрограммуToolStripMenuItem.Name = "проПрограммуToolStripMenuItem";
            this.проПрограммуToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.проПрограммуToolStripMenuItem.Text = "Про программу";
            this.проПрограммуToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 956);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(952, 50);
            this.progressBar1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(970, 956);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Зупинити перебір";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.stopBruteForce);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1201, 1020);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ModeGroupBox);
            this.Controls.Add(this.KeyGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Шифрування тексту";
            this.KeyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyTextBox)).EndInit();
            this.ModeGroupBox.ResumeLayout(false);
            this.ModeGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox KeyGroupBox;
        private System.Windows.Forms.GroupBox ModeGroupBox;
        private System.Windows.Forms.RadioButton DecodeRadioButton;
        private System.Windows.Forms.RadioButton DecodeWithoutKeyRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox SourceTextBox;
        private System.Windows.Forms.Button ClearTextToEncryptBoxButton_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ClearTextToEncryptBoxButton_2;
        private System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.RadioButton EncodeRadioButton;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem проПрограммуToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown KeyTextBox;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker decodingWorcker;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button3;
    }
}

