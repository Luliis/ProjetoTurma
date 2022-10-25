
namespace SysSchool
{
    partial class frm_UC
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
            this.pnl_Detail = new System.Windows.Forms.Panel();
            this.tbox_CH_UC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox_Nm_UC = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.tbox_Cod_UC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_List = new System.Windows.Forms.Panel();
            this.ltbox_UCs = new System.Windows.Forms.ListBox();
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_Des_UC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl_Detail.SuspendLayout();
            this.pnl_List.SuspendLayout();
            this.pnl_Button.SuspendLayout();
            this.pnl_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Detail
            // 
            this.pnl_Detail.BackColor = System.Drawing.Color.LightCyan;
            this.pnl_Detail.Controls.Add(this.tbox_Des_UC);
            this.pnl_Detail.Controls.Add(this.label8);
            this.pnl_Detail.Controls.Add(this.tbox_CH_UC);
            this.pnl_Detail.Controls.Add(this.label9);
            this.pnl_Detail.Controls.Add(this.tbox_Nm_UC);
            this.pnl_Detail.Controls.Add(this.Label10);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_UC);
            this.pnl_Detail.Controls.Add(this.label7);
            this.pnl_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detail.Location = new System.Drawing.Point(200, 100);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Size = new System.Drawing.Size(390, 272);
            this.pnl_Detail.TabIndex = 12;
            // 
            // tbox_CH_UC
            // 
            this.tbox_CH_UC.Location = new System.Drawing.Point(253, 94);
            this.tbox_CH_UC.Name = "tbox_CH_UC";
            this.tbox_CH_UC.Size = new System.Drawing.Size(100, 22);
            this.tbox_CH_UC.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Carga Horária";
            // 
            // tbox_Nm_UC
            // 
            this.tbox_Nm_UC.Location = new System.Drawing.Point(30, 94);
            this.tbox_Nm_UC.Name = "tbox_Nm_UC";
            this.tbox_Nm_UC.Size = new System.Drawing.Size(217, 22);
            this.tbox_Nm_UC.TabIndex = 3;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(27, 73);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(68, 17);
            this.Label10.TabIndex = 2;
            this.Label10.Text = "Nome UC";
            // 
            // tbox_Cod_UC
            // 
            this.tbox_Cod_UC.Enabled = false;
            this.tbox_Cod_UC.Location = new System.Drawing.Point(30, 39);
            this.tbox_Cod_UC.Name = "tbox_Cod_UC";
            this.tbox_Cod_UC.Size = new System.Drawing.Size(100, 22);
            this.tbox_Cod_UC.TabIndex = 1;
            this.tbox_Cod_UC.Tag = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código";
            // 
            // pnl_List
            // 
            this.pnl_List.BackColor = System.Drawing.Color.Azure;
            this.pnl_List.Controls.Add(this.ltbox_UCs);
            this.pnl_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_List.Location = new System.Drawing.Point(0, 100);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(200, 272);
            this.pnl_List.TabIndex = 11;
            // 
            // ltbox_UCs
            // 
            this.ltbox_UCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbox_UCs.FormattingEnabled = true;
            this.ltbox_UCs.ItemHeight = 16;
            this.ltbox_UCs.Location = new System.Drawing.Point(0, 0);
            this.ltbox_UCs.Name = "ltbox_UCs";
            this.ltbox_UCs.Size = new System.Drawing.Size(200, 272);
            this.ltbox_UCs.TabIndex = 0;
            this.ltbox_UCs.Click += new System.EventHandler(this.ltbox_UCs_Click);
            // 
            // pnl_Button
            // 
            this.pnl_Button.BackColor = System.Drawing.Color.PowderBlue;
            this.pnl_Button.Controls.Add(this.btn_Cancelar);
            this.pnl_Button.Controls.Add(this.btn_Confirmar);
            this.pnl_Button.Controls.Add(this.btn_Excluir);
            this.pnl_Button.Controls.Add(this.btn_Alterar);
            this.pnl_Button.Controls.Add(this.btn_Novo);
            this.pnl_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Button.Location = new System.Drawing.Point(0, 372);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(590, 62);
            this.pnl_Button.TabIndex = 10;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(479, 22);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 26);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.FlatAppearance.BorderSize = 0;
            this.btn_Confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Location = new System.Drawing.Point(397, 22);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 26);
            this.btn_Confirmar.TabIndex = 3;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Location = new System.Drawing.Point(180, 22);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 26);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.FlatAppearance.BorderSize = 0;
            this.btn_Alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Location = new System.Drawing.Point(99, 22);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(75, 26);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.FlatAppearance.BorderSize = 0;
            this.btn_Novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.Location = new System.Drawing.Point(18, 22);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 26);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnl_Title.Controls.Add(this.label6);
            this.pnl_Title.Controls.Add(this.label4);
            this.pnl_Title.Controls.Add(this.label3);
            this.pnl_Title.Controls.Add(this.label1);
            this.pnl_Title.Controls.Add(this.label2);
            this.pnl_Title.Controls.Add(this.label5);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(590, 100);
            this.pnl_Title.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(319, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "UC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(368, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "UC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(484, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "UC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(402, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "UC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(257, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "UC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(382, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "UC";
            // 
            // tbox_Des_UC
            // 
            this.tbox_Des_UC.Location = new System.Drawing.Point(30, 141);
            this.tbox_Des_UC.Multiline = true;
            this.tbox_Des_UC.Name = "tbox_Des_UC";
            this.tbox_Des_UC.Size = new System.Drawing.Size(324, 107);
            this.tbox_Des_UC.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Descrição da UC";
            // 
            // frm_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 434);
            this.Controls.Add(this.pnl_Detail);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.pnl_Button);
            this.Controls.Add(this.pnl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_UC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnl_Detail.ResumeLayout(false);
            this.pnl_Detail.PerformLayout();
            this.pnl_List.ResumeLayout(false);
            this.pnl_Button.ResumeLayout(false);
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Detail;
        private System.Windows.Forms.TextBox tbox_CH_UC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbox_Nm_UC;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TextBox tbox_Cod_UC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.ListBox ltbox_UCs;
        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_Des_UC;
        private System.Windows.Forms.Label label8;
    }
}