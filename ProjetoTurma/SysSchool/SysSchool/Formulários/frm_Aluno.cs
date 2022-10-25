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
    public partial class frm_Aluno : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Aluno obj_Aluno_Atual = new Aluno();
        Pessoa obj_Pessoa_Atual = new Pessoa();

        public frm_Aluno()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_Aluno_Atual = new Aluno();
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.LimpaTela(this);
            tbox_Nm_Pessoa.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            BDAluno obj_BDAluno = new BDAluno();
            BDPessoa obj_BDPessoa = new BDPessoa();

            //obj_Aluno_Atual = obj_BDAluno.FindByCodAluno(obj_Aluno_Atual);
            obj_Aluno_Atual = PopulaObjAluno(obj_Aluno_Atual);

            obj_Pessoa_Atual = PopulaObjPessoa(obj_Aluno_Atual);

            if (obj_Aluno_Atual.Cod_Aluno != -1)
            {
                obj_BDAluno.Alterar(obj_Aluno_Atual);
                obj_BDPessoa.Alterar(obj_Pessoa_Atual);
                MessageBox.Show("O Aluno " + obj_Pessoa_Atual.Nm_Pessoa + " foi alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_Pessoa_Atual.Cod_Pessoa = obj_BDPessoa.Incluir(obj_Pessoa_Atual);
                obj_Aluno_Atual.Cod_Pessoa = obj_Pessoa_Atual.Cod_Pessoa;
                obj_Aluno_Atual.Cod_Aluno = obj_BDAluno.Incluir(obj_Aluno_Atual);

                PopulaTela(obj_Aluno_Atual, obj_Pessoa_Atual);
                MessageBox.Show("O Aluno " + obj_Pessoa_Atual.Nm_Pessoa + " foi inserido com sucesso.", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
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
            BDAluno obj_BDAluno = new BDAluno();
            BDPessoa obj_BDPessoa = new BDPessoa();

            DialogResult vResp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vResp == DialogResult.Yes)
            {
                if (obj_BDAluno.Excluir(obj_Aluno_Atual))
                {
                    obj_BDPessoa.Excluir(obj_Pessoa_Atual);
                    obj_FuncGeral.LimpaTela(this);
                    obj_FuncGeral.HabilitaTela(this, false);
                    obj_FuncGeral.StatusBtn(this, 1);
                    PopulaLista();
                    MessageBox.Show("O Aluno " + obj_Pessoa_Atual.Nm_Pessoa + " foi excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        private Aluno PopulaObjAluno(Aluno pobj_Aluno)
        {
            if (tbox_Cod_Aluno.Text != "")
            {
                pobj_Aluno.Cod_Aluno = Convert.ToInt16(tbox_Cod_Aluno.Text);
            }
            pobj_Aluno.Mat_Aluno = tbox_Mat_Aluno.Text;
            return pobj_Aluno;
        }

        /***********************************************************************
        *        Método: PopulaObjPessoa
        *          Obs.: Responsável por popular o objeto Pessoa atual com o conteúdo 
        *                do formulário.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private Pessoa PopulaObjPessoa(Aluno pobj_professor)
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
        private void PopulaTela(Aluno pobj_Aluno, Pessoa pobj_Pessoa)
        {
            if (pobj_Aluno.Cod_Aluno != -1)
            {
                tbox_Cod_Aluno.Text = pobj_Aluno.Cod_Aluno.ToString();
            }

            tbox_Mat_Aluno.Text = pobj_Aluno.Mat_Aluno;

            tbox_Nm_Pessoa.Text = pobj_Pessoa.Nm_Pessoa;
            tbox_CPF_Pessoa.Text = pobj_Pessoa.CPF_Pessoa;
            tbox_Mail_Pessoa.Text = pobj_Pessoa.Mail_Pessoa;
            tbox_Cel_Pessoa.Text = pobj_Pessoa.Cel_Pessoa;
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
            BDAluno obj_BDAluno = new BDAluno();
            BDPessoa obj_BDPessoa = new BDPessoa();

            List<Aluno> Lista = new List<Aluno>();

            ltbox_Alunos.Items.Clear();

            Lista = obj_BDAluno.FindAllAluno();

            Pessoa obj_Pessoa = new Pessoa();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    obj_Pessoa.Cod_Pessoa = Lista[i].Cod_Pessoa;
                    obj_Pessoa = obj_BDPessoa.FindByCodPessoa(obj_Pessoa);
                    ltbox_Alunos.Items.Add(Lista[i].Cod_Aluno.ToString() + "-" + obj_Pessoa.Nm_Pessoa.ToString());
                }
            }
        }

        private void ltbox_Alunos_Click(object sender, EventArgs e)
        {
            BDAluno obj_BDAluno = new BDAluno();
            BDPessoa obj_BDPessoa = new BDPessoa();

            if (ltbox_Alunos.SelectedIndex != -1)
            {
                string s_linha = ltbox_Alunos.Items[ltbox_Alunos.SelectedIndex].ToString();
                int i_Pos = 0;

                for (int t = 0; t < s_linha.Length; t++)
                {
                    if (s_linha.Substring(t, 1) == "-")
                    {
                        i_Pos = t;
                        break;
                    }
                }
                obj_Aluno_Atual.Cod_Aluno = Convert.ToInt16(s_linha.Substring(0, i_Pos));
                obj_Aluno_Atual = obj_BDAluno.FindByCodAluno(obj_Aluno_Atual);
                obj_Pessoa_Atual.Cod_Pessoa = obj_Aluno_Atual.Cod_Pessoa;
                obj_Pessoa_Atual = obj_BDPessoa.FindByCodPessoa(obj_Pessoa_Atual);

                PopulaTela(obj_Aluno_Atual, obj_Pessoa_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
                obj_FuncGeral.HabilitaTela(this, false);

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);
            if (obj_Aluno_Atual.Cod_Aluno != -1)
            {
                PopulaTela(obj_Aluno_Atual, obj_Pessoa_Atual);
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