﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//Поставщик данных платформы .NET для SQL Server
using System.Data.Odbc;//Протокол используемый для подключения базы данных Microsoft SQL Server
using System.Media;//Данная библиотека содержит классы для воспроизведения звуковых файлов и работы с системными звуками

namespace Dyplomka
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;//Отображает форму в центре экрана при запуске
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCanteenDataSet3.Orders_". При необходимости она может быть перемещена или удалена.
            this.orders_TableAdapter.Fill(this.schoolCanteenDataSet3.Orders_);
            this.reportViewer1.RefreshReport();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SoundPlayer PressingButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Подготовка к ВКР\Dyplomka\Sounds\Звуки для моей программы\Pressing button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "PressingButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            PressingButton.Play();//Воспроизводим данный аудиофайл
            PressingButton.PlaySync();//Воспроизводим данный аудиофайл первее аудиофайла "ProgramStart"

            this.Hide();//Скрываем текущее окно
            FormSalesOrder formSalesOrder = new FormSalesOrder();//Обращаемся к классу "FormSalesOrder", на его основе создаем объект "formSalesOrder" и выделяем под него память
            formSalesOrder.Show();//Обращаемся к объекту "formSalesOrder" и обращаемся к функции "Show", которая позволит нам открыть это окно
        }

        private void buttonBack_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer HoverOverAButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Подготовка к ВКР\Dyplomka\Sounds\Звуки для моей программы\Hover over a button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "HoverOverAButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            HoverOverAButton.Play();//Воспроизводим данный аудиофайл
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

        Point lastPoint;//Реализуем переменную, она будет идти от класса Point. Point - это специальный класс для задания координат
        private void MainPanel10_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Делаем проверку, если мы нажали на левую кнопку мыши, то в таком случае мы будем двигать панель
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel10_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//Устанавливаем новые координаты в переменную "lastPoint"
        }

        private void TopPanel10_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Делаем проверку, если мы нажали на левую кнопку мыши, то в таком случае мы будем двигать панель
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel10_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//Устанавливаем новые координаты в переменную "lastPoint"
        }

        private void labelClosingTheForm_MouseLeave(object sender, EventArgs e)
        {
            labelClosingTheForm.ForeColor = Color.White;//Цвет кнопки при убирании курсора мыши
        }
    }
}
