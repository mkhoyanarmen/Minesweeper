namespace Ական
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnDursGal = new System.Windows.Forms.Button();
            this.lblMutq = new System.Windows.Forms.Label();
            this.txtParol = new System.Windows.Forms.TextBox();
            this.btnMutq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 88;
            this.label1.Text = "Մուտքանուն";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 99;
            this.label2.Text = "Գաղտնաբառ";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(203, 53);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(161, 28);
            this.txtLogin.TabIndex = 1;
            // 
            // btnDursGal
            // 
            this.btnDursGal.Location = new System.Drawing.Point(239, 190);
            this.btnDursGal.Name = "btnDursGal";
            this.btnDursGal.Size = new System.Drawing.Size(125, 33);
            this.btnDursGal.TabIndex = 4;
            this.btnDursGal.Text = "Դուրս գալ";
            this.btnDursGal.UseVisualStyleBackColor = true;
            this.btnDursGal.Click += new System.EventHandler(this.btnDursGal_Click);
            // 
            // lblMutq
            // 
            this.lblMutq.AutoSize = true;
            this.lblMutq.ForeColor = System.Drawing.Color.Red;
            this.lblMutq.Location = new System.Drawing.Point(105, 153);
            this.lblMutq.Name = "lblMutq";
            this.lblMutq.Size = new System.Drawing.Size(0, 16);
            this.lblMutq.TabIndex = 7;
            // 
            // txtParol
            // 
            this.txtParol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtParol.Location = new System.Drawing.Point(203, 107);
            this.txtParol.Name = "txtParol";
            this.txtParol.Size = new System.Drawing.Size(161, 27);
            this.txtParol.TabIndex = 2;
            this.txtParol.UseSystemPasswordChar = true;
            // 
            // btnMutq
            // 
            this.btnMutq.Location = new System.Drawing.Point(74, 195);
            this.btnMutq.Name = "btnMutq";
            this.btnMutq.Size = new System.Drawing.Size(75, 23);
            this.btnMutq.TabIndex = 100;
            this.btnMutq.Text = "btnMutq";
            this.btnMutq.UseVisualStyleBackColor = true;
            this.btnMutq.Click += new System.EventHandler(this.btnMutq_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(475, 288);
            this.ControlBox = false;
            this.Controls.Add(this.btnMutq);
            this.Controls.Add(this.txtParol);
            this.Controls.Add(this.lblMutq);
            this.Controls.Add(this.btnDursGal);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Մուտք";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnDursGal;
        private System.Windows.Forms.Label lblMutq;
        private System.Windows.Forms.TextBox txtParol;
        private System.Windows.Forms.Button btnMutq;
    }
}