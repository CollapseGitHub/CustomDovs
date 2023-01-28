using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDovs
{
    public partial class mainForm : Form
    {
        pBarSaveForm form = new pBarSaveForm();
        bool drag = false; //Перемещается ли форма
        Point start_point = new Point(0, 0); //Стартовые координаты
        string readyDov = "";

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        #region Перемещение формы

        /// <summary>
        /// Обработка нажатия на форму
        /// </summary>
        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        /// <summary>
        /// Функция перемещения
        /// </summary>
        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        /// <summary>
        /// Обработка отпускания мыши с формы после премещения
        /// </summary>
        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        #endregion

        #region Кнопки

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void minus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region "Анимация кнопок"

        private void minus_MouseEnter(object sender, EventArgs e)
        {
            GC.Collect();
            minus.Image = global::CustomDovs.Properties.Resources.minus_color;
        }

        private void minus_MouseLeave(object sender, EventArgs e)
        {
            GC.Collect();
            minus.Image = global::CustomDovs.Properties.Resources.minus;
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            GC.Collect();
            close.Image = global::CustomDovs.Properties.Resources.close_color;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            GC.Collect();
            close.Image = global::CustomDovs.Properties.Resources.close;
        }

        private void refreshFirBlockButton_MouseEnter(object sender, EventArgs e)
        {
            GC.Collect();
            refreshFirBlockButton.Image = global::CustomDovs.Properties.Resources.refresh_color;
        }

        private void refreshFirBlockButton_MouseLeave(object sender, EventArgs e)
        {
            GC.Collect();
            refreshFirBlockButton.Image = global::CustomDovs.Properties.Resources.refresh;
        }

        private void refreshSecBlockButton_MouseEnter(object sender, EventArgs e)
        {
            GC.Collect();
            refreshSecBlockButton.Image = global::CustomDovs.Properties.Resources.refresh_color;
        }

        private void refreshSecBlockButton_MouseLeave(object sender, EventArgs e)
        {
            GC.Collect();
            refreshSecBlockButton.Image = global::CustomDovs.Properties.Resources.refresh;
        }

        private void refreshThiBlockButton_MouseEnter(object sender, EventArgs e)
        {
            GC.Collect();
            refreshThiBlockButton.Image = global::CustomDovs.Properties.Resources.refresh_color;
        }

        private void refreshThiBlockButton_MouseLeave(object sender, EventArgs e)
        {
            GC.Collect();
            refreshThiBlockButton.Image = global::CustomDovs.Properties.Resources.refresh;
        }

        #endregion

        /// <summary>
        /// Возвращает значения по умолчанию всем полям в общем блоке
        /// </summary>
        private void refreshFirBlockButton_Click(object sender, EventArgs e)
        {
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show("Вернуть поля в общем блоке по умолчанию?", "Внимание",
                MessageBoxButtons.OKCancel, icon);
            if (result == DialogResult.OK) 
            {
                guidTextBox.Text = "Идентификатор продукта";
                telNumberTextBox.Text = "Телефон";
                numDovTextBox.Text = "Номер доверенности";
                startDataDovTextBox.Text = "Дата начала действия";
                endDataTextBox.Text = "Дата окончания действия";
            }
        }

        /// <summary>
        /// Возвращает значения по умолчанию всем полям в блоке подписанта
        /// </summary>
        private void refreshSecBlockButton_Click(object sender, EventArgs e)
        {
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show("Вернуть поля в блоке подписанта по умолчанию?", "Внимание",
                MessageBoxButtons.OKCancel, icon);
            if (result == DialogResult.OK)
            {
                snilsPodTextBox.Text = "СНИЛС подписанта";
                birthPodTextBox.Text = "Дата рождения подписанта";
                dataPodPassTextBox.Text = "Дата выдачи паспорта";
                serialNumTextBox.Text = "Серия";
                passNumTextBox.Text = "Номер паспорта";
                codeNumTextBox.Text = "Код подразделения";
                whoPodTextBox.Text = "Кем выдан";
                placeBirthPodTextBox.Text = "Место рождения";
            }
        }

        /// <summary>
        /// Возвращает значения по умолчанию всем полям в блоке руководителя
        /// </summary>
        private void refreshThiBlockButton_Click(object sender, EventArgs e)
        {
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show("Вернуть поля в блоке руководителя по умолчанию?", "Внимание",
                MessageBoxButtons.OKCancel, icon);
            if (result == DialogResult.OK)
            {
                secNameLidTextBox.Text = "Фамилия руководителя";
                firNameLidTextBox.Text = "Имя руководителя";
                patNameLidTextBox.Text = "Отчество";
                maleTextBox.Text = "Пол руководителя";
                snilsLidTextBox.Text = "СНИЛС Руководителя";
                postLidTextBox.Text = "Должность";
                withoutPatLidCheckBox.Checked = false;
            }
        }
        #endregion

        #region Обработка первичного нажатия по TextBox'ам

        #region Общий блок
        private void guidTextBox_Click(object sender, EventArgs e)
        {
            if (guidTextBox.Text == "Идентификатор продукта")
            {
                guidTextBox.Text = "";
            }
        }

        private void telNumberTextBox_Click(object sender, EventArgs e)
        {
            if (telNumberTextBox.Text == "Телефон")
            {
                telNumberTextBox.Text = "";
            }
        }

        private void numDovTextBox_Click(object sender, EventArgs e)
        {
            if (numDovTextBox.Text == "Номер доверенности")
            {
                numDovTextBox.Text = "";
            }
        }

        private void startDataDovTextBox_Click(object sender, EventArgs e)
        {
            if (startDataDovTextBox.Text == "Дата начала действия")
            {
                startDataDovTextBox.Text = "";
            }
        }

        private void endDataTextBox_Click(object sender, EventArgs e)
        {
            if (endDataTextBox.Text == "Дата окончания действия")
            {
                endDataTextBox.Text = "";
            }
        }
        #endregion

        #region Подписант
        private void snilsPodTextBox_Click(object sender, EventArgs e)
        {
            if (snilsPodTextBox.Text == "СНИЛС подписанта")
            {
                snilsPodTextBox.Text = "";
            }
        }

        private void birthPodTextBox_Click(object sender, EventArgs e)
        {
            if (birthPodTextBox.Text == "Дата рождения подписанта")
            {
                birthPodTextBox.Text = "";
            }
        }

        private void dataPodPassTextBox_Click(object sender, EventArgs e)
        {
            if (dataPodPassTextBox.Text == "Дата выдачи паспорта")
            {
                dataPodPassTextBox.Text = "";
            }
        }

        private void serialNumTextBox_Click(object sender, EventArgs e)
        {
            if (serialNumTextBox.Text == "Серия")
            {
                serialNumTextBox.Text = "";
            }
        }

        private void passNumTextBox_Click(object sender, EventArgs e)
        {
            if (passNumTextBox.Text == "Номер паспорта")
            {
                passNumTextBox.Text = "";
            }
        }

        private void codeNumTextBox_Click(object sender, EventArgs e)
        {
            if (codeNumTextBox.Text == "Код подразделения")
            {
                codeNumTextBox.Text = "";
            }
        }

        private void whoPodTextBox_Click(object sender, EventArgs e)
        {
            if (whoPodTextBox.Text == "Кем выдан")
            {
                whoPodTextBox.Text = "";
            }
        }

        private void placeBirthPodTextBox_Click(object sender, EventArgs e)
        {
            if (placeBirthPodTextBox.Text == "Место рождения")
            {
                placeBirthPodTextBox.Text = "";
            }
        }
        #endregion

        #region Руководитель
        private void secNameLidTextBox_Click(object sender, EventArgs e)
        {
            if (secNameLidTextBox.Text == "Фамилия руководителя")
            {
                secNameLidTextBox.Text = "";
            }
        }

        private void firNameLidTextBox_Click(object sender, EventArgs e)
        {
            if (firNameLidTextBox.Text == "Имя руководителя")
            {
                firNameLidTextBox.Text = "";
            }
        }

        private void patNameLidTextBox_Click(object sender, EventArgs e)
        {
            if (patNameLidTextBox.Text == "Отчество")
            {
                patNameLidTextBox.Text = "";
            }
        }

        private void maleTextBox_Click(object sender, EventArgs e)
        {
            if (maleTextBox.Text == "Пол руководителя")
            {
                maleTextBox.Text = "";
            }
        }

        private void snilsLidTextBox_Click(object sender, EventArgs e)
        {
            if (snilsLidTextBox.Text == "СНИЛС Руководителя")
            {
                snilsLidTextBox.Text = "";
            }
        }

        private void postLidTextBox_Click(object sender, EventArgs e)
        {
            if (postLidTextBox.Text == "Должность")
            {
                postLidTextBox.Text = "";
            }
        }
        #endregion
        #endregion

        #region CheckBox'ы

        private void withoutPatLidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (withoutPatLidCheckBox.Checked == true)
            {
                patNameLidTextBox.Text = "";
                patNameLidTextBox.Enabled = false;
                patNameLidTextBox.BackColor = Color.LightGray;
            }
            else
            {
                if (withoutPatLidCheckBox.Checked == false)
                {
                    if (patNameLidTextBox.Text == "")
                    {
                        patNameLidTextBox.Text = "Отчество";
                    }
                    patNameLidTextBox.Enabled = true;
                    patNameLidTextBox.BackColor = Color.PeachPuff;
                }
            }
        }






        #endregion

        private async void createButton_Click(object sender, EventArgs e)
        {
            createButton.Enabled = false;
            string[] currentDov = newDov();
            SaveFileDialog open = new SaveFileDialog();
            open.Filter = "csv (*.csv)|*.csv|All files (*.*)|*.*";
            open.FilterIndex = 1;
            here:
            readyDov = "";
            DialogResult result = MessageBox.Show(ValueInArray(currentDov), "Предварительный просмотр", 
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                DialogResult dialogResult = open.ShowDialog();
                if (dialogResult == DialogResult.Cancel) 
                {
                    goto here;
                }
                string path = open.FileName;
                try
                {
                        using (FileStream fs = File.Create(path))
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(readyDov);
                            fs.Write(info, 0, info.Length);
                            MessageBox.Show("Файл успешно сохранен");
                            createButton.Enabled = true;
                        }
                }
                catch (Exception ex)
                {
                    if (ex.ToString().Contains("System.ArgumentException") == true)
                    {
                        MessageBox.Show("Путь сохранения файла не может быть пустым");
                    }
                    else
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            createButton.Enabled = true;
        }

        public string[] newDov() 
        {
            string[] dov = new string[19];
            dov[0] = CheckTextBox(guidTextBox.Text.Trim()); //Гуид продукта
            dov[1] = CheckTextBox(snilsPodTextBox.Text.Trim()); //СНИЛС подписанта
            dov[2] = CheckTextBox(birthPodTextBox.Text.Trim()); //дата рождения подписанта
            dov[3] = CheckTextBox(dataPodPassTextBox.Text.Trim()); //дата выдачи паспорта
            dov[4] = CheckTextBox(whoPodTextBox.Text.Trim()); //Кем выдан
            dov[5] = CheckTextBox(passNumTextBox.Text.Trim()); //Номер паспорта
            dov[6] = CheckTextBox(serialNumTextBox.Text.Trim()); //Серия
            dov[7] = CheckTextBox(placeBirthPodTextBox.Text.Trim()); //Место рождения
            dov[8] = CheckTextBox(codeNumTextBox.Text.Trim()); //Код подразделения
            dov[9] = CheckTextBox(firNameLidTextBox.Text.Trim()); //Имя руководителя
            dov[10] = CheckTextBox(secNameLidTextBox.Text.Trim()); //Фамилия руководителя
            if (withoutPatLidCheckBox.Checked == false)
            {
                dov[11] = CheckTextBox(patNameLidTextBox.Text.Trim()); //Отчество
            }
            dov[12] = CheckTextBox(postLidTextBox.Text.Trim()); //Должность
            dov[13] = CheckTextBox(telNumberTextBox.Text.Trim()); //Телефон
            dov[14] = CheckTextBox(snilsLidTextBox.Text.Trim()); //СНИЛС Руководителя 
            dov[15] = CheckTextBox(maleTextBox.Text.Trim()); //Пол
            dov[16] = CheckTextBox(numDovTextBox.Text.Trim()); //Номер доверенности
            dov[17] = CheckTextBox(startDataDovTextBox.Text.Trim()); //дата начала действия
            dov[18] = CheckTextBox(endDataTextBox.Text.Trim()); //дата окончания действия
            return dov;
        }

        public string CheckTextBox(string text) 
        {
            if (text != null || text != "")
            {
                return text;
            }
            return "Error";
        }

        public string ValueInArray(string[] dov) 
        {
            foreach (string value in dov)
            {
                if (value == dov.Last())
                {
                    readyDov += $"{value}";
                }
                else
                {
                    readyDov += $"{value},";
                }
            }
            return readyDov;
        }

    }
}
