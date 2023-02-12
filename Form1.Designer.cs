namespace Bomb
{
    partial class frmGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.խաղToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miPakel = new System.Windows.Forms.ToolStripMenuItem();
            this.miDursGal = new System.Windows.Forms.ToolStripMenuItem();
            this.miMasin = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVersksel = new System.Windows.Forms.Button();
            this.lblVayrkyanner = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAkan = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgKochakner = new System.Windows.Forms.DataGridView();
            this.Vayrkyanachap = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKochakner)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.խաղToolStripMenuItem,
            this.miMasin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 31);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // խաղToolStripMenuItem
            // 
            this.խաղToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPakel,
            this.miDursGal});
            this.խաղToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.խաղToolStripMenuItem.Name = "խաղToolStripMenuItem";
            this.խաղToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.խաղToolStripMenuItem.Text = "Խաղ";
            // 
            // miPakel
            // 
            this.miPakel.Image = ((System.Drawing.Image)(resources.GetObject("miPakel.Image")));
            this.miPakel.Name = "miPakel";
            this.miPakel.Size = new System.Drawing.Size(243, 28);
            this.miPakel.Text = "Փակել";
            this.miPakel.Click += new System.EventHandler(this.miPakel_Click);
            // 
            // miDursGal
            // 
            this.miDursGal.Image = ((System.Drawing.Image)(resources.GetObject("miDursGal.Image")));
            this.miDursGal.Name = "miDursGal";
            this.miDursGal.Size = new System.Drawing.Size(243, 28);
            this.miDursGal.Text = "Դուրս գալ խաղից";
            this.miDursGal.Click += new System.EventHandler(this.miDursGal_Click);
            // 
            // miMasin
            // 
            this.miMasin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.miMasin.Name = "miMasin";
            this.miMasin.Size = new System.Drawing.Size(81, 27);
            this.miMasin.Text = "Մասին";
            this.miMasin.Click += new System.EventHandler(this.miMasin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(446, -11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Վայրկյաններ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(58, -11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ական:";
            // 
            // btnVersksel
            // 
            this.btnVersksel.Image = ((System.Drawing.Image)(resources.GetObject("btnVersksel.Image")));
            this.btnVersksel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVersksel.Location = new System.Drawing.Point(309, 42);
            this.btnVersksel.Name = "btnVersksel";
            this.btnVersksel.Size = new System.Drawing.Size(50, 45);
            this.btnVersksel.TabIndex = 25;
            this.btnVersksel.Click += new System.EventHandler(this.btnVersksel_Click);
            // 
            // lblVayrkyanner
            // 
            this.lblVayrkyanner.AutoSize = true;
            this.lblVayrkyanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblVayrkyanner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVayrkyanner.Location = new System.Drawing.Point(598, 53);
            this.lblVayrkyanner.Name = "lblVayrkyanner";
            this.lblVayrkyanner.Size = new System.Drawing.Size(24, 25);
            this.lblVayrkyanner.TabIndex = 24;
            this.lblVayrkyanner.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(437, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Վայրկյաններ:";
            // 
            // lblAkan
            // 
            this.lblAkan.AutoSize = true;
            this.lblAkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAkan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAkan.Location = new System.Drawing.Point(138, 53);
            this.lblAkan.Name = "lblAkan";
            this.lblAkan.Size = new System.Drawing.Size(36, 25);
            this.lblAkan.TabIndex = 22;
            this.lblAkan.Text = "40";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(58, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ական:";
            // 
            // dgKochakner
            // 
            this.dgKochakner.AllowUserToAddRows = false;
            this.dgKochakner.AllowUserToDeleteRows = false;
            this.dgKochakner.AllowUserToResizeColumns = false;
            this.dgKochakner.AllowUserToResizeRows = false;
            this.dgKochakner.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgKochakner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKochakner.ColumnHeadersVisible = false;
            this.dgKochakner.Location = new System.Drawing.Point(12, 99);
            this.dgKochakner.MultiSelect = false;
            this.dgKochakner.Name = "dgKochakner";
            this.dgKochakner.ReadOnly = true;
            this.dgKochakner.RowHeadersVisible = false;
            this.dgKochakner.RowHeadersWidth = 51;
            this.dgKochakner.RowTemplate.Height = 24;
            this.dgKochakner.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgKochakner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgKochakner.Size = new System.Drawing.Size(644, 476);
            this.dgKochakner.TabIndex = 20;
            this.dgKochakner.TabStop = false;
            this.dgKochakner.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgKochakner_CellMouseClick);
            // 
            // Vayrkyanachap
            // 
            this.Vayrkyanachap.Interval = 1000;
            this.Vayrkyanachap.Tick += new System.EventHandler(this.Vayrkyanachap_Tick);
            // 
            // frmGame
            // 
            this.AcceptButton = this.btnVersksel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 594);
            this.Controls.Add(this.btnVersksel);
            this.Controls.Add(this.lblVayrkyanner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAkan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgKochakner);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ական";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGame_FormClosing);
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKochakner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem խաղToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miDursGal;
        private System.Windows.Forms.ToolStripMenuItem miMasin;
        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVersksel;
        private System.Windows.Forms.Label lblVayrkyanner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAkan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgKochakner;
        private System.Windows.Forms.ToolStripMenuItem miPakel;
        private System.Windows.Forms.Timer Vayrkyanachap;
    }
}

