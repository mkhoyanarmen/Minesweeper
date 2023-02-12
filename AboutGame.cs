using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Bomb
{
    public partial class AboutGame : Form
    {
        public AboutGame()
        {
            InitializeComponent();

            lblKayqiLink.Text = "Մյուս աշխատանքները տեսնելու համար սեղմեք";
            lblKayqiLink.ForeColor = Color.Blue;
            lblKayqiLink.Click += (s, e) => { Process.Start("https://github.com/mkhoyanarmen?tab=repositories"); };
        }
    }
}
