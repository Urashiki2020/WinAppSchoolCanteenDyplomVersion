using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyplomka
{
    public partial class FormGreeting : Form
    {
        public FormGreeting()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;//Отображает форму в центре экрана при запуске

            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;//цвет фона  
            this.TransparencyKey = this.BackColor;//он же будет заменен на прозрачный цвет
        }
    }
}
