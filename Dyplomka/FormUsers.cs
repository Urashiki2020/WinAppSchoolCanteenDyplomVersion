using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;//Данная библиотека содержит классы для воспроизведения звуковых файлов и работы с системными звуками
using System.Globalization;
using System.Data.SqlClient;

namespace Dyplomka
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;//Отображает форму в центре экрана при запуске
        }

        private void buttonBack_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer HoverOverAButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Подготовка к ВКР\Dyplomka\Sounds\Звуки для моей программы\Hover over a button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "HoverOverAButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            HoverOverAButton.Play();//Воспроизводим данный аудиофайл
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SoundPlayer PressingButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Подготовка к ВКР\Dyplomka\Sounds\Звуки для моей программы\Pressing button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "PressingButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            PressingButton.Play();//Воспроизводим данный аудиофайл
            PressingButton.PlaySync();

            this.Hide();//Скрываем текущее окно
            FormAuthorization formAuthorization = new FormAuthorization();//Обращаемся к классу "FormAuthorization", на его основе создаем объект "formAuthorization" и выделяем под него память
            formAuthorization.Show();//Обращаемся к объекту "formAuthorization" и обращаемся к функции "Show", которая позволит нам открыть это окно
        }

        private void labelClosingTheForm_Click(object sender, EventArgs e)
        {
            SoundPlayer CloseAppButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Подготовка к ВКР\Dyplomka\Sounds\Звуки для моей программы\Close app button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект " CloseAppButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            CloseAppButton.Play();//Воспроизводим данный аудиофайл
            CloseAppButton.PlaySync();//Воспроизводим данный аудиофайл первее функции "Application.Exit"

            Application.Exit();
        }

        private void labelClosingTheForm_MouseEnter(object sender, EventArgs e)
        {
            labelClosingTheForm.ForeColor = Color.Green;//Цвет кнопки при наведении курсора мыши
            SoundPlayer HoverOverAButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Подготовка к ВКР\Dyplomka\Sounds\Звуки для моей программы\Hover over a button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект " HoverOverAButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            HoverOverAButton.Play();//Воспроизводим данный аудиофайл
        }

        private void labelClosingTheForm_MouseLeave(object sender, EventArgs e)
        {
            labelClosingTheForm.ForeColor = Color.White;//Цвет кнопки при убирании курсора мыши
        }

        Point lastPoint;//Реализуем переменную, она будет идти от класса Point. Point - это специальный класс для задания координат
        private void MainPanel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Делаем проверку, если мы нажали на левую кнопку мыши, то в таком случае мы будем двигать панель
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel4_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//Устанавливаем новые координаты в переменную "lastPoint"
        }

        private void TopPanel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Делаем проверку, если мы нажали на левую кнопку мыши, то в таком случае мы будем двигать панель
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel4_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//Устанавливаем новые координаты в переменную "lastPoint"
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SoundPlayer PressingButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Подготовка к ВКР\Dyplomka\Sounds\Звуки для моей программы\Pressing button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "PressingButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            PressingButton.Play();//Воспроизводим данный аудиофайл
            PressingButton.PlaySync();

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);//Удаление записи
            usersTableAdapter.Update(schoolCanteenDataSet);//Обновление данных в базе
            MessageBox.Show("Пользователь удален из базы данных");
        }

        private void buttonDelete_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer HoverOverAButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Подготовка к ВКР\Dyplomka\Sounds\Звуки для моей программы\Hover over a button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "HoverOverAButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            HoverOverAButton.Play();//Воспроизводим данный аудиофайл
        }

        private void buttonDisplayAll_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer HoverOverAButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Подготовка к ВКР\Dyplomka\Sounds\Звуки для моей программы\Hover over a button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "HoverOverAButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            HoverOverAButton.Play();//Воспроизводим данный аудиофайл
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCanteenDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.schoolCanteenDataSet.Users);

        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Устанавливаем фильтр в таблицу "Users"
            usersBindingSource1.Filter = "[login] =\'" + comboBoxUsers + "\'";

            //Идентификация пользователя
            MessageBox.Show(comboBoxUsers.SelectedValue.ToString());
        }
    }
}
