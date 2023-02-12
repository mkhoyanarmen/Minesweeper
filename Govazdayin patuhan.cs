using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ական
{
    public partial class frmGovazd : Form
    {
        public frmGovazd()
        {
            InitializeComponent();
        }

        private int qayl = 0;
        private int x = 40;
        private int y = 170;
        async private void Govazdayin_patuhan_Load(object sender, EventArgs e)
        {
            tmAnim.Start();
            pbAkan.Location = new Point(40, 170);
            while (qayl < 10)
            {
                while (qayl >= 0)
                {
                    await Task.Delay(50);
                    if (x >= 230 && y <= 390 && y > 170)
                    {
                        x += 19;
                        y -= 22;
                        pbAkan.Location = new Point(x, y);
                        continue;
                    }
                    else if (x < 230 && y < 390)
                    {
                        x += 19;
                        y += 22;
                        pbAkan.Location = new Point(x, y);
                        continue;
                    }
                    break;
                }
                x = 40;
                y = 170;
            }
            this.Hide();
            frmLogin LoginiEj = new frmLogin();
            LoginiEj.Show();
        }
        private void tmAnim_Tick(object sender, EventArgs e)
        {
            qayl++;
        }
    }
}