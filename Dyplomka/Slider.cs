using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;//Данная библиотека содержит классы для воспроизведения звуковых файлов и работы с системными звуками

namespace Dyplomka
{
    public partial class Slider : UserControl
    {
        public Slider()
        {
            InitializeComponent();
        }

        private void labelGreeting_Click(object sender, EventArgs e)
        {
            SoundPlayer CloseAppButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Подготовка к ВКР\Dyplomka\Sounds\Звуки для моей программы\Close app button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект " CloseAppButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            CloseAppButton.Play();//Воспроизводим данный аудиофайл
            CloseAppButton.PlaySync();//Воспроизводим данный аудиофайл первее функции "Application.Exit"

            this.Hide();
            FormAuthorization formAuthorization = new FormAuthorization();
            formAuthorization.Show();
        }

        int panel1_x = 450;

        private void timerGreeting_Tick(object sender, EventArgs e)
        {
            panel1_x -= 4;
            panel1.Size = new Size(panel1.Size.Width, panel1_x);

            if (panel1_x < 1)
            {
                panel1.Hide();
                timerGreeting.Enabled = false;
            }
        }

        private void labelGreeting_MouseEnter(object sender, EventArgs e)
        {
            labelGreeting.ForeColor = Color.Green;//Цвет кнопки при наведении курсора мыши
            SoundPlayer HoverOverAButton = new SoundPlayer(@"F:\Urashiki\Учёба\Преддипломная практика и ВКР\Готовые задания\Подготовка к ВКР\Dyplomka\Sounds\Звуки для моей программы\Hover over a button.wav");//Обращаемся к классу "SoundPlayer" на его основе создаем объект " HoverOverAButton", указываем путь к ауйдиофайлу, имя аудиофайла и его формат
            HoverOverAButton.Play();//Воспроизводим данный аудиофайл
        }

        private void labelGreeting_MouseLeave(object sender, EventArgs e)
        {
            labelGreeting.ForeColor = Color.White;//Цвет кнопки при убирании курсора мыши
        }
    }
}
