namespace CustomDovs
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.guidTextBox = new System.Windows.Forms.TextBox();
            this.whoPodTextBox = new System.Windows.Forms.TextBox();
            this.placeBirthPodTextBox = new System.Windows.Forms.TextBox();
            this.firNameLidTextBox = new System.Windows.Forms.TextBox();
            this.secNameLidTextBox = new System.Windows.Forms.TextBox();
            this.patNameLidTextBox = new System.Windows.Forms.TextBox();
            this.postLidTextBox = new System.Windows.Forms.TextBox();
            this.maleTextBox = new System.Windows.Forms.TextBox();
            this.numDovTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.withoutPatLidCheckBox = new System.Windows.Forms.CheckBox();
            this.refreshThiBlockButton = new System.Windows.Forms.Button();
            this.refreshSecBlockButton = new System.Windows.Forms.Button();
            this.refreshFirBlockButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.logoAO = new System.Windows.Forms.PictureBox();
            this.minus = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.telNumMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sDataDovMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.eDataDovMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.snilsPodMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.birthPodMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dataPodPassMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.serialNumMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.passNumMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.codeNumMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.snilsLidMTextBox = new System.Windows.Forms.MaskedTextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoAO)).BeginInit();
            this.SuspendLayout();
            // 
            // guidTextBox
            // 
            this.guidTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.guidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guidTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guidTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.guidTextBox.Location = new System.Drawing.Point(20, 72);
            this.guidTextBox.Name = "guidTextBox";
            this.guidTextBox.Size = new System.Drawing.Size(322, 24);
            this.guidTextBox.TabIndex = 2;
            this.guidTextBox.TabStop = false;
            this.guidTextBox.Text = "Идентификатор продукта";
            this.guidTextBox.Click += new System.EventHandler(this.guidTextBox_Click);
            // 
            // whoPodTextBox
            // 
            this.whoPodTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.whoPodTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.whoPodTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.whoPodTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.whoPodTextBox.Location = new System.Drawing.Point(19, 209);
            this.whoPodTextBox.Name = "whoPodTextBox";
            this.whoPodTextBox.Size = new System.Drawing.Size(662, 24);
            this.whoPodTextBox.TabIndex = 6;
            this.whoPodTextBox.TabStop = false;
            this.whoPodTextBox.Text = "Кем выдан";
            this.whoPodTextBox.Click += new System.EventHandler(this.whoPodTextBox_Click);
            // 
            // placeBirthPodTextBox
            // 
            this.placeBirthPodTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.placeBirthPodTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placeBirthPodTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeBirthPodTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.placeBirthPodTextBox.Location = new System.Drawing.Point(19, 239);
            this.placeBirthPodTextBox.Name = "placeBirthPodTextBox";
            this.placeBirthPodTextBox.Size = new System.Drawing.Size(614, 24);
            this.placeBirthPodTextBox.TabIndex = 9;
            this.placeBirthPodTextBox.TabStop = false;
            this.placeBirthPodTextBox.Text = "Место рождения";
            this.placeBirthPodTextBox.Click += new System.EventHandler(this.placeBirthPodTextBox_Click);
            // 
            // firNameLidTextBox
            // 
            this.firNameLidTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.firNameLidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firNameLidTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firNameLidTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.firNameLidTextBox.Location = new System.Drawing.Point(260, 318);
            this.firNameLidTextBox.Name = "firNameLidTextBox";
            this.firNameLidTextBox.Size = new System.Drawing.Size(234, 24);
            this.firNameLidTextBox.TabIndex = 11;
            this.firNameLidTextBox.TabStop = false;
            this.firNameLidTextBox.Text = "Имя руководителя";
            this.firNameLidTextBox.Click += new System.EventHandler(this.firNameLidTextBox_Click);
            // 
            // secNameLidTextBox
            // 
            this.secNameLidTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.secNameLidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secNameLidTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secNameLidTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.secNameLidTextBox.Location = new System.Drawing.Point(20, 318);
            this.secNameLidTextBox.Name = "secNameLidTextBox";
            this.secNameLidTextBox.Size = new System.Drawing.Size(234, 24);
            this.secNameLidTextBox.TabIndex = 12;
            this.secNameLidTextBox.TabStop = false;
            this.secNameLidTextBox.Text = "Фамилия руководителя";
            this.secNameLidTextBox.Click += new System.EventHandler(this.secNameLidTextBox_Click);
            // 
            // patNameLidTextBox
            // 
            this.patNameLidTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.patNameLidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patNameLidTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patNameLidTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.patNameLidTextBox.Location = new System.Drawing.Point(500, 318);
            this.patNameLidTextBox.Name = "patNameLidTextBox";
            this.patNameLidTextBox.Size = new System.Drawing.Size(181, 24);
            this.patNameLidTextBox.TabIndex = 13;
            this.patNameLidTextBox.TabStop = false;
            this.patNameLidTextBox.Text = "Отчество";
            this.patNameLidTextBox.Click += new System.EventHandler(this.patNameLidTextBox_Click);
            // 
            // postLidTextBox
            // 
            this.postLidTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.postLidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postLidTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postLidTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.postLidTextBox.Location = new System.Drawing.Point(297, 348);
            this.postLidTextBox.Name = "postLidTextBox";
            this.postLidTextBox.Size = new System.Drawing.Size(181, 24);
            this.postLidTextBox.TabIndex = 14;
            this.postLidTextBox.TabStop = false;
            this.postLidTextBox.Text = "Должность";
            this.postLidTextBox.Click += new System.EventHandler(this.postLidTextBox_Click);
            // 
            // maleTextBox
            // 
            this.maleTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.maleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maleTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maleTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maleTextBox.Location = new System.Drawing.Point(20, 348);
            this.maleTextBox.Name = "maleTextBox";
            this.maleTextBox.Size = new System.Drawing.Size(138, 24);
            this.maleTextBox.TabIndex = 17;
            this.maleTextBox.TabStop = false;
            this.maleTextBox.Text = "Пол руководителя";
            this.maleTextBox.Click += new System.EventHandler(this.maleTextBox_Click);
            // 
            // numDovTextBox
            // 
            this.numDovTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.numDovTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDovTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numDovTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numDovTextBox.Location = new System.Drawing.Point(511, 72);
            this.numDovTextBox.Name = "numDovTextBox";
            this.numDovTextBox.Size = new System.Drawing.Size(170, 24);
            this.numDovTextBox.TabIndex = 18;
            this.numDovTextBox.TabStop = false;
            this.numDovTextBox.Text = "Номер доверенности";
            this.numDovTextBox.Click += new System.EventHandler(this.numDovTextBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Общий блок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Подписант";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Руководитель";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(11, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(678, 70);
            this.label4.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(11, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(678, 99);
            this.label5.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(11, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(678, 65);
            this.label6.TabIndex = 28;
            // 
            // withoutPatLidCheckBox
            // 
            this.withoutPatLidCheckBox.BackColor = System.Drawing.Color.LightGray;
            this.withoutPatLidCheckBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.withoutPatLidCheckBox.Location = new System.Drawing.Point(11, 402);
            this.withoutPatLidCheckBox.Name = "withoutPatLidCheckBox";
            this.withoutPatLidCheckBox.Size = new System.Drawing.Size(120, 20);
            this.withoutPatLidCheckBox.TabIndex = 29;
            this.withoutPatLidCheckBox.Text = "Без отчества";
            this.withoutPatLidCheckBox.UseVisualStyleBackColor = false;
            this.withoutPatLidCheckBox.CheckedChanged += new System.EventHandler(this.withoutPatLidCheckBox_CheckedChanged);
            // 
            // refreshThiBlockButton
            // 
            this.refreshThiBlockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshThiBlockButton.FlatAppearance.BorderSize = 0;
            this.refreshThiBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshThiBlockButton.Image = global::CustomDovs.Properties.Resources.refresh;
            this.refreshThiBlockButton.Location = new System.Drawing.Point(659, 351);
            this.refreshThiBlockButton.Name = "refreshThiBlockButton";
            this.refreshThiBlockButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.refreshThiBlockButton.Size = new System.Drawing.Size(22, 22);
            this.refreshThiBlockButton.TabIndex = 32;
            this.refreshThiBlockButton.UseVisualStyleBackColor = true;
            this.refreshThiBlockButton.Click += new System.EventHandler(this.refreshThiBlockButton_Click);
            this.refreshThiBlockButton.MouseEnter += new System.EventHandler(this.refreshThiBlockButton_MouseEnter);
            this.refreshThiBlockButton.MouseLeave += new System.EventHandler(this.refreshThiBlockButton_MouseLeave);
            // 
            // refreshSecBlockButton
            // 
            this.refreshSecBlockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshSecBlockButton.FlatAppearance.BorderSize = 0;
            this.refreshSecBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshSecBlockButton.Image = global::CustomDovs.Properties.Resources.refresh;
            this.refreshSecBlockButton.Location = new System.Drawing.Point(659, 241);
            this.refreshSecBlockButton.Name = "refreshSecBlockButton";
            this.refreshSecBlockButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.refreshSecBlockButton.Size = new System.Drawing.Size(22, 22);
            this.refreshSecBlockButton.TabIndex = 31;
            this.refreshSecBlockButton.UseVisualStyleBackColor = true;
            this.refreshSecBlockButton.Click += new System.EventHandler(this.refreshSecBlockButton_Click);
            this.refreshSecBlockButton.MouseEnter += new System.EventHandler(this.refreshSecBlockButton_MouseEnter);
            this.refreshSecBlockButton.MouseLeave += new System.EventHandler(this.refreshSecBlockButton_MouseLeave);
            // 
            // refreshFirBlockButton
            // 
            this.refreshFirBlockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshFirBlockButton.FlatAppearance.BorderSize = 0;
            this.refreshFirBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshFirBlockButton.Image = global::CustomDovs.Properties.Resources.refresh;
            this.refreshFirBlockButton.Location = new System.Drawing.Point(661, 110);
            this.refreshFirBlockButton.Name = "refreshFirBlockButton";
            this.refreshFirBlockButton.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.refreshFirBlockButton.Size = new System.Drawing.Size(22, 22);
            this.refreshFirBlockButton.TabIndex = 30;
            this.refreshFirBlockButton.UseVisualStyleBackColor = true;
            this.refreshFirBlockButton.Click += new System.EventHandler(this.refreshFirBlockButton_Click);
            this.refreshFirBlockButton.MouseEnter += new System.EventHandler(this.refreshFirBlockButton_MouseEnter);
            this.refreshFirBlockButton.MouseLeave += new System.EventHandler(this.refreshFirBlockButton_MouseLeave);
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Image = global::CustomDovs.Properties.Resources.accept;
            this.createButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createButton.Location = new System.Drawing.Point(304, 411);
            this.createButton.Name = "createButton";
            this.createButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.createButton.Size = new System.Drawing.Size(93, 53);
            this.createButton.TabIndex = 22;
            this.createButton.Text = "Создать";
            this.createButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // logoAO
            // 
            this.logoAO.Image = global::CustomDovs.Properties.Resources.Astral_NEW_Logo_small;
            this.logoAO.Location = new System.Drawing.Point(3, 2);
            this.logoAO.Name = "logoAO";
            this.logoAO.Size = new System.Drawing.Size(33, 32);
            this.logoAO.TabIndex = 21;
            this.logoAO.TabStop = false;
            // 
            // minus
            // 
            this.minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Image = global::CustomDovs.Properties.Resources.minus;
            this.minus.Location = new System.Drawing.Point(641, 5);
            this.minus.Name = "minus";
            this.minus.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.minus.Size = new System.Drawing.Size(22, 22);
            this.minus.TabIndex = 0;
            this.minus.TabStop = false;
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            this.minus.MouseEnter += new System.EventHandler(this.minus_MouseEnter);
            this.minus.MouseLeave += new System.EventHandler(this.minus_MouseLeave);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.LightGray;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = global::CustomDovs.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(669, 5);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.close.Size = new System.Drawing.Size(22, 22);
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // telNumMTextBox
            // 
            this.telNumMTextBox.AsciiOnly = true;
            this.telNumMTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.telNumMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telNumMTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telNumMTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.telNumMTextBox.Location = new System.Drawing.Point(348, 72);
            this.telNumMTextBox.Mask = "70000000000";
            this.telNumMTextBox.Name = "telNumMTextBox";
            this.telNumMTextBox.PromptChar = '*';
            this.telNumMTextBox.Size = new System.Drawing.Size(157, 23);
            this.telNumMTextBox.TabIndex = 0;
            this.telNumMTextBox.TabStop = false;
            // 
            // sDataDovMTextBox
            // 
            this.sDataDovMTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.sDataDovMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sDataDovMTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sDataDovMTextBox.Location = new System.Drawing.Point(20, 105);
            this.sDataDovMTextBox.Mask = "0000-00-00";
            this.sDataDovMTextBox.Name = "sDataDovMTextBox";
            this.sDataDovMTextBox.PromptChar = '*';
            this.sDataDovMTextBox.Size = new System.Drawing.Size(96, 23);
            this.sDataDovMTextBox.TabIndex = 33;
            // 
            // eDataDovMTextBox
            // 
            this.eDataDovMTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.eDataDovMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eDataDovMTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eDataDovMTextBox.Location = new System.Drawing.Point(122, 105);
            this.eDataDovMTextBox.Mask = "0000-00-00";
            this.eDataDovMTextBox.Name = "eDataDovMTextBox";
            this.eDataDovMTextBox.PromptChar = '*';
            this.eDataDovMTextBox.Size = new System.Drawing.Size(96, 23);
            this.eDataDovMTextBox.TabIndex = 34;
            // 
            // snilsPodMTextBox
            // 
            this.snilsPodMTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.snilsPodMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.snilsPodMTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.snilsPodMTextBox.Location = new System.Drawing.Point(19, 180);
            this.snilsPodMTextBox.Mask = "000-000-000 00";
            this.snilsPodMTextBox.Name = "snilsPodMTextBox";
            this.snilsPodMTextBox.PromptChar = '*';
            this.snilsPodMTextBox.Size = new System.Drawing.Size(127, 23);
            this.snilsPodMTextBox.TabIndex = 35;
            // 
            // birthPodMTextBox
            // 
            this.birthPodMTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.birthPodMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthPodMTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthPodMTextBox.Location = new System.Drawing.Point(152, 180);
            this.birthPodMTextBox.Mask = "0000-00-00";
            this.birthPodMTextBox.Name = "birthPodMTextBox";
            this.birthPodMTextBox.PromptChar = '*';
            this.birthPodMTextBox.Size = new System.Drawing.Size(96, 23);
            this.birthPodMTextBox.TabIndex = 36;
            // 
            // dataPodPassMTextBox
            // 
            this.dataPodPassMTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.dataPodPassMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataPodPassMTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataPodPassMTextBox.Location = new System.Drawing.Point(254, 180);
            this.dataPodPassMTextBox.Mask = "0000-00-00";
            this.dataPodPassMTextBox.Name = "dataPodPassMTextBox";
            this.dataPodPassMTextBox.PromptChar = '*';
            this.dataPodPassMTextBox.Size = new System.Drawing.Size(96, 23);
            this.dataPodPassMTextBox.TabIndex = 37;
            // 
            // serialNumMTextBox
            // 
            this.serialNumMTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.serialNumMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serialNumMTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serialNumMTextBox.Location = new System.Drawing.Point(356, 180);
            this.serialNumMTextBox.Mask = "0000";
            this.serialNumMTextBox.Name = "serialNumMTextBox";
            this.serialNumMTextBox.PromptChar = '*';
            this.serialNumMTextBox.Size = new System.Drawing.Size(41, 23);
            this.serialNumMTextBox.TabIndex = 38;
            // 
            // passNumMTextBox
            // 
            this.passNumMTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.passNumMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passNumMTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passNumMTextBox.Location = new System.Drawing.Point(403, 180);
            this.passNumMTextBox.Mask = "000000";
            this.passNumMTextBox.Name = "passNumMTextBox";
            this.passNumMTextBox.PromptChar = '*';
            this.passNumMTextBox.Size = new System.Drawing.Size(63, 23);
            this.passNumMTextBox.TabIndex = 39;
            // 
            // codeNumMTextBox
            // 
            this.codeNumMTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.codeNumMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeNumMTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeNumMTextBox.Location = new System.Drawing.Point(472, 180);
            this.codeNumMTextBox.Mask = "000000";
            this.codeNumMTextBox.Name = "codeNumMTextBox";
            this.codeNumMTextBox.PromptChar = '*';
            this.codeNumMTextBox.Size = new System.Drawing.Size(63, 23);
            this.codeNumMTextBox.TabIndex = 40;
            // 
            // snilsLidMTextBox
            // 
            this.snilsLidMTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.snilsLidMTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.snilsLidMTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.snilsLidMTextBox.Location = new System.Drawing.Point(164, 348);
            this.snilsLidMTextBox.Mask = "000-000-000 00";
            this.snilsLidMTextBox.Name = "snilsLidMTextBox";
            this.snilsLidMTextBox.PromptChar = '*';
            this.snilsLidMTextBox.Size = new System.Drawing.Size(127, 23);
            this.snilsLidMTextBox.TabIndex = 41;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.snilsLidMTextBox);
            this.Controls.Add(this.codeNumMTextBox);
            this.Controls.Add(this.passNumMTextBox);
            this.Controls.Add(this.serialNumMTextBox);
            this.Controls.Add(this.dataPodPassMTextBox);
            this.Controls.Add(this.birthPodMTextBox);
            this.Controls.Add(this.snilsPodMTextBox);
            this.Controls.Add(this.eDataDovMTextBox);
            this.Controls.Add(this.sDataDovMTextBox);
            this.Controls.Add(this.telNumMTextBox);
            this.Controls.Add(this.refreshThiBlockButton);
            this.Controls.Add(this.refreshSecBlockButton);
            this.Controls.Add(this.refreshFirBlockButton);
            this.Controls.Add(this.withoutPatLidCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.logoAO);
            this.Controls.Add(this.numDovTextBox);
            this.Controls.Add(this.maleTextBox);
            this.Controls.Add(this.postLidTextBox);
            this.Controls.Add(this.patNameLidTextBox);
            this.Controls.Add(this.secNameLidTextBox);
            this.Controls.Add(this.firNameLidTextBox);
            this.Controls.Add(this.placeBirthPodTextBox);
            this.Controls.Add(this.whoPodTextBox);
            this.Controls.Add(this.guidTextBox);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.logoAO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.TextBox guidTextBox;
        private System.Windows.Forms.TextBox whoPodTextBox;
        private System.Windows.Forms.TextBox placeBirthPodTextBox;
        private System.Windows.Forms.TextBox firNameLidTextBox;
        private System.Windows.Forms.TextBox secNameLidTextBox;
        private System.Windows.Forms.TextBox patNameLidTextBox;
        private System.Windows.Forms.TextBox postLidTextBox;
        private System.Windows.Forms.TextBox maleTextBox;
        private System.Windows.Forms.TextBox numDovTextBox;
        private System.Windows.Forms.PictureBox logoAO;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox withoutPatLidCheckBox;
        private System.Windows.Forms.Button refreshFirBlockButton;
        private System.Windows.Forms.Button refreshSecBlockButton;
        private System.Windows.Forms.Button refreshThiBlockButton;
        private System.Windows.Forms.MaskedTextBox telNumMTextBox;
        private System.Windows.Forms.MaskedTextBox sDataDovMTextBox;
        private System.Windows.Forms.MaskedTextBox eDataDovMTextBox;
        private System.Windows.Forms.MaskedTextBox snilsPodMTextBox;
        private System.Windows.Forms.MaskedTextBox birthPodMTextBox;
        private System.Windows.Forms.MaskedTextBox dataPodPassMTextBox;
        private System.Windows.Forms.MaskedTextBox serialNumMTextBox;
        private System.Windows.Forms.MaskedTextBox passNumMTextBox;
        private System.Windows.Forms.MaskedTextBox codeNumMTextBox;
        private System.Windows.Forms.MaskedTextBox snilsLidMTextBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

