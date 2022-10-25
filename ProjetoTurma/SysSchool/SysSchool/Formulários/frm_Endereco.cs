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
    public partial class frm_Endereco : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Endereco obj_Endereco_Atual = new Endereco();
        public int i_Cod_Pessoa = -1;

        public frm_Endereco()
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
            tbox_Cod_Pessoa.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            BDEndereco obj_BDEndereco = new BDEndereco();
            obj_Endereco_Atual = PopulaObjeto();

            if (obj_Endereco_Atual.Cod_Endereco != -1)
            {
                obj_BDEndereco.Alterar(obj_Endereco_Atual);
                MessageBox.Show("O Endereço " + obj_Endereco_Atual.End_Endereco + " foi alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_Endereco_Atual.Cod_Endereco = obj_BDEndereco.Incluir(obj_Endereco_Atual);
                PopulaTela(obj_Endereco_Atual);
                MessageBox.Show("O Endereço " + obj_Endereco_Atual.End_Endereco + " foi inserido com sucesso.", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
            this.Close();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            tbox_Cod_Pessoa.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Instância da Classe BD. 
            BDEndereco obj_BDEndereco = new BDEndereco();

            DialogResult vResp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vResp == DialogResult.Yes)
            {
                if (obj_BDEndereco.Excluir(obj_Endereco_Atual))
                {
                    MessageBox.Show("O Endereço " + obj_Endereco_Atual.End_Endereco + " foi excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private Endereco PopulaObjeto()
        {
            Endereco obj_Endereco = new Endereco();

            if (tbox_Cod_Endereco.Text != "")
            {
                obj_Endereco.Cod_Endereco = Convert.ToInt16(tbox_Cod_Endereco.Text);
            }
            obj_Endereco.Cod_Pessoa = Convert.ToInt16(tbox_Cod_Pessoa.Text);
            obj_Endereco.End_Endereco = tbox_End_Endereco.Text;
            obj_Endereco.Bai_Endereco = tbox_Bai_Endereco.Text;
            obj_Endereco.Cid_Endereco = tbox_Cid_Endereco.Text;
            obj_Endereco.UF_Endereco = tbox_UF_Endereco.Text;
            obj_Endereco.CEP_Endereco = tbox_CEP_Endereco.Text;

            return obj_Endereco;
        }

        /***********************************************************************
        *        Método: PopulaTela
        *          Obs.: Responsável por popular o formulário com o conteúdo 
        *                do objeto atual.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void PopulaTela(Endereco pobj_Endereco)
        {
            if (pobj_Endereco.Cod_Endereco != -1)
            {
                tbox_Cod_Endereco.Text = pobj_Endereco.Cod_Endereco.ToString();
            }
            tbox_Cod_Pessoa.Text = pobj_Endereco.Cod_Pessoa.ToString();

            EventArgs e = new EventArgs();

            tbox_Cod_Pessoa_Leave(tbox_Cod_Pessoa, e);

            tbox_End_Endereco.Text = pobj_Endereco.End_Endereco.ToString();
            tbox_Bai_Endereco.Text = pobj_Endereco.Bai_Endereco.ToString();
            tbox_Cid_Endereco.Text = pobj_Endereco.Cid_Endereco.ToString();
            tbox_UF_Endereco.Text  = pobj_Endereco.UF_Endereco.ToString();
            tbox_CEP_Endereco.Text = pobj_Endereco.CEP_Endereco.ToString();

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
            BDEndereco obj_BDEndereco = new BDEndereco();

            List<Endereco> Lista = new List<Endereco>();

            ltbox_Enderecos.Items.Clear();

            Lista = obj_BDEndereco.FindAllEndereco();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    ltbox_Enderecos.Items.Add(Lista[i].Cod_Endereco.ToString() + "-" + Lista[i].End_Endereco.ToString());
                }
            }
        }

        private void ltbox_Enderecos_Click(object sender, EventArgs e)
        {
            if (ltbox_Enderecos.SelectedIndex != -1)
            {
                BDEndereco obj_BDEndereco = new BDEndereco();

                string s_linha = ltbox_Enderecos.Items[ltbox_Enderecos.SelectedIndex].ToString();
                int i_Pos = 0;


                for (int t = 0; t < s_linha.Length; t++)
                {
                    if (s_linha.Substring(t, 1) == "-")
                    {
                        i_Pos = t;
                        break;
                    }
                }

                obj_Endereco_Atual.Cod_Endereco = Convert.ToInt16(s_linha.Substring(0, i_Pos));
                obj_Endereco_Atual = obj_BDEndereco.FindByCodEndereco(obj_Endereco_Atual);
                PopulaTela(obj_Endereco_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
                obj_FuncGeral.HabilitaTela(this, false);

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);
            if (obj_Endereco_Atual.Cod_Endereco != -1)
            {
                PopulaTela(obj_Endereco_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
            }
            else
            {
                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.StatusBtn(this, 1);
            }
        }

        private void tbox_Cod_Pessoa_Leave(object sender, EventArgs e)
        {
            if (tbox_Cod_Pessoa.Text != "")
            {
                BDPessoa obj_BDPessoa = new BDPessoa();
                Pessoa obj_Pessoa = new Pessoa();
                obj_Pessoa.Cod_Pessoa = Convert.ToInt16(((TextBox)sender).Text);
                obj_Pessoa = obj_BDPessoa.FindByCodPessoa(obj_Pessoa);
                if (obj_Pessoa != null)
                {
                    lb_Nm_Pessoa.Text = obj_Pessoa.Nm_Pessoa;
                }
                else
                {
                    lb_Nm_Pessoa.Text = "";
                }

            }
        }

        private void btn_Pessoa_Click(object sender, EventArgs e)
        {
            frm_Escola obj_frm_Escola = new frm_Escola();
            obj_frm_Escola.ShowDialog();
            tbox_Cod_Pessoa.Text = obj_frm_Escola.obj_Escola_Atual.Cod_Escola.ToString();

            tbox_Cod_Pessoa_Leave(tbox_Cod_Pessoa, e);
        }

        private void frm_Endereco_Shown(object sender, EventArgs e)
        {
            btn_Novo_Click(btn_Novo, e);
            obj_Endereco_Atual.Cod_Pessoa = i_Cod_Pessoa;
            PopulaTela(obj_Endereco_Atual);
        }
    }
}
