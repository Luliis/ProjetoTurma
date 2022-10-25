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
    public partial class frm_UC : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public UC obj_UC_Atual = new UC();

        public frm_UC()
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
            tbox_Nm_UC.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            BDUC obj_BDUC = new BDUC();
            obj_UC_Atual = PopulaObjeto();

            if (obj_UC_Atual.Cod_UC != -1)
            {
                obj_BDUC.Alterar(obj_UC_Atual);
                MessageBox.Show("O usuário " + obj_UC_Atual.Nm_UC + " foi alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_UC_Atual.Cod_UC = obj_BDUC.Incluir(obj_UC_Atual);
                PopulaTela(obj_UC_Atual);
                MessageBox.Show("O usuário " + obj_UC_Atual.Nm_UC + " foi inserido com sucesso.", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            tbox_Nm_UC.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Instância da Classe BD. 
            BDUC obj_BDUC = new BDUC();

            DialogResult vResp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vResp == DialogResult.Yes)
            {
                if (obj_BDUC.Excluir(obj_UC_Atual))
                {
                    MessageBox.Show("A escola " + obj_UC_Atual.Nm_UC + " foi excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private UC PopulaObjeto()
        {
            UC obj_UC = new UC();

            if (tbox_Cod_UC.Text != "")
            {
                obj_UC.Cod_UC = Convert.ToInt16(tbox_Cod_UC.Text);
            }
            obj_UC.Nm_UC = tbox_Nm_UC.Text;
            obj_UC.Des_UC = tbox_Des_UC.Text;
            obj_UC.CH_UC = Convert.ToInt16(tbox_CH_UC.Text);

            return obj_UC;
        }

        /***********************************************************************
        *        Método: PopulaTela
        *          Obs.: Responsável por popular o formulário com o conteúdo 
        *                do objeto atual.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void PopulaTela(UC pobj_UC)
        {
            if (pobj_UC.Cod_UC != -1)
            {
                tbox_Cod_UC.Text = pobj_UC.Cod_UC.ToString();
            }
            tbox_Nm_UC.Text = pobj_UC.Nm_UC.ToString();
            tbox_Des_UC.Text = pobj_UC.Des_UC.ToString();
            tbox_CH_UC.Text = pobj_UC.CH_UC.ToString();
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
            BDUC obj_BDUC = new BDUC();

            List<UC> Lista = new List<UC>();

            ltbox_UCs.Items.Clear();

            Lista = obj_BDUC.FindAllUC();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    ltbox_UCs.Items.Add(Lista[i].Cod_UC.ToString() + "-" + Lista[i].Nm_UC.ToString());
                }
            }
        }

        private void ltbox_UCs_Click(object sender, EventArgs e)
        {
            if (ltbox_UCs.SelectedIndex != -1)
            {
                BDUC obj_BDUC = new BDUC();

                string s_linha = ltbox_UCs.Items[ltbox_UCs.SelectedIndex].ToString();
                int i_Pos = 0;


                for (int t = 0; t < s_linha.Length; t++)
                {
                    if (s_linha.Substring(t, 1) == "-")
                    {
                        i_Pos = t;
                        break;
                    }
                }

                obj_UC_Atual.Cod_UC = Convert.ToInt16(s_linha.Substring(0, i_Pos));
                obj_UC_Atual = obj_BDUC.FindByCodUC(obj_UC_Atual);
                PopulaTela(obj_UC_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
                obj_FuncGeral.HabilitaTela(this, false);

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);
            if (obj_UC_Atual.Cod_UC != -1)
            {
                PopulaTela(obj_UC_Atual);
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
