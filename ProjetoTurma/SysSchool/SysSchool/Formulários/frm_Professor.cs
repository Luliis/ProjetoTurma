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
    public partial class frm_Professor : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Professor obj_Professor_Atual = new Professor();
        Pessoa obj_Pessoa_Atual = new Pessoa();
        Endereco obj_Endereco_Atual = new Endereco();
        UC obj_UC_Atual = new UC();
        Competencia obj_Competencia_Atual = new Competencia();

        public frm_Professor()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
            TitulosLView();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.LimpaTela(this);
            tbox_Nm_Pessoa.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
            //Esconde o endereço pois não possui Cod Pessoa

        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            string s_Message = "";
            BDProfessor obj_BDProfessor = new BDProfessor();
            BDPessoa obj_BDPessoa = new BDPessoa();
            BDCompetencia obj_BDCompetencia = new BDCompetencia();

            obj_Professor_Atual = PopulaObjProfessor(obj_Professor_Atual);

            obj_Pessoa_Atual = PopulaObjPessoa(obj_Professor_Atual);

            if (obj_Professor_Atual.Cod_Professor != -1)
            {            
                obj_BDProfessor.Alterar(obj_Professor_Atual);
                obj_BDPessoa.Alterar(obj_Pessoa_Atual);
                s_Message = "O Professor " + obj_Pessoa_Atual.Nm_Pessoa + " foi alterado com sucesso.";
            }
            else
            {
                obj_Pessoa_Atual.Cod_Pessoa = obj_BDPessoa.Incluir(obj_Pessoa_Atual);
                obj_Professor_Atual.Cod_Pessoa = obj_Pessoa_Atual.Cod_Pessoa;
                obj_Professor_Atual.Cod_Professor = obj_BDProfessor.Incluir(obj_Professor_Atual);
                PopulaTela(obj_Professor_Atual, obj_Pessoa_Atual);
                s_Message = "O Professor " + obj_Pessoa_Atual.Nm_Pessoa + " foi inserido com sucesso.";
            }

            if (!(tbox_Cod_Endereco.Text != ""))
            {
                btn_Endereco_Click(btn_Endereco, e);
            }


            obj_Competencia_Atual.Cod_Professor = obj_Professor_Atual.Cod_Professor;

            obj_BDCompetencia.ExcluirAllByProfessor(obj_Competencia_Atual);



            for (int i = 0; i < ltview_Competencia.Items.Count; i++)
            {
                obj_Competencia_Atual = new Competencia();

                obj_Competencia_Atual.Cod_Professor = obj_Professor_Atual.Cod_Professor;
                obj_Competencia_Atual.Cod_UC = Convert.ToInt16(ltview_Competencia.Items[i].SubItems[0].Text);
                obj_BDCompetencia.Incluir(obj_Competencia_Atual);
            }

            MessageBox.Show(s_Message, "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
            //Retorna o endereço ao formulário pois possui Cod Pessoa
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            tbox_Nm_Pessoa.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Instância da Classe BD. 
            BDProfessor obj_BDProfessor = new BDProfessor();
            BDPessoa obj_BDPessoa = new BDPessoa();

            DialogResult vResp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vResp == DialogResult.Yes)
            {
                if (obj_BDProfessor.Excluir(obj_Professor_Atual))
                {
                    obj_BDPessoa.Excluir(obj_Pessoa_Atual);
                    obj_FuncGeral.LimpaTela(this);
                    obj_FuncGeral.HabilitaTela(this, false);
                    obj_FuncGeral.StatusBtn(this, 1);
                    PopulaLista();
                    MessageBox.Show("O Professor " + obj_Pessoa_Atual.Nm_Pessoa + " foi excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


        }

        /***********************************************************************
        *        Método: PopulaObjProfessor
        *          Obs.: Responsável por popular o objeto atual com o conteúdo 
        *                do formulário.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private Professor PopulaObjProfessor(Professor pobj_Professor)
        {
            if (tbox_Cod_Professor.Text != "")
            {
                pobj_Professor.Cod_Professor = Convert.ToInt16(tbox_Cod_Professor.Text);
            }
            pobj_Professor.Dis_Professor = ckbox_Dis_Professor.Checked;
            return pobj_Professor;
        }

        /***********************************************************************
        *        Método: PopulaObjPessoa
        *          Obs.: Responsável por popular o objeto Pessoa atual com o conteúdo 
        *                do formulário.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private Pessoa PopulaObjPessoa(Professor pobj_professor)
        {
            Pessoa obj_Pessoa = new Pessoa();
            if (pobj_professor.Cod_Pessoa != -1)
            {
                obj_Pessoa.Cod_Pessoa = pobj_professor.Cod_Pessoa;
            }
            obj_Pessoa.Nm_Pessoa = tbox_Nm_Pessoa.Text;
            obj_Pessoa.CPF_Pessoa = tbox_CPF_Pessoa.Text;
            obj_Pessoa.Mail_Pessoa = tbox_Mail_Pessoa.Text;
            obj_Pessoa.Cel_Pessoa = tbox_Cel_Pessoa.Text;

            return obj_Pessoa;
        }

        /***********************************************************************
        *        Método: PopulaTela
        *          Obs.: Responsável por popular o formulário com o conteúdo 
        *                do objeto atual.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void PopulaTela(Professor pobj_Professor, Pessoa pobj_Pessoa)
        {
            if (pobj_Professor.Cod_Professor != -1)
            {
                tbox_Cod_Professor.Text = pobj_Professor.Cod_Professor.ToString();
            }

            if (pobj_Professor.Dis_Professor)
            {
                ckbox_Dis_Professor.Text = "Não Disponível";
            }
            else
            {
                ckbox_Dis_Professor.Text = "Disponível";
            }
            ckbox_Dis_Professor.Checked = pobj_Professor.Dis_Professor;

            tbox_Nm_Pessoa.Text = pobj_Pessoa.Nm_Pessoa;
            tbox_CPF_Pessoa.Text = pobj_Pessoa.CPF_Pessoa;
            tbox_Mail_Pessoa.Text = pobj_Pessoa.Mail_Pessoa;
            tbox_Cel_Pessoa.Text = pobj_Pessoa.Cel_Pessoa;

            BDEndereco obj_BDEndereco = new BDEndereco();
            obj_Endereco_Atual.Cod_Pessoa = pobj_Pessoa.Cod_Pessoa;

            List<Endereco> Lista = new List<Endereco>();

            EventArgs e = new EventArgs();
            
            Lista = obj_BDEndereco.FindAllEnderecoByCodPessoa(obj_Endereco_Atual);
            if (Lista != null)
            {
                tbox_Cod_Endereco.Text = Lista[0].Cod_Endereco.ToString();
                tbox_Cod_Endereco_Leave(tbox_Cod_Endereco, e);
            }



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
            BDProfessor obj_BDProfessor = new BDProfessor();
            BDPessoa obj_BDPessoa = new BDPessoa();

            List<Professor> Lista = new List<Professor>();

            ltbox_Professores.Items.Clear();

            Lista = obj_BDProfessor.FindAllProfessor();

            Pessoa obj_Pessoa = new Pessoa();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    obj_Pessoa.Cod_Pessoa = Lista[i].Cod_Pessoa;
                    obj_Pessoa = obj_BDPessoa.FindByCodPessoa(obj_Pessoa);
                    ltbox_Professores.Items.Add(Lista[i].Cod_Professor.ToString() + "-" + obj_Pessoa.Nm_Pessoa.ToString());
                }
            }
        }

        /***********************************************************************
        *        Método: PopulaLinhaLView
        *          Obs.: Responsável por popular a linha com o conteúdo do 
        *                objeto Item da Competência
        *   Dt. Criação: 29/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void PopulaLinhaLView(ListView pltview, string pCod_UC, string pNm_UC, string pDes_UC, string pCH_UC)
        {
            ListViewItem item = new ListViewItem(new[] { pCod_UC, pNm_UC, pDes_UC, pCH_UC });
            pltview.Items.Add(item);
        }

        private void ltbox_Professores_Click(object sender, EventArgs e)
        {
            BDProfessor obj_BDProfessor = new BDProfessor();
            BDPessoa obj_BDPessoa = new BDPessoa();

            if (ltbox_Professores.SelectedIndex != -1)
            {
                string s_linha = ltbox_Professores.Items[ltbox_Professores.SelectedIndex].ToString();
                int i_Pos = 0;

                for (int t = 0; t < s_linha.Length; t++)
                {
                    if (s_linha.Substring(t, 1) == "-")
                    {
                        i_Pos = t;
                        break;
                    }
                }
                obj_Professor_Atual.Cod_Professor = Convert.ToInt16(s_linha.Substring(0, i_Pos));
                obj_Professor_Atual = obj_BDProfessor.FindByCodProfessor(obj_Professor_Atual);
                obj_Pessoa_Atual.Cod_Pessoa = obj_Professor_Atual.Cod_Pessoa;
                obj_Pessoa_Atual = obj_BDPessoa.FindByCodPessoa(obj_Pessoa_Atual);

                PopulaTela(obj_Professor_Atual, obj_Pessoa_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
                obj_FuncGeral.HabilitaTela(this, false);

                PopulaLtView();
                
            }
        }

        /***********************************************************************
        *        Método: PopulaLtView
        *          Obs.: Responsável por Popular a List View de Competências
        *   Dt. Criação: 29/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void PopulaLtView()
        {
            ltview_Competencia.Items.Clear();

            BDCompetencia obj_BDCompetencia = new BDCompetencia();
            List<Competencia> Lista = new List<Competencia>();
            obj_Competencia_Atual.Cod_Professor = obj_Professor_Atual.Cod_Professor;

            Lista = obj_BDCompetencia.FindAllCompetenciaByProfessor(obj_Competencia_Atual);

            if (Lista != null)
            {
                BDUC obj_BDUC = new BDUC();

                for (int i = 0; i < Lista.Count; i++)
                {
                    obj_UC_Atual.Cod_UC = Lista[i].Cod_UC;
                    obj_UC_Atual = obj_BDUC.FindByCodUC(obj_UC_Atual);

                    PopulaLinhaLView(ltview_Competencia, obj_UC_Atual.Cod_UC.ToString(), obj_UC_Atual.Nm_UC, obj_UC_Atual.Des_UC, obj_UC_Atual.CH_UC.ToString());
                }
            }

            



        }


        /***********************************************************************
        *        Método: TitulosLView
        *          Obs.: Responsável por Titular a List View
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void TitulosLView()
        {
            ltview_Competencia.View = View.Details;
            ltview_Competencia.Columns.Add("Código", 50);
            ltview_Competencia.Columns.Add("Nome", 65);
            ltview_Competencia.Columns.Add("Descrição", 203);
            ltview_Competencia.Columns.Add("C.H.", 75);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);
            if (obj_Professor_Atual.Cod_Professor != -1)
            {
                PopulaTela(obj_Professor_Atual, obj_Pessoa_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
            }
            else
            {
                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.StatusBtn(this, 1);
            }
        }

        private void ckbox_Dis_Professor_Click(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                ((CheckBox)sender).Text = "Não Disponível";
            }
            else
            {
                ((CheckBox)sender).Text = "Disponível";
            }
        }

        private void btn_Endereco_Click(object sender, EventArgs e)
        {
            frm_Endereco obj_frm_Endereco = new frm_Endereco();

            obj_frm_Endereco.i_Cod_Pessoa = obj_Pessoa_Atual.Cod_Pessoa;

            obj_frm_Endereco.ShowDialog();

            tbox_Cod_Endereco.Text = obj_frm_Endereco.obj_Endereco_Atual.Cod_Endereco.ToString();

            tbox_Cod_Endereco_Leave(tbox_Cod_Endereco, e);

             
        }

        private void tbox_Cod_Endereco_Leave(object sender, EventArgs e)
        {
            obj_Endereco_Atual = new Endereco();

            if (tbox_Cod_Endereco.Text != "")
            {
                BDEndereco obj_BDEndereco = new BDEndereco();
                
                obj_Endereco_Atual.Cod_Endereco = Convert.ToInt16(((TextBox)sender).Text);
                obj_Endereco_Atual = obj_BDEndereco.FindByCodEndereco(obj_Endereco_Atual);
                if (obj_Endereco_Atual != null)
                {
                    lb_End_Endereco.Text = obj_Endereco_Atual.End_Endereco;
                    lb_Bai_Endereco.Text = obj_Endereco_Atual.Bai_Endereco;
                    lb_Cid_Endereco.Text = obj_Endereco_Atual.Cid_Endereco;
                    lb_UF_Endereco.Text = obj_Endereco_Atual.UF_Endereco;
                    lb_CEP_Endereco.Text = obj_Endereco_Atual.CEP_Endereco;

                }
                else
                {
                    lb_End_Endereco.Text = "";
                    lb_Bai_Endereco.Text = "";
                    lb_Cid_Endereco.Text = "";
                    lb_UF_Endereco.Text  = ""; 
                    lb_CEP_Endereco.Text = "";
                }

            }
        }

        private void btn_Pabaxo_Click(object sender, EventArgs e)
        {
            PopulaLinhaLView(ltview_Competencia, tbox_Cod_UC.Text, lb_Nm_UC.Text, lb_Des_UC.Text, lb_CH_UC.Text);
            tbox_Cod_UC.Text = "";
            lb_Nm_UC.Text = "";
            lb_Des_UC.Text = "";
            lb_CH_UC.Text = "";

            tbox_Cod_UC.Focus();
        }

        private void btn_Pacima_Click(object sender, EventArgs e)
        {
            if (ltview_Competencia.SelectedItems != null)
            {
                DialogResult vResp = MessageBox.Show("Deseja retirar a " + lb_Nm_UC.Text + " da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vResp == DialogResult.Yes)
                {
                    for (int i = 0; i < ltview_Competencia.Items.Count; i++)
                    {
                        if (ltview_Competencia.Items[i].Selected)
                        {
                            tbox_Cod_UC.Text = ltview_Competencia.Items[i].SubItems[0].Text;
                            lb_Nm_UC.Text = ltview_Competencia.Items[i].SubItems[1].Text;
                            lb_Des_UC.Text = ltview_Competencia.Items[i].SubItems[2].Text;
                            lb_CH_UC.Text = ltview_Competencia.Items[i].SubItems[3].Text;
                            ltview_Competencia.Items[i].Remove();
                            break;
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Erro ao retirar a UC da Lista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_UC_Click(object sender, EventArgs e)
        {
            frm_UC obj_frm_UC = new frm_UC();
            obj_frm_UC.ShowDialog();
            tbox_Cod_UC.Text = obj_frm_UC.obj_UC_Atual.Cod_UC.ToString();
            tbox_Cod_UC_Leave(tbox_Cod_UC, e);
        }

        private void tbox_Cod_UC_Leave(object sender, EventArgs e)
        {
            obj_UC_Atual = new UC();

            if (tbox_Cod_UC.Text != "")
            {
                BDUC obj_BDUC = new BDUC();
                obj_UC_Atual.Cod_UC = Convert.ToInt16(((TextBox)sender).Text);
                obj_UC_Atual = obj_BDUC.FindByCodUC(obj_UC_Atual);
                if (obj_UC_Atual != null)
                {
                    lb_Nm_UC.Text = obj_UC_Atual.Nm_UC;
                    lb_Des_UC.Text = obj_UC_Atual.Des_UC;
                    lb_CH_UC.Text = obj_UC_Atual.CH_UC.ToString();
                }
                else
                {
                    lb_Nm_UC.Text = "";
                    lb_Des_UC.Text = "";
                    lb_CH_UC.Text = "";
                }
            }
        }
    }
}