namespace WindowsFormsApp3
{
    partial class PersonEditForm
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
            System.Windows.Forms.Label teleDataBirthLabel;
            System.Windows.Forms.Label telePresenterNameLabel;
            System.Windows.Forms.Label telePresenterSecondNameLabel;
            System.Windows.Forms.Label teleNameLabel1;
            System.Windows.Forms.Label tipIDLabel;
            System.Windows.Forms.Label limitIDLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.teleDataBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.teleInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telePresenterNameTextBox = new System.Windows.Forms.TextBox();
            this.telePresenterSecondNameTextBox = new System.Windows.Forms.TextBox();
            this.teleNameTextBox1 = new System.Windows.Forms.TextBox();
            this.tipIDComboBox = new System.Windows.Forms.ComboBox();
            this.TipbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.limitIDComboBox = new System.Windows.Forms.ComboBox();
            this.LimitListbindingSource = new System.Windows.Forms.BindingSource(this.components);
            teleDataBirthLabel = new System.Windows.Forms.Label();
            telePresenterNameLabel = new System.Windows.Forms.Label();
            telePresenterSecondNameLabel = new System.Windows.Forms.Label();
            teleNameLabel1 = new System.Windows.Forms.Label();
            tipIDLabel = new System.Windows.Forms.Label();
            limitIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teleInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipbindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimitListbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // teleDataBirthLabel
            // 
            teleDataBirthLabel.AutoSize = true;
            teleDataBirthLabel.Location = new System.Drawing.Point(56, 20);
            teleDataBirthLabel.Name = "teleDataBirthLabel";
            teleDataBirthLabel.Size = new System.Drawing.Size(81, 13);
            teleDataBirthLabel.TabIndex = 2;
            teleDataBirthLabel.Text = "Tele Data Birth:";
            // 
            // telePresenterNameLabel
            // 
            telePresenterNameLabel.AutoSize = true;
            telePresenterNameLabel.Location = new System.Drawing.Point(56, 87);
            telePresenterNameLabel.Name = "telePresenterNameLabel";
            telePresenterNameLabel.Size = new System.Drawing.Size(110, 13);
            telePresenterNameLabel.TabIndex = 6;
            telePresenterNameLabel.Text = "Tele Presenter Name:";
            // 
            // telePresenterSecondNameLabel
            // 
            telePresenterSecondNameLabel.AutoSize = true;
            telePresenterSecondNameLabel.Location = new System.Drawing.Point(56, 119);
            telePresenterSecondNameLabel.Name = "telePresenterSecondNameLabel";
            telePresenterSecondNameLabel.Size = new System.Drawing.Size(150, 13);
            telePresenterSecondNameLabel.TabIndex = 8;
            telePresenterSecondNameLabel.Text = "Tele Presenter Second Name:";
            // 
            // teleNameLabel1
            // 
            teleNameLabel1.AutoSize = true;
            teleNameLabel1.Location = new System.Drawing.Point(75, 54);
            teleNameLabel1.Name = "teleNameLabel1";
            teleNameLabel1.Size = new System.Drawing.Size(62, 13);
            teleNameLabel1.TabIndex = 10;
            teleNameLabel1.Text = "Tele Name:";
            // 
            // tipIDLabel
            // 
            tipIDLabel.AutoSize = true;
            tipIDLabel.Location = new System.Drawing.Point(167, 145);
            tipIDLabel.Name = "tipIDLabel";
            tipIDLabel.Size = new System.Drawing.Size(39, 13);
            tipIDLabel.TabIndex = 12;
            tipIDLabel.Text = "Tip ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // teleDataBirthDateTimePicker
            // 
            this.teleDataBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.teleInfoBindingSource, "TeleDataBirth", true));
            this.teleDataBirthDateTimePicker.Location = new System.Drawing.Point(212, 16);
            this.teleDataBirthDateTimePicker.Name = "teleDataBirthDateTimePicker";
            this.teleDataBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.teleDataBirthDateTimePicker.TabIndex = 3;
            // 
            // teleInfoBindingSource
            // 
            this.teleInfoBindingSource.DataSource = typeof(TeleLibrary1.TeleInfo);
            // 
            // telePresenterNameTextBox
            // 
            this.telePresenterNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teleInfoBindingSource, "TelePresenterName", true));
            this.telePresenterNameTextBox.Location = new System.Drawing.Point(212, 84);
            this.telePresenterNameTextBox.Name = "telePresenterNameTextBox";
            this.telePresenterNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.telePresenterNameTextBox.TabIndex = 7;
            // 
            // telePresenterSecondNameTextBox
            // 
            this.telePresenterSecondNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teleInfoBindingSource, "TelePresenterSecondName", true));
            this.telePresenterSecondNameTextBox.Location = new System.Drawing.Point(212, 116);
            this.telePresenterSecondNameTextBox.Name = "telePresenterSecondNameTextBox";
            this.telePresenterSecondNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.telePresenterSecondNameTextBox.TabIndex = 9;
            // 
            // teleNameTextBox1
            // 
            this.teleNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teleInfoBindingSource, "TeleName", true));
            this.teleNameTextBox1.Location = new System.Drawing.Point(212, 47);
            this.teleNameTextBox1.Name = "teleNameTextBox1";
            this.teleNameTextBox1.Size = new System.Drawing.Size(200, 20);
            this.teleNameTextBox1.TabIndex = 11;
            this.teleNameTextBox1.TextChanged += new System.EventHandler(this.teleNameTextBox1_TextChanged);
            // 
            // tipIDComboBox
            // 
            this.tipIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teleInfoBindingSource, "TipID", true));
            this.tipIDComboBox.DataSource = this.TipbindingSource1;
            this.tipIDComboBox.DisplayMember = "TipName";
            this.tipIDComboBox.FormattingEnabled = true;
            this.tipIDComboBox.Location = new System.Drawing.Point(212, 142);
            this.tipIDComboBox.Name = "tipIDComboBox";
            this.tipIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipIDComboBox.TabIndex = 13;
            this.tipIDComboBox.ValueMember = "TipID";
            // 
            // TipbindingSource1
            // 
            this.TipbindingSource1.DataSource = typeof(TeleLibrary1.TeleList);
            // 
            // limitIDLabel
            // 
            limitIDLabel.AutoSize = true;
            limitIDLabel.Location = new System.Drawing.Point(161, 176);
            limitIDLabel.Name = "limitIDLabel";
            limitIDLabel.Size = new System.Drawing.Size(45, 13);
            limitIDLabel.TabIndex = 13;
            limitIDLabel.Text = "Limit ID:";
            // 
            // limitIDComboBox
            // 
            this.limitIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teleInfoBindingSource, "LimitID", true));
            this.limitIDComboBox.DataSource = this.LimitListbindingSource;
            this.limitIDComboBox.DisplayMember = "LimitName";
            this.limitIDComboBox.FormattingEnabled = true;
            this.limitIDComboBox.Location = new System.Drawing.Point(212, 173);
            this.limitIDComboBox.Name = "limitIDComboBox";
            this.limitIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.limitIDComboBox.TabIndex = 14;
            this.limitIDComboBox.ValueMember = "LimitID";
            // 
            // LimitListbindingSource
            // 
            this.LimitListbindingSource.DataSource = typeof(TeleLibrary1.TeleList);
            // 
            // PersonEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(limitIDLabel);
            this.Controls.Add(this.limitIDComboBox);
            this.Controls.Add(tipIDLabel);
            this.Controls.Add(this.tipIDComboBox);
            this.Controls.Add(teleNameLabel1);
            this.Controls.Add(this.teleNameTextBox1);
            this.Controls.Add(telePresenterSecondNameLabel);
            this.Controls.Add(this.telePresenterSecondNameTextBox);
            this.Controls.Add(telePresenterNameLabel);
            this.Controls.Add(this.telePresenterNameTextBox);
            this.Controls.Add(teleDataBirthLabel);
            this.Controls.Add(this.teleDataBirthDateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "PersonEditForm";
            this.Text = "Карточка Теле шоу";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teleInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipbindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimitListbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource teleInfoBindingSource;
        private System.Windows.Forms.DateTimePicker teleDataBirthDateTimePicker;
        private System.Windows.Forms.TextBox telePresenterNameTextBox;
        private System.Windows.Forms.TextBox telePresenterSecondNameTextBox;
        private System.Windows.Forms.TextBox teleNameTextBox1;
        private System.Windows.Forms.ComboBox tipIDComboBox;
        private System.Windows.Forms.BindingSource TipbindingSource1;
        private System.Windows.Forms.ComboBox limitIDComboBox;
        private System.Windows.Forms.BindingSource LimitListbindingSource;
    }
}

