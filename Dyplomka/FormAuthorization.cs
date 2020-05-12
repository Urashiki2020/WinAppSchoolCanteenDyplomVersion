using System;
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

namespace Dyplomka
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//Отображает форму в центре экрана при запуске
            this.textBoxPassword.AutoSize = false;//Отключаем свойство AutoSize
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 64);//Подгоняем высоту textBoxPassword под textBoxUser
        }

        private void labelClosingTheForm_Click(object sender, EventArgs e)
        {
            Application.Exit();//Закрываем закрываем приложение
        }

        private void labelClosingTheForm_MouseEnter(object sender, EventArgs e)
        {
            labelClosingTheForm.ForeColor = Color.Green;//Цвет кнопки при наведении курсора мыши
        }

        private void labelClosingTheForm_MouseLeave(object sender, EventArgs e)
        {
            labelClosingTheForm.ForeColor = Color.White;//Цвет кнопки при убирании курсора мыши
        }

        Point lastPoint;//Реализуем переменную, она будет идти от класса Point. Point - это специальный класс для задания координат
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Делаем проверку, если мы нажали на левую кнопку мыши, то в таком случае мы будем двигать панель
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//Устанавливаем новые координаты в переменную "lastPoint"
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Делаем проверку, если мы нажали на левую кнопку мыши, то в таком случае мы будем двигать панель
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//Устанавливаем новые координаты в переменную "lastPoint"
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-TVLAIMU\SQLEXPRESS;Initial Catalog=SchoolCanteen;Integrated Security=True");//Строка подключения базы данных
            try
            {
                //Проверка совпадения логин-пароль-роль для "Сотрудник"
                string commandEmployee = "SELECT*FROM Users WHERE login='" + textBoxLogin.Text + "' AND password='" + textBoxPassword.Text + "'AND role='employee'";
                SqlCommand checkEmployee = new SqlCommand(commandEmployee, connection);

                //Проверка совпадения логин-пароль-роль для "Клиент"
                string commandClient = "SELECT*FROM Users WHERE login='" + textBoxLogin.Text + "' AND password='" + textBoxPassword.Text + "'AND role='client'";
                SqlCommand checkClient = new SqlCommand(commandClient, connection);

                connection.Open();//Обращаемся к объекту "connection" и обращаемся к функции "Open", которая позволит открыть соединение с базой данных SQL Server
                if (checkEmployee.ExecuteScalar() != null)//Если логин - пароль сотрудника совпадают то переход на форму "Главное меню сотрудника"
                {
                    this.Hide();//Скрываем текущее окно
                    FormEmployeeMainMenu formEmployeeMainMenu = new FormEmployeeMainMenu();//Обращаемся к классу "FormEmployeeMainMenu", на его основе создаем объект "formEmployeeMainMenu" и выделяем под него память
                    formEmployeeMainMenu.Show();//Обращаемся к объекту "formEmployeeMainMenu" и обращаемся к функции "Show", которая позволит нам открыть это окно
                }
                else
                {
                    if (checkClient.ExecuteScalar() != null)//Если логин - пароль клиента совпадают то переход на форму "Главное меню клиента"
                    {
                        this.Hide();//Скрываем текущее окно
                        FormClientMainMenu formClientMainMenu = new FormClientMainMenu();//Обращаемся к классу "FormClientMainMenu", на его основе создаем объект "formClientMainMenu" и выделяем под него память
                        formClientMainMenu.Show();//Обращаемся к объекту "formClientMainMenu" и обращаемся к функции "Show", которая позволит нам открыть это окно
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста проверьте ещё раз введённые данные!", "Вы ввели неверный логин или пароль!");//Обращаемся к классу "MessageBox" и обращаемся к функции "Show", которая позволит нам показать данный текст в сплывающем окне
                    }
                }
            }
            catch
            {
                MessageBox.Show("Возникло исключение!");//Обращаемся к классу "MessageBox" и обращаемся к функции "Show", которая позволит нам показать данный текст в сплывающем окне
                connection.Close();////Обращаемся к объекту "connection" и обращаемся к функции "Close", которая позволит закрыть соединение с базой данных SQL Server при возникновении исключения
            }
        }
    }
}
