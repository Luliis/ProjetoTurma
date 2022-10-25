using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysSchool
{
    public partial class frm_Login : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.VerificaNulos(this);
                        
            BDUsuario obj_BDUsuario = new BDUsuario();
            Usuario obj_Usuario = new Usuario();

            obj_Usuario.UNm_Usuario = tbox_UNm_Usuario.Text;

            obj_Usuario = obj_BDUsuario.FindByUNmUsuario(obj_Usuario);

            if (obj_Usuario == null)
            {
                MessageBox.Show("Nome do Usuário não encontrado.", "ENTRADA INVÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbox_UNm_Usuario.Focus();
            }
            else
            {
                if (obj_FuncGeral.Criptografa(tbox_Pass_Usuario.Text) == obj_Usuario.Pass_Usuario)
                {
                    frm_Principal obj_frm_Principal = new frm_Principal();
                    obj_frm_Principal.obj_Usuario_Atual = obj_Usuario;
                    obj_frm_Principal.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Senha não encontrado.", "ENTRADA INVÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbox_Pass_Usuario.Focus();
                }
            }

        }
    }
}
