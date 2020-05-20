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
using Word = Microsoft.Office.Interop.Word;
using System.Drawing.Printing;

namespace Dyplomka
{
    public partial class FormSalesOrder : Form
    {
        private readonly string TemplateFileName = @"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Dyplomka\Report.docx";
        public FormSalesOrder()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;//Отображает форму в центре экрана при запуске
        }

        private string text = "";

        private void FormSalesOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCanteenDataSet3.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter2.Fill(this.schoolCanteenDataSet3.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCanteenDataSet2.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter1.Fill(this.schoolCanteenDataSet2.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCanteenDataSet1.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.schoolCanteenDataSet1.Orders);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SoundPlayer PressingButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Pressing button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "PressingButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            PressingButton.Play();//Воспроизводим данный аудиофайл
            PressingButton.PlaySync();//Воспроизводим данный аудиофайл первее аудиофайла "ProgramStart"

            this.Hide();//Скрываем текущее окно
            FormEmployeeMainMenu formEmployeeMainMenu = new FormEmployeeMainMenu();//Обращаемся к классу "FormEmployeeMainMenu", на его основе создаем объект "formEmployeeMainMenu" и выделяем под него память
            formEmployeeMainMenu.Show();//Обращаемся к объекту "formEmployeeMainMenu" и обращаемся к функции "Show", которая позволит нам открыть это окно
        }

        private void buttonBack_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer HoverOverAButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Hover over a button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "HoverOverAButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            HoverOverAButton.Play();//Воспроизводим данный аудиофайл
        }

        private void labelClosingTheForm_Click(object sender, EventArgs e)
        {
            SoundPlayer CloseAppButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Close app button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект " CloseAppButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            CloseAppButton.Play();//Воспроизводим данный аудиофайл
            CloseAppButton.PlaySync();//Воспроизводим данный аудиофайл первее функции "Application.Exit"

            Application.Exit();//Закрываем закрываем приложение
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
        private void MainPanel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Делаем проверку, если мы нажали на левую кнопку мыши, то в таком случае мы будем двигать панель
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel6_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//Устанавливаем новые координаты в переменную "lastPoint"
        }

        private void TopPanel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//Делаем проверку, если мы нажали на левую кнопку мыши, то в таком случае мы будем двигать панель
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel6_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);//Устанавливаем новые координаты в переменную "lastPoint"
        }

        private void buttonCompleteTheOrder_Click(object sender, EventArgs e)
        {
            SoundPlayer PressingButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Pressing button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "PressingButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            PressingButton.Play();//Воспроизводим данный аудиофайл
            PressingButton.PlaySync();//Воспроизводим данный аудиофайл первее аудиофайла "ProgramStart"
        }

        private void buttonTakeAnOrder_Click(object sender, EventArgs e)
        {
            SoundPlayer PressingButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Pressing button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "PressingButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            PressingButton.Play();//Воспроизводим данный аудиофайл
            PressingButton.PlaySync();//Воспроизводим данный аудиофайл первее аудиофайла "ProgramStart"
        }

        private void buttonTakeAnOrder_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer HoverOverAButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Hover over a button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "HoverOverAButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            HoverOverAButton.Play();//Воспроизводим данный аудиофайл
        }

        private void buttonCompleteTheOrder_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer HoverOverAButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Hover over a button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "HoverOverAButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            HoverOverAButton.Play();//Воспроизводим данный аудиофайл
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            SoundPlayer PressingButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Pressing button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "PressingButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            PressingButton.Play();//Воспроизводим данный аудиофайл
            PressingButton.PlaySync();//Воспроизводим данный аудиофайл первее аудиофайла "ProgramStart"

            var id_product = id_productTextBox.Text;
            var client = клиентTextBox.Text;
            var nameProduct = наименование_продуктаTextBox.Text;
            var price = ценаTextBox.Text;
            var quantity = количествоTextBox.Text;

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{id_product}", id_product, wordDocument);
                ReplaceWordStub("{Client}", client, wordDocument);
                ReplaceWordStub("{NameProduct}", nameProduct, wordDocument);
                ReplaceWordStub("{Price}", price, wordDocument);
                ReplaceWordStub("{Quantity}", quantity, wordDocument);

                wordDocument.SaveAs(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Dyplomka\Report.docx");
                wordApp.Visible = true;

            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void buttonPrint1_Click(object sender, EventArgs e)
        {
            SoundPlayer PressingButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Pressing button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "PressingButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            PressingButton.Play();//Воспроизводим данный аудиофайл
            PressingButton.PlaySync();//Воспроизводим данный аудиофайл первее аудиофайла "ProgramStart"

            text += id_productTextBox.Text;
            text += клиентTextBox.Text;
            text += наименование_продуктаTextBox.Text;
            text += ценаTextBox.Text;
            text += количествоTextBox.Text;

            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += PrintPageHandler;

            PrintDialog printDialog = new PrintDialog();

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(text, new Font("Arial", 14), Brushes.Black, 0,0);
        }

        private void buttonPrint1_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer HoverOverAButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Hover over a button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "HoverOverAButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            HoverOverAButton.Play();//Воспроизводим данный аудиофайл
        }

        private void buttonPrint_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer HoverOverAButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Задание №2 (Подготовка к ВКР)\Программное приложения для ведения учета работы школьной столовой\Sounds\Звуки для моей программы\Hover over a button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект "HoverOverAButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            HoverOverAButton.Play();//Воспроизводим данный аудиофайл
        }
    }
}
