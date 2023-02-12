using System;
using System.Drawing;
using System.Windows.Forms;
using Ական.Properties;

namespace Bomb
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }
        private int qayl = 0;
        private Random index;
        private Image nkarAkan, nkarKochak, nkarDroshak, nkar1, nkarHaxtanak,
            nkar2, nkar3, nkar4, nkar5, nkar6, nkar7, nkar8, nkarDatark, nkarAkaniPoxaren;
        private Image[] nkarner;
        private int akan, qanakAkan = 0, sexmmanQanak, haxtakanQanak, yndhanurKochakner = 0;

        AboutGame xaghiMasin;
        private void miDursGal_Click(object sender, EventArgs e)//հարցում խաղից դուրս գալու ժամանակ
        {
            Vayrkyanachap.Stop();
            if (MessageBox.Show("Արդյո՞ք ցանկանում եք դուրս գալ խաղից:", "Դուրս գալ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (sexmmanQanak > 1)
            {
                Vayrkyanachap.Start();
            }
        }

        private void miMasin_Click(object sender, EventArgs e)//<<Մասին>> կոճակի սեղմումով բացում է համապատասխան պատուհանը
        {

            if (xaghiMasin.Created)
            {
                return;
            }
            else
            {
                xaghiMasin = new AboutGame();
                xaghiMasin.Show();
            }

        }
        private void miPakel_Click(object sender, EventArgs e)//minimiize է անում պատուհանը
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnVersksel_Click(object sender, EventArgs e)//ապահովում է խաղի վերսկսում
        {
            Vayrkyanachap.Stop();
            if (MessageBox.Show("Արդյո՞ք ցանկանում եք վերսկսել խաղը:", "Վերսկսել", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                qayl = 0;
                lblVayrkyanner.Text = "0";
                verskselXaghy();
            }
            else if (sexmmanQanak > 1)
            {
                Vayrkyanachap.Start();
            }
        }
        private void frmGame_Load(object sender, EventArgs e)
        {
            nkarKochak = Resources.button;
            nkarAkan = Resources.btnMine;
            nkarAkaniPoxaren = Resources.btnNearlyMine;
            nkarDroshak = Resources.btnFlag;
            nkarHaxtanak = Resources.btnVictory;
            nkar1 = Resources.btn1;
            nkar2 = Resources.btn2;
            nkar3 = Resources.btn3;
            nkar4 = Resources.btn4;
            nkar5 = Resources.btn5;
            nkar6 = Resources.btn6;
            nkar7 = Resources.btn7;
            nkar8 = Resources.btn8;
            nkarDatark = Resources.btnEmpty;

            nkarner = new Image[] { nkarAkaniPoxaren, nkarAkan, nkarDroshak, nkar1,
                                    nkar2, nkar3, nkar4, nkar5, nkar6, nkar7, nkar8 };

            xaghiMasin = new AboutGame();

            haxtakanQanak = int.Parse(lblAkan.Text);

            verskselXaghy();

        }

        private void frmGame_FormClosing(object sender, FormClosingEventArgs e)//հարցում խաղից դուրս գալու ժամանակ
        {
            Vayrkyanachap.Stop();
            if (MessageBox.Show("Արդյո՞ք ցանկանում եք դուրս գալ խաղից:", "Դուրս գալ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                if (sexmmanQanak > 0)
                {
                    Vayrkyanachap.Start();
                }
            }
        }

        private void Vayrkyanachap_Tick(object sender, EventArgs e)//ապահովում է վայրկյանաչափի աշխ.-ը
        {
            qayl++;
            lblVayrkyanner.Text = qayl.ToString();
        }

        private void dgKochakner_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!Vayrkyanachap.Enabled)
            {
                Vayrkyanachap.Start();
            }

            switch (e.Button)
            {
                case MouseButtons.Left://ձախ click-ի դեպքում, եթե վանդակի արժեքը ական չէ, տեղադրվում է թիվը, հ.դ. ականը
                    if (dgKochakner.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == nkarDatark || dgKochakner.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == nkarDroshak)
                    {
                        break;
                    }
                    tveri_texadrum(e.RowIndex, e.ColumnIndex);
                    if (ardyoq_Vandaky_Datark_e(e.RowIndex, e.ColumnIndex))
                    {
                        datarkVandakneriBacum(e.RowIndex, e.ColumnIndex, e);
                    }
                    break;
                case MouseButtons.Right://Աջ click-ի դեպքում տեղադրվում է դրոշակ,այնուհետև հարցական նշան
                    sexmmanQanak++;
                    if (dgKochakner.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != nkarKochak && dgKochakner.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != nkarAkaniPoxaren && dgKochakner.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != nkarDroshak)
                    {
                        return;
                    }
                    if (dgKochakner.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != nkarDroshak)
                    {
                        if (dgKochakner.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == nkarAkaniPoxaren)
                        {
                            dgKochakner.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = nkarDroshak;
                            akan--;
                            dgKochakner.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            dgKochakner.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = nkarDroshak;
                            akan--;
                        }
                    }
                    else
                    {
                        if (dgKochakner.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Red)
                        {
                            dgKochakner.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = nkarAkaniPoxaren;
                            akan++;
                        }
                        else
                        {
                            dgKochakner.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = nkarKochak;
                            akan++;
                        }
                    }
                    lblAkan.Text = akan.ToString();
                    break;
            }
        }
        private void partutyun()
        {
            Vayrkyanachap.Stop();
            for (int i = 0; i < dgKochakner.RowCount; i++)
            {
                for (int j = 0; j < dgKochakner.ColumnCount; j++)
                {
                    if (dgKochakner.Rows[i].Cells[j].Value == nkarAkaniPoxaren)
                    {
                        dgKochakner.Rows[i].Cells[j].Value = nkarAkan;
                    }
                }
            }
            btnVersksel.Image = Resources.btnAngry;
            MessageBox.Show("Դուք պարտվեցիք թողնելով " + akan + " հատ ական", "Պարտություն", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void verskselXaghy()
        {
            yndhanurKochakner = 0;
            dgKochakner.Enabled = true;
            akan = 0;
            sexmmanQanak = 0;
            lblVayrkyanner.Text = "0";
            qayl = 0;
            btnVersksel.Image = Resources.btnSmile;

            index = new Random();
            dgKochakner.RowCount = dgKochakner.ColumnCount = 16;
            for (int i = 0; i < dgKochakner.RowCount; i++)
            {
                for (int j = 0; j < dgKochakner.ColumnCount; j++)
                {
                    dgKochakner.Columns[j].Width = 30;
                    dgKochakner.Rows[i].Cells[j] = new DataGridViewImageCell();
                    dgKochakner.Rows[i].Cells[j].Value = nkarKochak;
                }
            }
            for (int i = 0; i < 40; i++)
            {
                dgKochakner.Rows[index.Next(0, 16)].Cells[index.Next(0, 16)].Value = nkarAkaniPoxaren;
            }
            for (int i = 0; i < dgKochakner.RowCount; i++)
            {
                for (int j = 0; j < dgKochakner.ColumnCount; j++)
                {
                    if (dgKochakner.Rows[i].Cells[j].Value == nkarAkaniPoxaren)
                    {
                        akan++;
                    }
                }
            }
            lblAkan.Text = akan.ToString();
            haxtakanQanak = akan;
        }
        private void datarkVandakneriBacum(int tox, int syun, DataGridViewCellMouseEventArgs e)
        {
            if (e == null)
            {
                tveri_texadrum(tox, syun);
            }
            if (dgKochakner.Rows[tox].Cells[syun].Value != nkarDatark)
            {
                return;
            }
            for (int i = tox - 1; i < tox + 2; i++)
            {
                for (int j = syun - 1; j < syun + 2; j++)
                {
                    if (!ardyoq_sahmannerum_e(i, j))
                    {
                        continue;
                    }
                    if (dgKochakner.Rows[i].Cells[j].Value != nkarKochak)
                    {
                        continue;
                    }

                    if (ardyoq_Vandaky_Datark_e(i, j))
                    {
                        datarkVandakneriBacum(i, j, null);
                    }
                    else if (!ardyoq_Vandaky_Datark_e(i, j))
                    {
                        tveri_texadrum(i, j);
                    }

                }
            }

        }
        private bool ardyoq_Vandaky_Datark_e(int tox, int syun)
        {
            bool t = true;
            for (int i = 0; i < nkarner.Length; i++)
            {
                if (dgKochakner.Rows[tox].Cells[syun].Value == nkarner[i])
                {
                    t = false;
                    break;
                }
            }
            return t;
        }

        private bool ardyoq_sahmannerum_e(int tox, int syun)
        {
            if (tox < 0 || syun < 0 || syun > dgKochakner.ColumnCount - 1 || tox > dgKochakner.RowCount - 1)
            {
                return false;
            }
            return true;
        }

        private void tveri_texadrum(int tox, int syun)
        {
            qanakAkan = 0;
            sexmmanQanak++;
            if (sexmmanQanak == 1 && dgKochakner.Rows[tox].Cells[syun].Value == nkarAkaniPoxaren)
            {
                verskselXaghy();
                for (int i = tox - 1; i < tox + 2; i++)
                {
                    for (int j = syun - 1; j < syun + 2; j++)
                    {
                        if (!ardyoq_sahmannerum_e(i, j))
                        {
                            continue;
                        }
                        if (dgKochakner.Rows[i].Cells[j].Value == nkarAkaniPoxaren || dgKochakner.Rows[i].Cells[j].Style.BackColor == Color.Red)
                        {
                            qanakAkan++;
                        }
                    }
                }
            }
            else
            {
                if (dgKochakner.Rows[tox].Cells[syun].Value == nkarAkaniPoxaren)
                {
                    partutyun();
                    dgKochakner.Enabled = false;
                    return;
                }
                else
                {
                    for (int i = tox - 1; i < tox + 2; i++)
                    {
                        for (int j = syun - 1; j < syun + 2; j++)
                        {
                            if (!ardyoq_sahmannerum_e(i, j))
                            {
                                continue;
                            }
                            if (dgKochakner.Rows[i].Cells[j].Value == nkarAkaniPoxaren || dgKochakner.Rows[i].Cells[j].Style.BackColor == Color.Red)
                            {
                                qanakAkan++;
                            }
                        }
                    }
                }
            }
            switch (qanakAkan)//ըստ շուրջը եղած ականների քանակի տեղադրվում է համապատասխան թիվը
            {
                case 1:
                    dgKochakner.Rows[tox].Cells[syun].Value = nkar1;
                    yndhanurKochakner++;
                    break;
                case 2:
                    dgKochakner.Rows[tox].Cells[syun].Value = nkar2;
                    yndhanurKochakner++;
                    break;
                case 3:
                    dgKochakner.Rows[tox].Cells[syun].Value = nkar3;
                    yndhanurKochakner++;
                    break;
                case 4:
                    dgKochakner.Rows[tox].Cells[syun].Value = nkar4;
                    yndhanurKochakner++;
                    break;
                case 5:
                    dgKochakner.Rows[tox].Cells[syun].Value = nkar5;
                    yndhanurKochakner++;
                    break;
                case 6:
                    dgKochakner.Rows[tox].Cells[syun].Value = nkar6;
                    yndhanurKochakner++;
                    break;
                case 7:
                    dgKochakner.Rows[tox].Cells[syun].Value = nkar7;
                    yndhanurKochakner++;
                    break;
                case 8:
                    dgKochakner.Rows[tox].Cells[syun].Value = nkar8;
                    yndhanurKochakner++;
                    break;
                default:
                    dgKochakner.Rows[tox].Cells[syun].Value = nkarDatark;
                    yndhanurKochakner++;
                    break;
            }
            dgKochakner.Rows[tox].Cells[syun].ReadOnly = true;
            if (yndhanurKochakner == (dgKochakner.RowCount * dgKochakner.ColumnCount) - haxtakanQanak)
            {
                haxtanak();
            }
        }
        private void haxtanak()
        {
            for (int i = 0; i < dgKochakner.RowCount; i++)
            {
                for (int j = 0; j < dgKochakner.ColumnCount; j++)
                {
                    if (dgKochakner.Rows[i].Cells[j].Value == nkarAkaniPoxaren)
                    {
                        dgKochakner.Rows[i].Cells[j].Value = nkarDroshak;
                    }
                }
            }
            btnVersksel.Image = nkarHaxtanak;
            dgKochakner.Enabled = false;
            lblAkan.Text = "0";
            Vayrkyanachap.Stop();
            MessageBox.Show("Շնորհավորում ենք, Դուք հաղթեցիք:", "Հաղթանակ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}