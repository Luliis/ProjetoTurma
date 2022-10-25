
namespace SysSchool
{
    partial class frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.mnstrip_Principal = new System.Windows.Forms.MenuStrip();
            this.escolaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.salaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sttstrip_Principal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslb_Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslb_Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tm_Principal = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslb_Usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnstrip_Principal.SuspendLayout();
            this.sttstrip_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnstrip_Principal
            // 
            this.mnstrip_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnstrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escolaToolStripMenuItem2,
            this.professorToolStripMenuItem1,
            this.cursoToolStripMenuItem1,
            this.usuárioToolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.mnstrip_Principal.Location = new System.Drawing.Point(0, 0);
            this.mnstrip_Principal.Name = "mnstrip_Principal";
            this.mnstrip_Principal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnstrip_Principal.Size = new System.Drawing.Size(1444, 24);
            this.mnstrip_Principal.TabIndex = 0;
            this.mnstrip_Principal.Text = "menuStrip1";
            // 
            // escolaToolStripMenuItem2
            // 
            this.escolaToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salaToolStripMenuItem1});
            this.escolaToolStripMenuItem2.Name = "escolaToolStripMenuItem2";
            this.escolaToolStripMenuItem2.Size = new System.Drawing.Size(52, 20);
            this.escolaToolStripMenuItem2.Text = "Escola";
            this.escolaToolStripMenuItem2.Click += new System.EventHandler(this.escolaToolStripMenuItem2_Click);
            // 
            // salaToolStripMenuItem1
            // 
            this.salaToolStripMenuItem1.Name = "salaToolStripMenuItem1";
            this.salaToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.salaToolStripMenuItem1.Text = "Sala";
            this.salaToolStripMenuItem1.Click += new System.EventHandler(this.salaToolStripMenuItem1_Click);
            // 
            // professorToolStripMenuItem1
            // 
            this.professorToolStripMenuItem1.Name = "professorToolStripMenuItem1";
            this.professorToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.professorToolStripMenuItem1.Text = "Professor";
            this.professorToolStripMenuItem1.Click += new System.EventHandler(this.professorToolStripMenuItem1_Click);
            // 
            // cursoToolStripMenuItem1
            // 
            this.cursoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turmaToolStripMenuItem1,
            this.uCToolStripMenuItem1});
            this.cursoToolStripMenuItem1.Name = "cursoToolStripMenuItem1";
            this.cursoToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.cursoToolStripMenuItem1.Text = "Curso";
            this.cursoToolStripMenuItem1.Click += new System.EventHandler(this.cursoToolStripMenuItem1_Click);
            // 
            // turmaToolStripMenuItem1
            // 
            this.turmaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem1});
            this.turmaToolStripMenuItem1.Name = "turmaToolStripMenuItem1";
            this.turmaToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.turmaToolStripMenuItem1.Text = "Turma";
            // 
            // alunoToolStripMenuItem1
            // 
            this.alunoToolStripMenuItem1.Name = "alunoToolStripMenuItem1";
            this.alunoToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.alunoToolStripMenuItem1.Text = "Aluno";
            this.alunoToolStripMenuItem1.Click += new System.EventHandler(this.alunoToolStripMenuItem1_Click);
            // 
            // uCToolStripMenuItem1
            // 
            this.uCToolStripMenuItem1.Name = "uCToolStripMenuItem1";
            this.uCToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.uCToolStripMenuItem1.Text = "UC";
            this.uCToolStripMenuItem1.Click += new System.EventHandler(this.uCToolStripMenuItem1_Click);
            // 
            // usuárioToolStripMenuItem1
            // 
            this.usuárioToolStripMenuItem1.Name = "usuárioToolStripMenuItem1";
            this.usuárioToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem1.Text = "Usuário";
            this.usuárioToolStripMenuItem1.Click += new System.EventHandler(this.usuárioToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sttstrip_Principal
            // 
            this.sttstrip_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sttstrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslb_Data,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel3,
            this.tsslb_Hora,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel9,
            this.tsslb_Usuario});
            this.sttstrip_Principal.Location = new System.Drawing.Point(0, 543);
            this.sttstrip_Principal.Name = "sttstrip_Principal";
            this.sttstrip_Principal.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.sttstrip_Principal.Size = new System.Drawing.Size(1444, 26);
            this.sttstrip_Principal.TabIndex = 1;
            this.sttstrip_Principal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(37, 21);
            this.toolStripStatusLabel1.Text = "Data: ";
            // 
            // tsslb_Data
            // 
            this.tsslb_Data.AutoSize = false;
            this.tsslb_Data.Name = "tsslb_Data";
            this.tsslb_Data.Size = new System.Drawing.Size(95, 21);
            this.tsslb_Data.Text = "99/99/9999";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(151, 21);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(39, 21);
            this.toolStripStatusLabel3.Text = "Hora: ";
            // 
            // tsslb_Hora
            // 
            this.tsslb_Hora.AutoSize = false;
            this.tsslb_Hora.Name = "tsslb_Hora";
            this.tsslb_Hora.Size = new System.Drawing.Size(95, 21);
            this.tsslb_Hora.Text = "99:99:99";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.AutoSize = false;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(151, 21);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(100, 21);
            this.toolStripStatusLabel5.Text = "SysSchool Vrs. 1.0";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(124, 21);
            this.toolStripStatusLabel7.Text = "by mFacine (Monstro)";
            // 
            // tm_Principal
            // 
            this.tm_Principal.Enabled = true;
            this.tm_Principal.Tick += new System.EventHandler(this.tm_Principal_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1444, 519);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 21);
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.AutoSize = false;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(118, 21);
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(84, 21);
            this.toolStripStatusLabel9.Text = "Usuário Atual: ";
            // 
            // tsslb_Usuario
            // 
            this.tsslb_Usuario.AutoSize = false;
            this.tsslb_Usuario.Name = "tsslb_Usuario";
            this.tsslb_Usuario.Size = new System.Drawing.Size(124, 21);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 569);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sttstrip_Principal);
            this.Controls.Add(this.mnstrip_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mnstrip_Principal;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Principal_FormClosing);
            this.Shown += new System.EventHandler(this.frm_Principal_Shown);
            this.mnstrip_Principal.ResumeLayout(false);
            this.mnstrip_Principal.PerformLayout();
            this.sttstrip_Principal.ResumeLayout(false);
            this.sttstrip_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnstrip_Principal;
        private System.Windows.Forms.ToolStripMenuItem escolaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip sttstrip_Principal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslb_Data;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsslb_Hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.Timer tm_Principal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel tsslb_Usuario;
    }
}

