
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
            this.sourceTextGroupBox = new System.Windows.Forms.GroupBox();
            this.selectDictionaryButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.loadFromFileButton = new System.Windows.Forms.Button();
            this.clearTextToEncryptBoxButton_1 = new System.Windows.Forms.Button();
            this.clearTextToEncryptBoxButton_2 = new System.Windows.Forms.Button();
            this.sourceTextBox = new System.Windows.Forms.RichTextBox();
            this.resultTextGroupBox = new System.Windows.Forms.GroupBox();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.topMenuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutProgramTopMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodingWorcker = new System.ComponentModel.BackgroundWorker();
            this.buckgroundProcessProgressBar = new System.Windows.Forms.ProgressBar();
            this.cancelBackgroundProgressButton = new System.Windows.Forms.Button();
            this.KeyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyTextBox)).BeginInit();
            this.ModeGroupBox.SuspendLayout();
            this.sourceTextGroupBox.SuspendLayout();
            this.resultTextGroupBox.SuspendLayout();
            this.topMenuStrip.SuspendLayout();
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
            this.KeyTextBox.ValueChanged += new System.EventHandler(this.UpdateKey);
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
            this.EncodeRadioButton.Size = new System.Drawing.Size(123, 24);
            this.EncodeRadioButton.TabIndex = 3;
            this.EncodeRadioButton.TabStop = true;
            this.EncodeRadioButton.Text = "Шифрувати";
            this.EncodeRadioButton.UseVisualStyleBackColor = true;
            this.EncodeRadioButton.CheckedChanged += new System.EventHandler(this.SetEncodeMode);
            // 
            // DecodeWithoutKeyRadioButton
            // 
            this.DecodeWithoutKeyRadioButton.AutoSize = true;
            this.DecodeWithoutKeyRadioButton.Location = new System.Drawing.Point(291, 25);
            this.DecodeWithoutKeyRadioButton.Name = "DecodeWithoutKeyRadioButton";
            this.DecodeWithoutKeyRadioButton.Size = new System.Drawing.Size(232, 24);
            this.DecodeWithoutKeyRadioButton.TabIndex = 2;
            this.DecodeWithoutKeyRadioButton.TabStop = true;
            this.DecodeWithoutKeyRadioButton.Text = "Розшифрувати без ключа";
            this.DecodeWithoutKeyRadioButton.UseVisualStyleBackColor = true;
            this.DecodeWithoutKeyRadioButton.CheckedChanged += new System.EventHandler(this.SetDecodeWithoutKeyMode);
            // 
            // DecodeRadioButton
            // 
            this.DecodeRadioButton.AutoSize = true;
            this.DecodeRadioButton.Location = new System.Drawing.Point(135, 25);
            this.DecodeRadioButton.Name = "DecodeRadioButton";
            this.DecodeRadioButton.Size = new System.Drawing.Size(150, 24);
            this.DecodeRadioButton.TabIndex = 1;
            this.DecodeRadioButton.TabStop = true;
            this.DecodeRadioButton.Text = "Розшифрувати";
            this.DecodeRadioButton.UseVisualStyleBackColor = true;
            this.DecodeRadioButton.CheckedChanged += new System.EventHandler(this.SetDecodeMode);
            // 
            // sourceTextGroupBox
            // 
            this.sourceTextGroupBox.Controls.Add(this.selectDictionaryButton);
            this.sourceTextGroupBox.Controls.Add(this.submitButton);
            this.sourceTextGroupBox.Controls.Add(this.loadFromFileButton);
            this.sourceTextGroupBox.Controls.Add(this.clearTextToEncryptBoxButton_1);
            this.sourceTextGroupBox.Controls.Add(this.sourceTextBox);
            this.sourceTextGroupBox.Location = new System.Drawing.Point(12, 142);
            this.sourceTextGroupBox.Name = "sourceTextGroupBox";
            this.sourceTextGroupBox.Size = new System.Drawing.Size(1177, 419);
            this.sourceTextGroupBox.TabIndex = 3;
            this.sourceTextGroupBox.TabStop = false;
            this.sourceTextGroupBox.Text = "Вхідний текст";
            // 
            // button1
            // 
            this.selectDictionaryButton.Location = new System.Drawing.Point(688, 367);
            this.selectDictionaryButton.Name = "button1";
            this.selectDictionaryButton.Size = new System.Drawing.Size(315, 46);
            this.selectDictionaryButton.TabIndex = 4;
            this.selectDictionaryButton.Text = "Вибрати словник";
            this.selectDictionaryButton.UseVisualStyleBackColor = true;
            this.selectDictionaryButton.Click += new System.EventHandler(this.LoadDictionary);
            // 
            // SubmitButton
            // 
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitButton.Location = new System.Drawing.Point(1009, 367);
            this.submitButton.Name = "SubmitButton";
            this.submitButton.Size = new System.Drawing.Size(168, 46);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Кодувати";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.ProcessText);
            // 
            // button2
            // 
            this.loadFromFileButton.Location = new System.Drawing.Point(58, 367);
            this.loadFromFileButton.Name = "button2";
            this.loadFromFileButton.Size = new System.Drawing.Size(217, 46);
            this.loadFromFileButton.TabIndex = 2;
            this.loadFromFileButton.Text = "Завантажити з файлу";
            this.loadFromFileButton.UseVisualStyleBackColor = true;
            this.loadFromFileButton.Click += new System.EventHandler(this.LoadTextForTextToProcessBox);
            // 
            // ClearTextToEncryptBoxButton_1
            // 
            this.clearTextToEncryptBoxButton_1.Location = new System.Drawing.Point(6, 367);
            this.clearTextToEncryptBoxButton_1.Name = "ClearTextToEncryptBoxButton_1";
            this.clearTextToEncryptBoxButton_1.Size = new System.Drawing.Size(46, 46);
            this.clearTextToEncryptBoxButton_1.TabIndex = 1;
            this.clearTextToEncryptBoxButton_1.Text = "X";
            this.clearTextToEncryptBoxButton_1.UseVisualStyleBackColor = true;
            this.clearTextToEncryptBoxButton_1.Click += new System.EventHandler(this.ClearTextBoxes);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(6, 25);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(1165, 336);
            this.sourceTextBox.TabIndex = 0;
            this.sourceTextBox.Text = "";
            // 
            // resultTextGroupBox
            // 
            this.resultTextGroupBox.Controls.Add(this.saveToFileButton);
            this.resultTextGroupBox.Controls.Add(this.clearTextToEncryptBoxButton_2);
            this.resultTextGroupBox.Controls.Add(this.resultTextBox);
            this.resultTextGroupBox.Location = new System.Drawing.Point(12, 567);
            this.resultTextGroupBox.Name = "resultTextGroupBox";
            this.resultTextGroupBox.Size = new System.Drawing.Size(1177, 383);
            this.resultTextGroupBox.TabIndex = 4;
            this.resultTextGroupBox.TabStop = false;
            this.resultTextGroupBox.Text = "Результат";
            // 
            // button5
            // 
            this.saveToFileButton.Location = new System.Drawing.Point(58, 331);
            this.saveToFileButton.Name = "button5";
            this.saveToFileButton.Size = new System.Drawing.Size(217, 46);
            this.saveToFileButton.TabIndex = 2;
            this.saveToFileButton.Text = "Зберегти до файлу";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.SaveResult);
            // 
            // ClearTextToEncryptBoxButton_2
            // 
            this.clearTextToEncryptBoxButton_2.Location = new System.Drawing.Point(6, 331);
            this.clearTextToEncryptBoxButton_2.Name = "ClearTextToEncryptBoxButton_2";
            this.clearTextToEncryptBoxButton_2.Size = new System.Drawing.Size(46, 46);
            this.clearTextToEncryptBoxButton_2.TabIndex = 1;
            this.clearTextToEncryptBoxButton_2.Text = "X";
            this.clearTextToEncryptBoxButton_2.UseVisualStyleBackColor = true;
            this.clearTextToEncryptBoxButton_2.Click += new System.EventHandler(this.ClearTextBoxes);
            // 
            // ResultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(6, 25);
            this.resultTextBox.Name = "ResultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(1165, 300);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.Text = "";
            // 
            // topMenuStrip
            // 
            this.topMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.topMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.topMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramTopMenuStripItem});
            this.topMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.topMenuStrip.Name = "topMenuStrip";
            this.topMenuStrip.Size = new System.Drawing.Size(1201, 33);
            this.topMenuStrip.TabIndex = 6;
            this.topMenuStrip.Text = "menuStrip2";
            // 
            // aboutProgramTopMenuStripItem
            // 
            this.aboutProgramTopMenuStripItem.Name = "aboutProgramTopMenuStripItem";
            this.aboutProgramTopMenuStripItem.Size = new System.Drawing.Size(162, 29);
            this.aboutProgramTopMenuStripItem.Text = "Про программу";
            this.aboutProgramTopMenuStripItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.buckgroundProcessProgressBar.Location = new System.Drawing.Point(12, 956);
            this.buckgroundProcessProgressBar.Name = "progressBar1";
            this.buckgroundProcessProgressBar.Size = new System.Drawing.Size(952, 50);
            this.buckgroundProcessProgressBar.TabIndex = 7;
            // 
            // button3
            // 
            this.cancelBackgroundProgressButton.Location = new System.Drawing.Point(970, 956);
            this.cancelBackgroundProgressButton.Name = "button3";
            this.cancelBackgroundProgressButton.Size = new System.Drawing.Size(219, 50);
            this.cancelBackgroundProgressButton.TabIndex = 8;
            this.cancelBackgroundProgressButton.Text = "Зупинити перебір";
            this.cancelBackgroundProgressButton.UseVisualStyleBackColor = true;
            this.cancelBackgroundProgressButton.Click += new System.EventHandler(this.StopBruteForce);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1201, 1020);
            this.Controls.Add(this.cancelBackgroundProgressButton);
            this.Controls.Add(this.buckgroundProcessProgressBar);
            this.Controls.Add(this.topMenuStrip);
            this.Controls.Add(this.resultTextGroupBox);
            this.Controls.Add(this.sourceTextGroupBox);
            this.Controls.Add(this.ModeGroupBox);
            this.Controls.Add(this.KeyGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Шифрування тексту";
            this.KeyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyTextBox)).EndInit();
            this.ModeGroupBox.ResumeLayout(false);
            this.ModeGroupBox.PerformLayout();
            this.sourceTextGroupBox.ResumeLayout(false);
            this.resultTextGroupBox.ResumeLayout(false);
            this.topMenuStrip.ResumeLayout(false);
            this.topMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox KeyGroupBox;
        private System.Windows.Forms.GroupBox ModeGroupBox;
        private System.Windows.Forms.RadioButton DecodeRadioButton;
        private System.Windows.Forms.RadioButton DecodeWithoutKeyRadioButton;
        private System.Windows.Forms.GroupBox sourceTextGroupBox;
        private System.Windows.Forms.RichTextBox sourceTextBox;
        private System.Windows.Forms.Button clearTextToEncryptBoxButton_1;
        private System.Windows.Forms.Button loadFromFileButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox resultTextGroupBox;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.Button clearTextToEncryptBoxButton_2;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.RadioButton EncodeRadioButton;
        private System.Windows.Forms.MenuStrip topMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramTopMenuStripItem;
        private System.Windows.Forms.NumericUpDown KeyTextBox;
        private System.Windows.Forms.Button selectDictionaryButton;
        private System.ComponentModel.BackgroundWorker decodingWorcker;
        private System.Windows.Forms.ProgressBar buckgroundProcessProgressBar;
        private System.Windows.Forms.Button cancelBackgroundProgressButton;
    }
}

