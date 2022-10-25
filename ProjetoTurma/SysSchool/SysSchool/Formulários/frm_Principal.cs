using System;
using System.Windows.Forms;

namespace SysSchool
{
    public partial class frm_Principal : Form
    {
        public Usuario obj_Usuario_Atual = new Usuario();

        public frm_Principal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            frm_Usuario obj_frm_Usuario = new frm_Usuario();
            obj_frm_Usuario.ShowDialog();
        }

        private void tm_Principal_Tick(object sender, System.EventArgs e)
        {
            tsslb_Data.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            tsslb_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void escolaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Escola obj_frm_Escola = new frm_Escola();
            obj_frm_Escola.ShowDialog();
        }

        private void uCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_UC obj_frm_UC = new frm_UC();
            obj_frm_UC.ShowDialog();
        }

        private void professorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Professor obj_frm_Professor = new frm_Professor();
            obj_frm_Professor.ShowDialog();
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Aluno obj_frm_Aluno = new frm_Aluno();
            obj_frm_Aluno.ShowDialog();
        }

        private void salaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Sala obj_frm_Sala = new frm_Sala();
            obj_frm_Sala.ShowDialog();
        }

        private void cursoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Curso obj_frm_Curso = new frm_Curso();
            obj_frm_Curso.ShowDialog();
        }

        private void frm_Principal_Shown(object sender, EventArgs e)
        {
            tsslb_Usuario.Text = obj_Usuario_Atual.UNm_Usuario;
            
            //mFacine ToDo: Carregar o nome do usuário Logado.
        }

        private void frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
