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
    public partial class frm_Curso : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        Curso obj_Curso_Atual = new Curso();

        public frm_Curso()
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
            tbox_Nm_Curso.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            BDCurso obj_BDCurso = new BDCurso();
            obj_Curso_Atual = PopulaObjeto();

            if (obj_Curso_Atual.Cod_Curso != -1)
            {
                obj_BDCurso.Alterar(obj_Curso_Atual);
                MessageBox.Show("O curso " + obj_Curso_Atual.Nm_Curso + " foi alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_Curso_Atual.Cod_Curso = obj_BDCurso.Incluir(obj_Curso_Atual);
                PopulaTela(obj_Curso_Atual);
                MessageBox.Show("O curso " + obj_Curso_Atual.Nm_Curso + " foi inserido com sucesso.", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            tbox_Nm_Curso.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Instância da Classe BD. 
            BDCurso obj_BDCurso = new BDCurso();

            DialogResult vResp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vResp == DialogResult.Yes)
            {
                if (obj_BDCurso.Excluir(obj_Curso_Atual))
                {
                    MessageBox.Show("O curso " + obj_Curso_Atual.Nm_Curso + " foi excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private Curso PopulaObjeto()
        {
            Curso obj_Curso = new Curso();

            if (tbox_Cod_Curso.Text != "")
            {
                obj_Curso.Cod_Curso = Convert.ToInt16(tbox_Cod_Curso.Text);
            }
            obj_Curso.Nm_Curso = tbox_Nm_Curso.Text;
            obj_Curso.CH_Curso = Convert.ToInt16(tbox_CH_Curso.Text);

            return obj_Curso;
        }

        /***********************************************************************
        *        Método: PopulaTela
        *          Obs.: Responsável por popular o formulário com o conteúdo 
        *                do objeto atual.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void PopulaTela(Curso pobj_Curso)
        {
            if (pobj_Curso.Cod_Curso != -1)
            {
                tbox_Cod_Curso.Text = pobj_Curso.Cod_Curso.ToString();
            }
            tbox_Nm_Curso.Text = pobj_Curso.Nm_Curso.ToString();
            tbox_CH_Curso.Text = pobj_Curso.CH_Curso.ToString();
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
            BDCurso obj_BDCurso = new BDCurso();

            List<Curso> Lista = new List<Curso>();

            ltbox_Cursos.Items.Clear();

            Lista = obj_BDCurso.FindAllCurso();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    ltbox_Cursos.Items.Add(Lista[i].Cod_Curso.ToString() + "-" + Lista[i].Nm_Curso.ToString());
                }
            }
        }

        private void ltbox_Cursos_Click(object sender, EventArgs e)
        {
            if (ltbox_Cursos.SelectedIndex != -1)
            {
                BDCurso obj_BDCurso = new BDCurso();

                string s_linha = ltbox_Cursos.Items[ltbox_Cursos.SelectedIndex].ToString();
                int i_Pos = 0;


                for (int t = 0; t < s_linha.Length; t++)
                {
                    if (s_linha.Substring(t, 1) == "-")
                    {
                        i_Pos = t;
                        break;
                    }
                }

                obj_Curso_Atual.Cod_Curso = Convert.ToInt16(s_linha.Substring(0, i_Pos));
                obj_Curso_Atual = obj_BDCurso.FindByCodCurso(obj_Curso_Atual);
                PopulaTela(obj_Curso_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
                obj_FuncGeral.HabilitaTela(this, false);

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);
            if (obj_Curso_Atual.Cod_Curso != -1)
            {
                PopulaTela(obj_Curso_Atual);
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
