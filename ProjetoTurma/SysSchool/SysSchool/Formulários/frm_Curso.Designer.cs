
namespace SysSchool
{
    partial class frm_Curso
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
            this.tbox_CH_Curso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox_Nm_Curso = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.tbox_Cod_Curso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_List = new System.Windows.Forms.Panel();
            this.ltbox_Cursos = new System.Windows.Forms.ListBox();
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
            this.pnl_Detail.SuspendLayout();
            this.pnl_List.SuspendLayout();
            this.pnl_Button.SuspendLayout();
            this.pnl_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Detail
            // 
            this.pnl_Detail.BackColor = System.Drawing.Color.LightCyan;
            this.pnl_Detail.Controls.Add(this.tbox_CH_Curso);
            this.pnl_Detail.Controls.Add(this.label9);
            this.pnl_Detail.Controls.Add(this.tbox_Nm_Curso);
            this.pnl_Detail.Controls.Add(this.Label10);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Curso);
            this.pnl_Detail.Controls.Add(this.label7);
            this.pnl_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detail.Location = new System.Drawing.Point(150, 81);
            this.pnl_Detail.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Size = new System.Drawing.Size(317, 116);
            this.pnl_Detail.TabIndex = 16;
            // 
            // tbox_CH_Curso
            // 
            this.tbox_CH_Curso.Location = new System.Drawing.Point(190, 76);
            this.tbox_CH_Curso.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_CH_Curso.Name = "tbox_CH_Curso";
            this.tbox_CH_Curso.Size = new System.Drawing.Size(90, 20);
            this.tbox_CH_Curso.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Carga Horária";
            // 
            // tbox_Nm_Curso
            // 
            this.tbox_Nm_Curso.Location = new System.Drawing.Point(22, 76);
            this.tbox_Nm_Curso.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Nm_Curso.Name = "tbox_Nm_Curso";
            this.tbox_Nm_Curso.Size = new System.Drawing.Size(164, 20);
            this.tbox_Nm_Curso.TabIndex = 3;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(20, 59);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(65, 13);
            this.Label10.TabIndex = 2;
            this.Label10.Text = "Nome Curso";
            // 
            // tbox_Cod_Curso
            // 
            this.tbox_Cod_Curso.Enabled = false;
            this.tbox_Cod_Curso.Location = new System.Drawing.Point(22, 32);
            this.tbox_Cod_Curso.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_Curso.Name = "tbox_Cod_Curso";
            this.tbox_Cod_Curso.Size = new System.Drawing.Size(76, 20);
            this.tbox_Cod_Curso.TabIndex = 1;
            this.tbox_Cod_Curso.Tag = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código";
            // 
            // pnl_List
            // 
            this.pnl_List.BackColor = System.Drawing.Color.Azure;
            this.pnl_List.Controls.Add(this.ltbox_Cursos);
            this.pnl_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_List.Location = new System.Drawing.Point(0, 81);
            this.pnl_List.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(150, 116);
            this.pnl_List.TabIndex = 15;
            // 
            // ltbox_Cursos
            // 
            this.ltbox_Cursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbox_Cursos.FormattingEnabled = true;
            this.ltbox_Cursos.Location = new System.Drawing.Point(0, 0);
            this.ltbox_Cursos.Margin = new System.Windows.Forms.Padding(2);
            this.ltbox_Cursos.Name = "ltbox_Cursos";
            this.ltbox_Cursos.Size = new System.Drawing.Size(150, 116);
            this.ltbox_Cursos.TabIndex = 0;
            this.ltbox_Cursos.Click += new System.EventHandler(this.ltbox_Cursos_Click);
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
            this.pnl_Button.Location = new System.Drawing.Point(0, 197);
            this.pnl_Button.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(467, 50);
            this.pnl_Button.TabIndex = 14;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(359, 18);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(56, 21);
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
            this.btn_Confirmar.Location = new System.Drawing.Point(298, 18);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(56, 21);
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
            this.btn_Excluir.Location = new System.Drawing.Point(135, 18);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(56, 21);
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
            this.btn_Alterar.Location = new System.Drawing.Point(74, 18);
            this.btn_Alterar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(56, 21);
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
            this.btn_Novo.Location = new System.Drawing.Point(14, 18);
            this.btn_Novo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(56, 21);
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
            this.pnl_Title.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(467, 81);
            this.pnl_Title.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(260, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(282, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(347, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(302, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(212, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Curso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(286, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Curso";
            // 
            // frm_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 247);
            this.Controls.Add(this.pnl_Detail);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.pnl_Button);
            this.Controls.Add(this.pnl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Curso";
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
        private System.Windows.Forms.TextBox tbox_CH_Curso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbox_Nm_Curso;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TextBox tbox_Cod_Curso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.ListBox ltbox_Cursos;
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
    }
}