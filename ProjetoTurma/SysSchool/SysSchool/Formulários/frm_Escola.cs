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
    public partial class frm_Escola : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Escola obj_Escola_Atual = new Escola();

        public frm_Escola()
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
            tbox_Nm_Escola.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            BDEscola obj_BDEscola = new BDEscola();
            obj_Escola_Atual = PopulaObjeto();

            if (obj_Escola_Atual.Cod_Escola != -1)
            {
                obj_BDEscola.Alterar(obj_Escola_Atual);
                MessageBox.Show("O usuário " + obj_Escola_Atual.Nm_Escola + " foi alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_Escola_Atual.Cod_Escola = obj_BDEscola.Incluir(obj_Escola_Atual);
                PopulaTela(obj_Escola_Atual);
                MessageBox.Show("O usuário " + obj_Escola_Atual.Nm_Escola + " foi inserido com sucesso.", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            tbox_Nm_Escola.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Instância da Classe BD. 
            BDEscola obj_BDEscola = new BDEscola();

            DialogResult vResp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vResp == DialogResult.Yes)
            {
                if (obj_BDEscola.Excluir(obj_Escola_Atual))
                {
                    MessageBox.Show("A escola " + obj_Escola_Atual.Nm_Escola + " foi excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private Escola PopulaObjeto()
        {
            Escola obj_Escola = new Escola();

            if (tbox_Cod_Escola.Text != "")
            {
                obj_Escola.Cod_Escola = Convert.ToInt16(tbox_Cod_Escola.Text);
            }
            obj_Escola.Nm_Escola = tbox_Nm_Escola.Text;
            obj_Escola.CNPJ_Escola = tbox_CNPJ_Escola.Text;

            return obj_Escola;
        }

        /***********************************************************************
        *        Método: PopulaTela
        *          Obs.: Responsável por popular o formulário com o conteúdo 
        *                do objeto atual.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void PopulaTela(Escola pobj_Escola)
        {
            if (pobj_Escola.Cod_Escola != -1)
            {
                tbox_Cod_Escola.Text = pobj_Escola.Cod_Escola.ToString();
            }
            tbox_Nm_Escola.Text = pobj_Escola.Nm_Escola.ToString();
            tbox_CNPJ_Escola.Text = pobj_Escola.CNPJ_Escola.ToString();
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
            BDEscola obj_BDEscola = new BDEscola();

            List<Escola> Lista = new List<Escola>();

            ltbox_Escolas.Items.Clear();

            Lista = obj_BDEscola.FindAllEscola();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    ltbox_Escolas.Items.Add(Lista[i].Cod_Escola.ToString() + "-" + Lista[i].Nm_Escola.ToString());
                }
            }
        }

        private void ltbox_Escolas_Click(object sender, EventArgs e)
        {
            if (ltbox_Escolas.SelectedIndex != -1)
            {
                BDEscola obj_BDEscola = new BDEscola();

                string s_linha = ltbox_Escolas.Items[ltbox_Escolas.SelectedIndex].ToString();
                int i_Pos = 0;


                for (int t = 0; t < s_linha.Length; t++)
                {
                    if (s_linha.Substring(t, 1) == "-")
                    {
                        i_Pos = t;
                        break;
                    }
                }

                obj_Escola_Atual.Cod_Escola = Convert.ToInt16(s_linha.Substring(0, i_Pos));
                obj_Escola_Atual = obj_BDEscola.FindByCodEscola(obj_Escola_Atual);
                PopulaTela(obj_Escola_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
                obj_FuncGeral.HabilitaTela(this, false);

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);
            if (obj_Escola_Atual.Cod_Escola != -1)
            {
                PopulaTela(obj_Escola_Atual);
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
