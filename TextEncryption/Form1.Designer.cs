
namespace TextEncryption
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.KeyGroupBox = new System.Windows.Forms.GroupBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.ModeGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.DecodeWithoutKeyRadioButton = new System.Windows.Forms.RadioButton();
            this.DecodeRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ClearTextToEncryptBoxButton_1 = new System.Windows.Forms.Button();
            this.TextToEncryptBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.ClearTextToEncryptBoxButton_2 = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.проПрограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyGroupBox.SuspendLayout();
            this.ModeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // KeyGroupBox
            // 
            this.KeyGroupBox.Controls.Add(this.KeyTextBox);
            this.KeyGroupBox.Location = new System.Drawing.Point(12, 36);
            this.KeyGroupBox.Name = "KeyGroupBox";
            this.KeyGroupBox.Size = new System.Drawing.Size(171, 66);
            this.KeyGroupBox.TabIndex = 1;
            this.KeyGroupBox.TabStop = false;
            this.KeyGroupBox.Text = "Key";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KeyTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KeyTextBox.Location = new System.Drawing.Point(6, 25);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(159, 26);
            this.KeyTextBox.TabIndex = 0;
            this.KeyTextBox.Text = "a";
            this.KeyTextBox.TextChanged += new System.EventHandler(this.setKey);
            // 
            // ModeGroupBox
            // 
            this.ModeGroupBox.Controls.Add(this.radioButton1);
            this.ModeGroupBox.Controls.Add(this.DecodeWithoutKeyRadioButton);
            this.ModeGroupBox.Controls.Add(this.DecodeRadioButton);
            this.ModeGroupBox.Location = new System.Drawing.Point(201, 36);
            this.ModeGroupBox.Name = "ModeGroupBox";
            this.ModeGroupBox.Size = new System.Drawing.Size(587, 66);
            this.ModeGroupBox.TabIndex = 2;
            this.ModeGroupBox.TabStop = false;
            this.ModeGroupBox.Text = "Mode";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Encode";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.setEncodeMode);
            // 
            // DecodeWithoutKeyRadioButton
            // 
            this.DecodeWithoutKeyRadioButton.AutoSize = true;
            this.DecodeWithoutKeyRadioButton.Location = new System.Drawing.Point(420, 25);
            this.DecodeWithoutKeyRadioButton.Name = "DecodeWithoutKeyRadioButton";
            this.DecodeWithoutKeyRadioButton.Size = new System.Drawing.Size(152, 24);
            this.DecodeWithoutKeyRadioButton.TabIndex = 2;
            this.DecodeWithoutKeyRadioButton.TabStop = true;
            this.DecodeWithoutKeyRadioButton.Text = "Decode (No key)";
            this.DecodeWithoutKeyRadioButton.UseVisualStyleBackColor = true;
            this.DecodeWithoutKeyRadioButton.CheckedChanged += new System.EventHandler(this.setDecodeWithoutKeyMode);
            // 
            // DecodeRadioButton
            // 
            this.DecodeRadioButton.AutoSize = true;
            this.DecodeRadioButton.Location = new System.Drawing.Point(221, 25);
            this.DecodeRadioButton.Name = "DecodeRadioButton";
            this.DecodeRadioButton.Size = new System.Drawing.Size(90, 24);
            this.DecodeRadioButton.TabIndex = 1;
            this.DecodeRadioButton.TabStop = true;
            this.DecodeRadioButton.Text = "Decode";
            this.DecodeRadioButton.UseVisualStyleBackColor = true;
            this.DecodeRadioButton.CheckedChanged += new System.EventHandler(this.seDecodeMode);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SubmitButton);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ClearTextToEncryptBoxButton_1);
            this.groupBox1.Controls.Add(this.TextToEncryptBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 179);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter text to encrypt";
            // 
            // SubmitButton
            // 
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitButton.Location = new System.Drawing.Point(602, 127);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(168, 46);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Encode";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.encodeText);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load from file";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ClearTextToEncryptBoxButton_1
            // 
            this.ClearTextToEncryptBoxButton_1.Location = new System.Drawing.Point(6, 127);
            this.ClearTextToEncryptBoxButton_1.Name = "ClearTextToEncryptBoxButton_1";
            this.ClearTextToEncryptBoxButton_1.Size = new System.Drawing.Size(46, 46);
            this.ClearTextToEncryptBoxButton_1.TabIndex = 1;
            this.ClearTextToEncryptBoxButton_1.Text = "X";
            this.ClearTextToEncryptBoxButton_1.UseVisualStyleBackColor = true;
            this.ClearTextToEncryptBoxButton_1.Click += new System.EventHandler(this.clearTextBoxes);
            // 
            // TextToEncryptBox
            // 
            this.TextToEncryptBox.Location = new System.Drawing.Point(6, 25);
            this.TextToEncryptBox.Name = "TextToEncryptBox";
            this.TextToEncryptBox.Size = new System.Drawing.Size(764, 96);
            this.TextToEncryptBox.TabIndex = 0;
            this.TextToEncryptBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.ClearTextToEncryptBoxButton_2);
            this.groupBox2.Controls.Add(this.ResultTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 179);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(58, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 46);
            this.button5.TabIndex = 2;
            this.button5.Text = "Save to file";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ClearTextToEncryptBoxButton_2
            // 
            this.ClearTextToEncryptBoxButton_2.Location = new System.Drawing.Point(6, 127);
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
            this.ResultTextBox.Size = new System.Drawing.Size(764, 96);
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
            this.menuStrip2.Size = new System.Drawing.Size(805, 33);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // проПрограммуToolStripMenuItem
            // 
            this.проПрограммуToolStripMenuItem.Name = "проПрограммуToolStripMenuItem";
            this.проПрограммуToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.проПрограммуToolStripMenuItem.Text = "Про программу";
            this.проПрограммуToolStripMenuItem.Click += new System.EventHandler(this.проПрограммуToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 540);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ModeGroupBox);
            this.Controls.Add(this.KeyGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyGroupBox.ResumeLayout(false);
            this.KeyGroupBox.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox KeyGroupBox;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.GroupBox ModeGroupBox;
        private System.Windows.Forms.RadioButton DecodeRadioButton;
        private System.Windows.Forms.RadioButton DecodeWithoutKeyRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox TextToEncryptBox;
        private System.Windows.Forms.Button ClearTextToEncryptBoxButton_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ClearTextToEncryptBoxButton_2;
        private System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem проПрограммуToolStripMenuItem;
    }
}

