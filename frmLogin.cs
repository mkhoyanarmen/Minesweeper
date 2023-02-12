using Bomb;
using System;
using System.Windows.Forms;

namespace Ական
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnMutq_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "912" && txtParol.Text == "912")
            {
                this.Close();
                frmGame Xagh = new frmGame();
                Xagh.Show();
            }
            else
            {
                lblMutq.Text = "Սխալ մուտքանուն կամ գաղտնաբառ";
            }
        }
        private void btnDursGal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
