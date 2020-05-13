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
using System.Media;//Данная библиотека содержит классы для воспроизведения звуковых файлов и работы с системными звуками

namespace Dyplomka
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
            textBoxIdUser.Text = "ID";//Обращаемся к "textBoxIdUser", обращаемся к тексту и при открытии данной формы помещаем данный текст в "textBoxIdUser"
            textBoxIdUser.ForeColor = Color.Gray;//Устанавливаем начальный цвет текста подсказки в нашем случае это "Серый"

            textBoxNameField.Text = "Введите имя";//Обращаемся к "textBoxNameField", обращаемся к тексту и при открытии данной формы помещаем данный текст в "textBoxNameField"
            textBoxNameField.ForeColor = Color.Gray;//Устанавливаем начальный цвет текста подсказки в нашем случае это "Серый"

            textBoxSurnameField.Text = "Введите фамилию";//Обращаемся к "textBoxSurnameField", обращаемся к тексту и при открытии данной формы помещаем данный текст в "textBoxSurnameField
            textBoxSurnameField.ForeColor = Color.Gray;//Устанавливаем начальный цвет текста подсказки в нашем случае это "Серый"

            textBoxRoleField.Text = "Введите роль";//Обращаемся к "textBoxRoleField", обращаемся к тексту и при открытии данной формы помещаем данный текст в "textBoxRoleField"
            textBoxRoleField.ForeColor = Color.Gray;//Устанавливаем начальный цвет текста подсказки в нашем случае это "Серый"

            this.StartPosition = FormStartPosition.CenterScreen;//Отображает форму в центре экрана при запуске

            this.textBoxSurnameField.AutoSize = false;//Отключаем свойство AutoSize
            this.textBoxSurnameField.Size = new Size(this.textBoxSurnameField.Size.Width, 52);//Подгоняем высоту "textBoxSurnameField" под "textBoxNameField"

            this.textBoxPassword.AutoSize = false;//Отключаем свойство AutoSize
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 52);//Подгоняем высоту "textBoxPassword" под "textBoxUser"
        }

        private void labelClosingTheForm_Click(object sender, EventArgs e)
        {
            SoundPlayer CloseAppButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Close app button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект " CloseAppButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            CloseAppButton.Play();//Воспроизводим данный аудиофайл
            CloseAppButton.PlaySync();//Воспроизводим данный аудиофайл первее функции "Application.Exit"

            Application.Exit();
        }

        private void labelClosingTheForm_MouseEnter(object sender, EventArgs e)
        {
            labelClosingTheForm.ForeColor = Color.Green;//Цвет кнопки при наведении курсора мыши
            SoundPlayer HoverOverAButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Hover over a button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект " HoverOverAButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            HoverOverAButton.Play();//Воспроизводим данный аудиофайл
        }

        private void labelClosingTheForm_MouseLeave(object sender, EventArgs e)
        {
            labelClosingTheForm.ForeColor = Color.White;//Цвет кнопки при убирании курсора мыши
        }


        Point lastPoint;//Реализуем переменную, она будет идти от класса Point. Point - это специальный класс для задания координат

        private void MainPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Делаем проверку, если мы нажали на левую кнопку мыши, то в таком случае мы будем двигать панель
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//Устанавливаем новые координаты в переменную "lastPoint"
        }

        private void TopPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Делаем проверку, если мы нажали на левую кнопку мыши, то в таком случае мы будем двигать панель
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//Устанавливаем новые координаты в переменную "lastPoint"
        }

        private void buttonRegister_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer HoverOverAButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Hover over a button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "HoverOverAButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            HoverOverAButton.Play();//Воспроизводим данный аудиофайл
        }

        private void textBoxNameField_Enter(object sender, EventArgs e)
        {
            if (textBoxNameField.Text == "Введите имя")//Делаем проверку, если текст внутри этого поля он равен "Введите имя", то только в таком случае мы "textBoxNameField" будем очищать от текста, в других случаях мы его очищать от текста не будем
            {
                textBoxNameField.Text = "";//Обращаемся к "textBoxNameField", обращаемся к тексту который находится внутри него и устанавливаем его пустым
                textBoxNameField.ForeColor = Color.Black;//Когда пользователь вводит текст то он будет "Черный" 
            }
        }

        private void textBoxNameField_Leave(object sender, EventArgs e)
        {
            if (textBoxNameField.Text == "")//Делаем проверку, если текст пустой и пользователь вышел из текстового поля, то мы устанавливаем ему обратно подсказку "Введите имя"
            { 
                textBoxNameField.Text = "Введите имя";//Обращаемся к "textBoxSurnameField", обращаемся к тексту внутри него и вставляем текст "Введите имя"
                textBoxNameField.ForeColor = Color.Gray;//Устанавливаем начальный цвет текста подсказки в нашем случае это "Серый"
            }
        }

        private void textBoxSurnameField_Enter(object sender, EventArgs e)
        {
            if (textBoxSurnameField.Text == "Введите фамилию")//Делаем проверку, если текст внутри этого поля он равен "Введите фамилию", то только в таком случае мы "textBoxSurnameField" будем очищать от текста, в других случаях мы его очищать от текста не будем
            {
                textBoxSurnameField.Text = "";//Обращаемся к "textBoxSurnameField", обращаемся к тексту который находится внутри него и устанавливаем его пустым
                textBoxSurnameField.ForeColor = Color.Black;//Когда пользователь вводит текст то он будет "Черный" 
            }
        }

        private void textBoxSurnameField_Leave(object sender, EventArgs e)
        {
            if (textBoxSurnameField.Text == "")//Делаем проверку, если текст пустой и пользователь вышел из текстового поля, то мы устанавливаем ему обратно подсказку "Введите фамилию"
            {
                textBoxSurnameField.Text = "Введите фамилию";//Обращаемся к "textBoxSurnameField", обращаемся к тексту внутри него и вставляем текст "Введите фамилию"
                textBoxSurnameField.ForeColor = Color.Gray;//Устанавливаем начальный цвет текста подсказки в нашем случае это "Серый"
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            SoundPlayer PressingButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Pressing button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "PressingButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            PressingButton.Play();//Воспроизводим данный аудиофайл
            PressingButton.PlaySync();//Воспроизводим данный аудиофайл первее проверок: "Заполнение всех textBox полей", 

            if (textBoxIdUser.Text == "Введите ID")//Если "textBoxIdUser.Text" равен "Введите ID", то это означает что пользователь ничего не ввел
            {
                MessageBox.Show("Введите ID!");//Если пользователь не ввел "ID", то ему выдается эта ошибка  
                return;//Выходим из функции
            }

            if (textBoxNameField.Text == "Введите имя")//Если "textBoxNameField.Text" равен "Введите имя", то это означает что пользователь ничего не ввел
            {
                MessageBox.Show("Введите имя!");//Если пользователь не ввел "Имя", то ему выдается эта ошибка
                return;//Выходим из функции
            }

            if (textBoxSurnameField.Text == "Введите фамилию")//Если "textBoxSurnameField.Text" равен "Введите фамилию", то это означает что пользователь ничего не ввел
            {
                MessageBox.Show("Введите фамилию!");//Если пользователь не ввел "Фамилия", то ему выдается эта ошибка
                return;//Выходим из функции
            }

            if (textBoxRoleField.Text == "Введите роль")//Если "textBoxRoleField.Text" равен "Введите роль, то это означает что пользователь ничего не ввел
            {
                MessageBox.Show("Введите роль!");//Если пользователь не ввел "Роль", то ему выдается эта ошибка
                return;//Выходим из функции
            }

            if (textBoxLogin.Text == "")//Если "textBoxLogin.Text" равен "", то это означает что пользователь ничего не ввел
            {
                MessageBox.Show("Введите логин!");//Если пользователь не ввел "Логин", то ему выдается эта ошибка
                return;//Выходим из функции
            }

            if (textBoxPassword.Text == "")//Если "textBoxPassword.Text" равен "", то это означает что пользователь ничего не ввел
            {
                MessageBox.Show("Введите пароль!");//Если пользователь не ввел "Пароль", то ему выдается эта ошибка
                return;//Выходим из функции
            }

            if (isIdExists())//Если это функция возаращает значение "true", выходим из функции с помощью "return"
                return;//Выходим из функции

            if (isLoginExists())//Если это функция возаращает значение "true", выходим из функции с помощью "return"
                return;//Выходим из функции

            ClassIniDataBase classIniDataBase = new ClassIniDataBase();//Создаем объект "classIniDataBase" на основе класса "ClassIniDataBase", через этот объект мы можем иметь доступ к различным функциям, которые прописаны в классе "ClassIniDataBase"
            SqlCommand command = new SqlCommand("INSERT INTO [Users] ([id_user], [login], [password], [role], [name], [surname]) VALUES (@id_user, @login, @password, @role, @name, @surname)", classIniDataBase.GetConnection());//С помощью SQL запроса а точнее команды "INSERT INTO [Users]" - вставить в таблицу "Users", мы вставляем такие поля как "[id_user], [login], [password], [role], [name], [surname]" и с помощью "Values" - значения, указываем для каждого из них не определенное значение а что то вроде заглушки "@id_user, @login, @password, @role, @name, @surname" и используем объект "classIniDataBase" и здесь используем функция "GetConnection()", то есть указываем к какой базе данных мы подключаемся

            command.Parameters.Add("@id_user", SqlDbType.VarChar).Value = textBoxIdUser.Text;//Обращаемся к объекту "command", обращаемся к "Parameters", обращаемся к функции "Add" указываем в какой параметр будем добавлять в нашем случае это "@id_user", указываем тип данных который мы будем устанавливать в нашем случае это "SqlDbType.VarChar", через точку обращаемся к "Value" и устанавливаем значение нашем случае это "textBoxIdUser.Text" 
            command.Parameters.Add("@login", SqlDbType.VarChar).Value = textBoxLogin.Text;//Обращаемся к объекту "command", обращаемся к "Parameters", обращаемся к функции "Add" указываем в какой параметр будем добавлять в нашем случае это "@login", указываем тип данных который мы будем устанавливать в нашем случае это "SqlDbType.VarChar", через точку обращаемся к "Value" и устанавливаем значение нашем случае это "textBoxLogin.Text"
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = textBoxPassword.Text;//Обращаемся к объекту "command", обращаемся к "Parameters", обращаемся к функции "Add" указываем в какой параметр будем добавлять в нашем случае это "@password", указываем тип данных который мы будем устанавливать в нашем случае это "SqlDbType.VarChar", через точку обращаемся к "Value" и устанавливаем значение нашем случае это "textBoxPassword.Text"
            command.Parameters.Add("@role", SqlDbType.VarChar).Value = textBoxRoleField.Text;//Обращаемся к объекту "command", обращаемся к "Parameters", обращаемся к функции "Add" указываем в какой параметр будем добавлять в нашем случае это "@role", указываем тип данных который мы будем устанавливать в нашем случае это "SqlDbType.VarChar", через точку обращаемся к "Value" и устанавливаем значение нашем случае это "textBoxRoleField.Text"
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = textBoxNameField.Text;//Обращаемся к объекту "command", обращаемся к "Parameters", обращаемся к функции "Add" указываем в какой параметр будем добавлять в нашем случае это "@name", указываем тип данных который мы будем устанавливать в нашем случае это "SqlDbType.VarChar", через точку обращаемся к "Value" и устанавливаем значение нашем случае это "textBoxNameField.Text"
            command.Parameters.Add("@surname", SqlDbType.VarChar).Value = textBoxSurnameField.Text;//Обращаемся к объекту "command", обращаемся к "Parameters", обращаемся к функции "Add" указываем в какой параметр будем добавлять в нашем случае это "@surname", указываем тип данных который мы будем устанавливать в нашем случае это "SqlDbType.VarChar", через точку обращаемся к "Value" и устанавливаем значение нашем случае это "textBoxSurnameField.Text"

            classIniDataBase.OpenConnection();//Обращаемся к объекту "classIniDataBase" и обращаемся к функции "OpenConnection" для открытия соединения с базой данных

            if (command.ExecuteNonQuery() == 1)//Обращаемся к объекту "command", обращаемся к функции "ExecuteNonQuery", которая выполнит нам SQL запрос и здесь мы проверяем если она равна 1, то в таком случае мы будем знать что у нас все обработалось корректно
                MessageBox.Show("Аккаунт зарегистрирован успешно");//Сообщение о том что пользователь зарегистрировался успешно
            else
                MessageBox.Show("Аккаунт не был зарегистрирован");//Сообщение о том что аккаунт не был зарегистрирован

            classIniDataBase.CloseConnection();//Обращаемся к объекту "classIniDataBase" и обращаемся к функции "CloseConnection" для закрытия соединения с базой данных
        }

        public Boolean isIdExists()//Данная функция возвращает тип данных "Boolean", то есть true, если идентификатор пользователя есть и false если, такого идентификатора пользователя нету в базе данных
        {
            ClassIniDataBase classIniDataBase = new ClassIniDataBase();//Создаем объект "classIniDataBase" на основе класса "ClassIniDataBase", через этот объект мы можем иметь доступ к различным функциям, которые прописаны в классе "ClassIniDataBase"

            DataTable table = new DataTable();//Создаем объект "table" на основе класса "DataTable"

            SqlDataAdapter adapter = new SqlDataAdapter();//Создаем объект "adapter" на основе класса "SqlDataAdapter"

            SqlCommand command = new SqlCommand("SELECT * FROM [Users] WHERE [id_user] = @ID", classIniDataBase.GetConnection());//Создаем объект "command" на основе класса "SqlCommand", с помощью SQL запроса а точнее команды "SELECT * FROM [Users]" - выбрать все из таблицы "Users", с помощью условия "WHERE", то есть мы говорим, где "id_user" равен "@ID"и используем объект "classIniDataBase" и здесь используем функцию "GetConnection()", то есть указываем к какой базе данных мы подключаемся
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = textBoxIdUser.Text;//Обращаемся к объекту "command", обращаемся к "Parameters", обращаемся к функции "Add" указываем в какой параметр будем добавлять в нашем случае это "@ID", указываем тип данных который мы будем устанавливать в нашем случае это "SqlDbType.VarChar", через точку обращаемся к "Value" и устанавливаем значение нашем случае это "textBoxIdUser.Text"

            adapter.SelectCommand = command;//Обращаемся к объекту "adapter", обращаемся к "SelectCommand" и указываем какая комманда будет выполняться в нашем случае это "command"
            adapter.Fill(table);//Обращаемся к объекту "adapter", обращаемся к "Fill" и заполняем такой объект как "table", при помощи тех данных, которые получили

            if (table.Rows.Count > 0)//Обращаемся к объекту "table", обращаемся к "Rows", то есть к количеству рядов и обращаемся к "Count", то есть считаем сколько у нас рядов, если их больше чем 0, то мы можем 100% утверждать что данный идентификатор пользователя есть
            {
                MessageBox.Show("Такой идентификатор уже существует, введите другой");//Если такой идентификатор пользователя был найден, то выйдет сообщение об ошибке
                return true;//Если такой идентификатор пользователя был найден, то возвращаем значение "true"
            }
            else
                return false;//Если такой идентификатор пользователя не был найден, то возвращаем значение "false"
        }

        public Boolean isLoginExists()//Данная функция возвращает тип данных "Boolean", то есть true, если логин пользователя есть и false если, такого логина пользователя нету в базе данных
        {
            ClassIniDataBase classIniDataBase = new ClassIniDataBase();//Создаем объект "classIniDataBase" на основе класса "ClassIniDataBase", через этот объект мы можем иметь доступ к различным функциям, которые прописаны в классе "ClassIniDataBase"

            DataTable table = new DataTable();//Создаем объект "table" на основе класса "DataTable"

            SqlDataAdapter adapter = new SqlDataAdapter();//Создаем объект "adapter" на основе класса "SqlDataAdapter"

            SqlCommand command = new SqlCommand("SELECT * FROM [Users] WHERE [login] = @uL", classIniDataBase.GetConnection());//Создаем объект "command" на основе класса "SqlCommand", с помощью SQL запроса а точнее команды "SELECT * FROM [Users]" - выбрать все из таблицы "Users", с помощью условия "WHERE", то есть мы говорим, где "login" равен "@uL"и используем объект "classIniDataBase" и здесь используем функцию "GetConnection()", то есть указываем к какой базе данных мы подключаемся
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = textBoxLogin.Text;//Обращаемся к объекту "command", обращаемся к "Parameters", обращаемся к функции "Add" указываем в какой параметр будем добавлять в нашем случае это "@uL", указываем тип данных который мы будем устанавливать в нашем случае это "SqlDbType.VarChar", через точку обращаемся к "Value" и устанавливаем значение нашем случае это "textBoxLogin.Text"

            adapter.SelectCommand = command;//Обращаемся к объекту "adapter", обращаемся к "SelectCommand" и указываем какая комманда будет выполняться в нашем случае это "command"
            adapter.Fill(table);//Обращаемся к объекту "adapter", обращаемся к "Fill" и заполняем такой объект как "table", при помощи тех данных, которые получили

            if (table.Rows.Count > 0)//Обращаемся к объекту "table", обращаемся к "Rows", то есть к количеству рядов и обращаемся к "Count", то есть считаем сколько у нас рядов, если их больше чем 0, то мы можем 100% утверждать что данный логин пользователя есть
            {
                MessageBox.Show("Такой логин уже существует, введите другой");//Если такой логин пользователя был найден, то выйдет сообщение об ошибке
                return true;//Если такой логин пользователя был найден, то возвращаем значение "true"
            }
            else
                return false;//Если такой логин пользователя не был найден, то возвращаем значение "false"
        }

        private void textBoxIdUser_Enter(object sender, EventArgs e)
        {
            if (textBoxIdUser.Text == "ID")//Делаем проверку, если текст внутри этого поля он равен "ID", то только в таком случае мы "textBoxIdUser" будем очищать от текста, в других случаях мы его очищать от текста не будем
            {
                textBoxIdUser.Text = "";//Обращаемся к "textBoxIdUser", обращаемся к тексту который находится внутри него и устанавливаем его пустым
                textBoxIdUser.ForeColor = Color.Black;//Когда пользователь вводит текст то он будет "Черный" 
            }
        }

        private void textBoxIdUser_Leave(object sender, EventArgs e)
        {
            if (textBoxIdUser.Text == "")//Делаем проверку, если текст пустой и пользователь вышел из текстового поля, то мы устанавливаем ему обратно подсказку "ID"
            {
                textBoxIdUser.Text = "ID";//Обращаемся к "textBoxIdUser", обращаемся к тексту внутри него и вставляем текст "ID"
                textBoxIdUser.ForeColor = Color.Gray;//Устанавливаем начальный цвет текста подсказки в нашем случае это "Серый"
            }
        }

        private void textBoxRoleField_Enter(object sender, EventArgs e)
        {
            if (textBoxRoleField.Text == "Введите роль")//Делаем проверку, если текст внутри этого поля он равен "Введите роль", то только в таком случае мы "textBoxRoleField" будем очищать от текста, в других случаях мы его очищать от текста не будем
            {
                textBoxRoleField.Text = "";//Обращаемся к "textBoxRoleField", обращаемся к тексту который находится внутри него и устанавливаем его пустым
                textBoxRoleField.ForeColor = Color.Black;//Когда пользователь вводит текст то он будет "Черный" 
            }
        }

        private void textBoxRoleField_Leave(object sender, EventArgs e)
        {
            if (textBoxRoleField.Text == "")//Делаем проверку, если текст пустой и пользователь вышел из текстового поля, то мы устанавливаем ему обратно подсказку "ID"
            {
                textBoxRoleField.Text = "Введите роль";//Обращаемся к "textBoxRoleField", обращаемся к тексту внутри него и вставляем текст "Введите роль"
                textBoxRoleField.ForeColor = Color.Gray;//Устанавливаем начальный цвет текста подсказки в нашем случае это "Серый"
            }
        }
    }
}
