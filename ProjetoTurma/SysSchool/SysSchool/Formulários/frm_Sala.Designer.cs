
namespace SysSchool
{
    partial class frm_Sala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sala));
            this.pnl_Detail = new System.Windows.Forms.Panel();
            this.ckbox_Dis_Sala = new System.Windows.Forms.CheckBox();
            this.lb_Nm_Escola = new System.Windows.Forms.Label();
            this.btn_Escola = new System.Windows.Forms.Button();
            this.tbox_Cod_Escola = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbox_Nro_Sala = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.tbox_Cod_Sala = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_List = new System.Windows.Forms.Panel();
            this.ltbox_Salas = new System.Windows.Forms.ListBox();
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
            this.pnl_Detail.Controls.Add(this.ckbox_Dis_Sala);
            this.pnl_Detail.Controls.Add(this.lb_Nm_Escola);
            this.pnl_Detail.Controls.Add(this.btn_Escola);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Escola);
            this.pnl_Detail.Controls.Add(this.label8);
            this.pnl_Detail.Controls.Add(this.tbox_Nro_Sala);
            this.pnl_Detail.Controls.Add(this.Label10);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Sala);
            this.pnl_Detail.Controls.Add(this.label7);
            this.pnl_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detail.Location = new System.Drawing.Point(150, 81);
            this.pnl_Detail.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Size = new System.Drawing.Size(369, 173);
            this.pnl_Detail.TabIndex = 16;
            // 
            // ckbox_Dis_Sala
            // 
            this.ckbox_Dis_Sala.AutoSize = true;
            this.ckbox_Dis_Sala.Location = new System.Drawing.Point(130, 126);
            this.ckbox_Dis_Sala.Margin = new System.Windows.Forms.Padding(2);
            this.ckbox_Dis_Sala.Name = "ckbox_Dis_Sala";
            this.ckbox_Dis_Sala.Size = new System.Drawing.Size(77, 17);
            this.ckbox_Dis_Sala.TabIndex = 15;
            this.ckbox_Dis_Sala.Text = "Disponível";
            this.ckbox_Dis_Sala.UseVisualStyleBackColor = true;
            // 
            // lb_Nm_Escola
            // 
            this.lb_Nm_Escola.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lb_Nm_Escola.Location = new System.Drawing.Point(123, 81);
            this.lb_Nm_Escola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Nm_Escola.Name = "lb_Nm_Escola";
            this.lb_Nm_Escola.Size = new System.Drawing.Size(177, 13);
            this.lb_Nm_Escola.TabIndex = 9;
            this.lb_Nm_Escola.Tag = "1";
            this.lb_Nm_Escola.Text = "CNPJ";
            // 
            // btn_Escola
            // 
            this.btn_Escola.Image = ((System.Drawing.Image)(resources.GetObject("btn_Escola.Image")));
            this.btn_Escola.Location = new System.Drawing.Point(101, 77);
            this.btn_Escola.Name = "btn_Escola";
            this.btn_Escola.Size = new System.Drawing.Size(21, 21);
            this.btn_Escola.TabIndex = 8;
            this.btn_Escola.UseVisualStyleBackColor = true;
            this.btn_Escola.Click += new System.EventHandler(this.btn_Escola_Click);
            // 
            // tbox_Cod_Escola
            // 
            this.tbox_Cod_Escola.Location = new System.Drawing.Point(22, 77);
            this.tbox_Cod_Escola.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_Escola.Name = "tbox_Cod_Escola";
            this.tbox_Cod_Escola.Size = new System.Drawing.Size(76, 20);
            this.tbox_Cod_Escola.TabIndex = 7;
            this.tbox_Cod_Escola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_Cod_Escola.Click += new System.EventHandler(this.tbox_Cod_Escola_Leave);
            this.tbox_Cod_Escola.Leave += new System.EventHandler(this.tbox_Cod_Escola_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Escola";
            // 
            // tbox_Nro_Sala
            // 
            this.tbox_Nro_Sala.Location = new System.Drawing.Point(22, 123);
            this.tbox_Nro_Sala.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Nro_Sala.Name = "tbox_Nro_Sala";
            this.tbox_Nro_Sala.Size = new System.Drawing.Size(76, 20);
            this.tbox_Nro_Sala.TabIndex = 3;
            this.tbox_Nro_Sala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(20, 106);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(68, 13);
            this.Label10.TabIndex = 2;
            this.Label10.Text = "Número Sala";
            // 
            // tbox_Cod_Sala
            // 
            this.tbox_Cod_Sala.Enabled = false;
            this.tbox_Cod_Sala.Location = new System.Drawing.Point(22, 32);
            this.tbox_Cod_Sala.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_Sala.Name = "tbox_Cod_Sala";
            this.tbox_Cod_Sala.Size = new System.Drawing.Size(76, 20);
            this.tbox_Cod_Sala.TabIndex = 1;
            this.tbox_Cod_Sala.Tag = "1";
            this.tbox_Cod_Sala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.pnl_List.Controls.Add(this.ltbox_Salas);
            this.pnl_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_List.Location = new System.Drawing.Point(0, 81);
            this.pnl_List.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(150, 173);
            this.pnl_List.TabIndex = 15;
            // 
            // ltbox_Salas
            // 
            this.ltbox_Salas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbox_Salas.FormattingEnabled = true;
            this.ltbox_Salas.Location = new System.Drawing.Point(0, 0);
            this.ltbox_Salas.Margin = new System.Windows.Forms.Padding(2);
            this.ltbox_Salas.Name = "ltbox_Salas";
            this.ltbox_Salas.Size = new System.Drawing.Size(150, 173);
            this.ltbox_Salas.TabIndex = 0;
            this.ltbox_Salas.Click += new System.EventHandler(this.ltbox_Salas_Click);
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
            this.pnl_Button.Location = new System.Drawing.Point(0, 254);
            this.pnl_Button.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(519, 50);
            this.pnl_Button.TabIndex = 14;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(435, 18);
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
            this.btn_Confirmar.Location = new System.Drawing.Point(374, 18);
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
            this.pnl_Title.Size = new System.Drawing.Size(519, 81);
            this.pnl_Title.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(368, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(390, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(455, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sala";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(410, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(320, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sala";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(394, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sala";
            // 
            // frm_Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 304);
            this.Controls.Add(this.pnl_Detail);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.pnl_Button);
            this.Controls.Add(this.pnl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Sala";
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
        private System.Windows.Forms.TextBox tbox_Nro_Sala;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TextBox tbox_Cod_Sala;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.ListBox ltbox_Salas;
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
        private System.Windows.Forms.Label lb_Nm_Escola;
        private System.Windows.Forms.Button btn_Escola;
        private System.Windows.Forms.TextBox tbox_Cod_Escola;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckbox_Dis_Sala;
    }
}