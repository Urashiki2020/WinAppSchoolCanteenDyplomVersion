using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//Данная библиотека позволяет использовать функции, команды и методы для работы с базой данных
using System.Data.SqlClient;//Поставщик данных платформы .NET для SQL Server
using System.Data.Odbc;//Протокол используемый для подключения базы данных Microsoft SQL Server
using System.Media;//Данная библиотека содержит классы для воспроизведения звуковых файлов и работы с системными звуками

namespace Dyplomka
{
    public partial class FormMakeAnOrder : Form
    {
        public FormMakeAnOrder()
        {
            InitializeComponent();
            textBoxQuantity.Text = "Количество";//Обращаемся к "textBoxQuantity", обращаемся к тексту и при открытии данной формы помещаем данный текст в "textBoxQuantity"
            textBoxQuantity.ForeColor = Color.Gray;//Устанавливаем начальный цвет текста подсказки в нашем случае это "Серый"

            this.StartPosition = FormStartPosition.CenterScreen;//Отображает форму в центре экрана при запуске

        }

        private void FormMakeAnOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCanteenDataSet2.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter1.Fill(this.schoolCanteenDataSet2.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCanteenDataSet5.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter2.Fill(this.schoolCanteenDataSet5.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCanteenDataSet1.Dining_room_menu". При необходимости она может быть перемещена или удалена.
            this.dining_room_menuTableAdapter.Fill(this.schoolCanteenDataSet1.Dining_room_menu);

        }

        private void buttonTakeAnOrder_Click(object sender, EventArgs e)
        {
            SoundPlayer PressingButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Подготовка к ВКР\Dyplomka\Sounds\Звуки для моей программы\Pressing button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "PressingButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            PressingButton.Play();//Воспроизводим данный аудиофайл

            ClassIniDataBase classIniDataBase = new ClassIniDataBase();
            SqlCommand command = new SqlCommand("INSERT INTO [Orders] ([Клиент], [Продукт], [Цена], [Количество]) Values (@Client, @Product, @Price, @Quantity)", classIniDataBase.GetConnection());
            command.Parameters.Add("@Client", SqlDbType.VarChar).Value = comboBoxClient.Text;
            command.Parameters.Add("@Product", SqlDbType.VarChar).Value = comboBoxNameOfProduct.Text;
            command.Parameters.Add("@Price", SqlDbType.VarChar).Value = comboBoxPrice.Text;
            command.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = textBoxQuantity.Text;

            classIniDataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Ваш заказ был выполнен успешно");
            else
                MessageBox.Show("Ваш заказ не выполнен");
            classIniDataBase.CloseConnection();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SoundPlayer PressingButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Подготовка к ВКР\Dyplomka\Sounds\Звуки для моей программы\Pressing button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "PressingButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            PressingButton.Play();//Воспроизводим данный аудиофайл

            this.Hide();
            FormClientMainMenu formClientMainMenu = new FormClientMainMenu();
            formClientMainMenu.Show();
        }

        private void buttonTakeAnOrder_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer HoverOverAButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Подготовка к ВКР\Dyplomka\Sounds\Звуки для моей программы\Hover over a button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "HoverOverAButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            HoverOverAButton.Play();//Воспроизводим данный аудиофайл
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

        private void labelClosingTheForm_MouseLeave(object sender, EventArgs e)
        {
            labelClosingTheForm.ForeColor = Color.White;//Цвет кнопки при убирании курсора мыши
        }

        Point lastPoint;//Реализуем переменную, она будет идти от класса Point. Point - это специальный класс для задания координат

        private void MainPanel8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Делаем проверку, если мы нажали на левую кнопку мыши, то в таком случае мы будем двигать панель
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel8_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//Устанавливаем новые координаты в переменную "lastPoint"
        }

        private void TopPanel8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Делаем проверку, если мы нажали на левую кнопку мыши, то в таком случае мы будем двигать панель
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel8_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//Устанавливаем новые координаты в переменную "lastPoint"
        }

        private void textBoxQuantity_Enter(object sender, EventArgs e)
        {
            if (textBoxQuantity.Text == "Количество")//Делаем проверку, если текст внутри этого поля он равен "Количество", то только в таком случае мы "textBoxQuantity" будем очищать от текста, в других случаях мы его очищать от текста не будем
            {
                textBoxQuantity.Text = "";//Обращаемся к "textBoxNameField", обращаемся к тексту который находится внутри него и устанавливаем его пустым
                textBoxQuantity.ForeColor = Color.Black;//Когда пользователь вводит текст то он будет "Черный" 
            }
        }

        private void textBoxQuantity_Leave(object sender, EventArgs e)
        {
            if (textBoxQuantity.Text == "")//Делаем проверку, если текст пустой и пользователь вышел из текстового поля, то мы устанавливаем ему обратно подсказку "Введите имя"
            {
                textBoxQuantity.Text = "Количество";//Обращаемся к "textBoxQuantity", обращаемся к тексту внутри него и вставляем текст "Количество"
                textBoxQuantity.ForeColor = Color.Gray;//Устанавливаем начальный цвет текста подсказки в нашем случае это "Серый"
            }
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Идентификация пользователя
            MessageBox.Show(comboBoxClient.SelectedValue.ToString());
        }
    }
}
