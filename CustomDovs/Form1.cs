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
        bool drag = false; //Перемещается ли форма
        Point start_point = new Point(0, 0); //Стартовые координаты
        string readyDov = ""; //Строка, в которую заполняются данные из массива последовательно из полей

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(guidTextBox, "Идентификатор продукта");
            toolTip.SetToolTip(telNumMTextBox, "Телефон\nФормат ввода 79999999999");
            toolTip.SetToolTip(numDovTextBox, "Номер доверенности");
            toolTip.SetToolTip(sDataDovMTextBox, "Дата начала действия доверенности" +
                "\nФормат ввода ГГГГ-ММ-ДД, где ГГГГ - Год, ММ - Месяц, ДД - День");
            toolTip.SetToolTip(eDataDovMTextBox, "Дата окончания действия доверенности" +
                "\nФормат ввода ГГГГ-ММ-ДД, где ГГГГ - Год, ММ - Месяц, ДД - День");
            toolTip.SetToolTip(snilsPodMTextBox, "СНИЛС подписанта");
            toolTip.SetToolTip(birthPodMTextBox, "Дата рождения подписанта" +
                "\nФормат ввода ГГГГ-ММ-ДД, где ГГГГ - Год, ММ - Месяц, ДД - День");
            toolTip.SetToolTip(dataPodPassMTextBox, "Дата выдачи паспорта подписанта" +
                "\nФормат ввода ГГГГ-ММ-ДД, где ГГГГ - Год, ММ - Месяц, ДД - День");
            toolTip.SetToolTip(serialNumMTextBox, "Серия паспорта подписанта");
            toolTip.SetToolTip(passNumMTextBox, "Номер паспорта подписанта");
            toolTip.SetToolTip(codeNumMTextBox, "Код подразделения из паспорта подписанта");
            toolTip.SetToolTip(whoPodTextBox, "Кем выдан паспорт подписанта");
            toolTip.SetToolTip(placeBirthPodTextBox, "Место рождения подписанта");
            toolTip.SetToolTip(secNameLidTextBox, "Фамилия руководителя");
            toolTip.SetToolTip(firNameLidTextBox, "Имя руководителя");
            toolTip.SetToolTip(patNameLidTextBox, "Отчетсво руководителя");
            toolTip.SetToolTip(maleTextBox, "Пол руководителя" +
                "\nФормат ввода 1 - мужской 2 - женский");
            toolTip.SetToolTip(snilsLidMTextBox, "СНИЛС руководителя");
            toolTip.SetToolTip(postLidTextBox, "Должность руководителя");
            toolTip.SetToolTip(refreshFirBlockButton, "Очистить общий блок");
            toolTip.SetToolTip(refreshSecBlockButton, "Очистить блок подписанта");
            toolTip.SetToolTip(refreshThiBlockButton, "Очистить блок руководителя");
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
                telNumMTextBox.Text = "";
                numDovTextBox.Text = "Номер доверенности";
                sDataDovMTextBox.Text = "";
                eDataDovMTextBox.Text = "";
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
                snilsPodMTextBox.Text = "";
                birthPodMTextBox.Text = "";
                dataPodPassMTextBox.Text = "";
                serialNumMTextBox.Text = "";
                passNumMTextBox.Text = "";
                codeNumMTextBox.Text = "";
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
                snilsLidMTextBox.Text = "";
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

        private void numDovTextBox_Click(object sender, EventArgs e)
        {
            if (numDovTextBox.Text == "Номер доверенности")
            {
                numDovTextBox.Text = "";
            }
        }


        #endregion

        #region Подписант

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
        /// <summary>
        /// Обработка изменения checkbox'а
        /// </summary>
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

        /// <summary>
        /// Главный метод, формирование файла доверенности из массива, сохранение массива в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createButton_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Обработка данных из полей
        /// </summary>
        /// <returns>Возвращает массив string с информацией из полей</returns>
        public string[] newDov() 
        {
            string[] dov = new string[19];
            dov[0] = CheckTextBox(guidTextBox.Text.Trim()); //Гуид продукта
            dov[1] = CheckTextBox(snilsPodMTextBox.Text.Trim()); //СНИЛС подписанта
            dov[2] = CheckTextBox(birthPodMTextBox.Text.Trim()); //дата рождения подписанта
            dov[3] = CheckTextBox(dataPodPassMTextBox.Text.Trim()); //дата выдачи паспорта
            dov[4] = CheckTextBox(whoPodTextBox.Text.Trim()); //Кем выдан
            dov[5] = CheckTextBox(passNumMTextBox.Text.Trim()); //Номер паспорта
            dov[6] = CheckTextBox(serialNumMTextBox.Text.Trim()); //Серия
            dov[7] = CheckTextBox(placeBirthPodTextBox.Text.Trim()); //Место рождения
            dov[8] = CheckTextBox(codeNumMTextBox.Text.Trim()); //Код подразделения
            dov[9] = CheckTextBox(firNameLidTextBox.Text.Trim()); //Имя руководителя
            dov[10] = CheckTextBox(secNameLidTextBox.Text.Trim()); //Фамилия руководителя
            if (withoutPatLidCheckBox.Checked == false)
            {
                dov[11] = CheckTextBox(patNameLidTextBox.Text.Trim()); //Отчество
            }
            dov[12] = CheckTextBox(postLidTextBox.Text.Trim()); //Должность
            dov[13] = CheckTextBox(telNumMTextBox.Text.Trim()); //Телефон
            dov[14] = CheckTextBox(snilsLidMTextBox.Text.Trim()); //СНИЛС Руководителя 
            dov[15] = CheckTextBox(maleTextBox.Text.Trim()); //Пол
            dov[16] = CheckTextBox(numDovTextBox.Text.Trim()); //Номер доверенности
            dov[17] = CheckTextBox(sDataDovMTextBox.Text.Trim()); //дата начала действия
            dov[18] = CheckTextBox(eDataDovMTextBox.Text.Trim()); //дата окончания действия
            return dov;
        }

        /// <summary>
        /// Проверка заполненности полей p.s. работает как-то не так
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string CheckTextBox(string text) 
        {
            if (text != null || text != "")
            {
                return text;
            }
            return "";
        }

        /// <summary>
        /// Проверка значения в массиве доверенности
        /// </summary>
        /// <param name="dov"></param>
        /// <returns></returns>
        public string ValueInArray(string[] dov) 
        {
            foreach (string value in dov)
            {
                if (value == dov[18])
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
