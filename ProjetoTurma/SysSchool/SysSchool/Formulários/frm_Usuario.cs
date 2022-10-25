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
    public partial class frm_Usuario : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        Usuario obj_Usuario_Atual = new Usuario();

        public frm_Usuario()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.LimpaTela(this);
            tbox_UNm_Usuario.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            BDUsuario obj_BDUsuario = new BDUsuario();
            obj_Usuario_Atual = PopulaObjeto();

            if (obj_Usuario_Atual.Cod_Usuario != -1)
            {
                obj_BDUsuario.Alterar(obj_Usuario_Atual);
                MessageBox.Show("O usuário " + obj_Usuario_Atual.UNm_Usuario + " foi alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_Usuario_Atual.Cod_Usuario = obj_BDUsuario.Incluir(obj_Usuario_Atual);
                PopulaTela(obj_Usuario_Atual);
                MessageBox.Show("O usuário " + obj_Usuario_Atual.UNm_Usuario + " foi inserido com sucesso.", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            tbox_UNm_Usuario.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Instância da Classe BD. 
            BDUsuario obj_BDUsuario = new BDUsuario();

            DialogResult vResp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vResp == DialogResult.Yes)
            {
                if (obj_BDUsuario.Excluir(obj_Usuario_Atual))
                {
                    MessageBox.Show("O usuário " + obj_Usuario_Atual.UNm_Usuario + " foi excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obj_FuncGeral.LimpaTela(this);
                    obj_FuncGeral.HabilitaTela(this, false);
                    obj_FuncGeral.StatusBtn(this, 1);
                    PopulaLista();
                }
            }
            

        }

        /***********************************************************************
        *        Método: PopulaObjeto
        *          Obs.: Responsável por popular o objeto atual com o conteúdo 
        *                do formulário.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private Usuario PopulaObjeto()
        {
            Usuario obj_Usuario = new Usuario();

            if (tbox_Cod_Usuario.Text != "")
            {
                obj_Usuario.Cod_Usuario = Convert.ToInt16(tbox_Cod_Usuario.Text);
            }
            obj_Usuario.UNm_Usuario = tbox_UNm_Usuario.Text;
            obj_Usuario.Pass_Usuario = obj_FuncGeral.Criptografa(tbox_Pass_Usuario.Text);

            return obj_Usuario;
        }

        /***********************************************************************
        *        Método: PopulaTela
        *          Obs.: Responsável por popular o formulário com o conteúdo 
        *                do objeto atual.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void PopulaTela(Usuario pobj_Usuario)
        {
            if (pobj_Usuario.Cod_Usuario != -1)
            {
                tbox_Cod_Usuario.Text = pobj_Usuario.Cod_Usuario.ToString();
            }
            tbox_UNm_Usuario.Text = pobj_Usuario.UNm_Usuario.ToString();
            tbox_Pass_Usuario.Text = obj_FuncGeral.DesCriptografa(pobj_Usuario.Pass_Usuario.ToString());
        }


        /***********************************************************************
        *        Método: PopulaLista
        *          Obs.: Responsável por popular os usuários da tabela na lista 
        *                do formulário.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void PopulaLista()
        {
            BDUsuario obj_BDUsuario = new BDUsuario();

            List<Usuario> Lista = new List<Usuario>();

            ltbox_Usuarios.Items.Clear();

            Lista = obj_BDUsuario.FindAllUsuario();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++ )
                {
                    ltbox_Usuarios.Items.Add(Lista[i].Cod_Usuario.ToString() + "-" + Lista[i].UNm_Usuario.ToString());
                }
            }
        }

        private void ltbox_Usuarios_Click(object sender, EventArgs e)
        {
            if(ltbox_Usuarios.SelectedIndex != -1)
            {
                BDUsuario obj_BDUsuario = new BDUsuario();

                string s_linha = ltbox_Usuarios.Items[ltbox_Usuarios.SelectedIndex].ToString();
                int i_Pos = 0;


                for (int t = 0; t < s_linha.Length; t++)
                {
                    if(s_linha.Substring(t,1) == "-")
                    {
                        i_Pos = t;
                        break;
                    }
                }

                obj_Usuario_Atual.Cod_Usuario = Convert.ToInt16(s_linha.Substring(0, i_Pos));
                obj_Usuario_Atual = obj_BDUsuario.FindByCodUsuario(obj_Usuario_Atual);
                PopulaTela(obj_Usuario_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
                obj_FuncGeral.HabilitaTela(this, false);

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);
            if (obj_Usuario_Atual.Cod_Usuario != -1)
            {
                PopulaTela(obj_Usuario_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
            }
            else
            {
                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.StatusBtn(this, 1);
            }
        }
    }
}
