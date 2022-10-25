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
    public partial class frm_Sala : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        Sala obj_Sala_Atual = new Sala();

        public frm_Sala()
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
            tbox_Cod_Escola.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            BDSala obj_BDSala = new BDSala();
            obj_Sala_Atual = PopulaObjeto();

            if (obj_Sala_Atual.Cod_Sala != -1)
            {
                obj_BDSala.Alterar(obj_Sala_Atual);
                MessageBox.Show("A Sala " + obj_Sala_Atual.Nro_Sala + " foi alterada com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                obj_Sala_Atual.Cod_Sala = obj_BDSala.Incluir(obj_Sala_Atual);
                PopulaTela(obj_Sala_Atual);
                MessageBox.Show("A Sala " + obj_Sala_Atual.Nro_Sala + " foi inserida com sucesso.", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            tbox_Cod_Sala.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Instância da Classe BD. 
            BDSala obj_BDSala = new BDSala();

            DialogResult vResp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vResp == DialogResult.Yes)
            {
                if (obj_BDSala.Excluir(obj_Sala_Atual))
                {
                    MessageBox.Show("A Sala " + obj_Sala_Atual.Nro_Sala + " foi excluída com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private Sala PopulaObjeto()
        {
            Sala obj_Sala = new Sala();

            if (tbox_Cod_Sala.Text != "")
            {
                obj_Sala.Cod_Sala = Convert.ToInt16(tbox_Cod_Sala.Text);
            }
            obj_Sala.Cod_Escola = Convert.ToInt16(tbox_Cod_Escola.Text);

            obj_Sala.Nro_Sala = tbox_Nro_Sala.Text;

            return obj_Sala;
        }

        /***********************************************************************
        *        Método: PopulaTela
        *          Obs.: Responsável por popular o formulário com o conteúdo 
        *                do objeto atual.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void PopulaTela(Sala pobj_Sala)
        {
            if (pobj_Sala.Cod_Sala != -1)
            {
                tbox_Cod_Sala.Text = pobj_Sala.Cod_Sala.ToString();
            }
            tbox_Cod_Escola.Text = pobj_Sala.Cod_Escola.ToString();

            EventArgs e = new EventArgs();

            tbox_Cod_Escola_Leave(tbox_Cod_Escola, e);

            tbox_Nro_Sala.Text = pobj_Sala.Nro_Sala.ToString();
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
            BDSala obj_BDSala = new BDSala();

            List<Sala> Lista = new List<Sala>();

            ltbox_Salas.Items.Clear();

            Lista = obj_BDSala.FindAllSala();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    ltbox_Salas.Items.Add(Lista[i].Cod_Sala.ToString() + "-" + Lista[i].Nro_Sala.ToString());
                }
            }
        }

        private void ltbox_Salas_Click(object sender, EventArgs e)
        {
            if (ltbox_Salas.SelectedIndex != -1)
            {
                BDSala obj_BDSala = new BDSala();

                string s_linha = ltbox_Salas.Items[ltbox_Salas.SelectedIndex].ToString();
                int i_Pos = 0;


                for (int t = 0; t < s_linha.Length; t++)
                {
                    if (s_linha.Substring(t, 1) == "-")
                    {
                        i_Pos = t;
                        break;
                    }
                }

                obj_Sala_Atual.Cod_Sala = Convert.ToInt16(s_linha.Substring(0, i_Pos));
                obj_Sala_Atual = obj_BDSala.FindByCodSala(obj_Sala_Atual);
                PopulaTela(obj_Sala_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
                obj_FuncGeral.HabilitaTela(this, false);

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);
            if (obj_Sala_Atual.Cod_Sala != -1)
            {
                PopulaTela(obj_Sala_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
            }
            else
            {
                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.StatusBtn(this, 1);
            }
        }

        private void tbox_Cod_Escola_Leave(object sender, EventArgs e)
        {
            if (tbox_Cod_Escola.Text != "")
            {
                BDEscola obj_BDEscola = new BDEscola();
                Escola obj_Escola = new Escola();
                obj_Escola.Cod_Escola = Convert.ToInt16(((TextBox)sender).Text);
                obj_Escola = obj_BDEscola.FindByCodEscola(obj_Escola);
                if (obj_Escola != null)
                {
                    lb_Nm_Escola.Text = obj_Escola.Nm_Escola;
                }
                else
                {
                    lb_Nm_Escola.Text = "";
                }
                
            }
        }

        private void btn_Escola_Click(object sender, EventArgs e)
        {
            frm_Escola obj_frm_Escola = new frm_Escola();
            obj_frm_Escola.ShowDialog();
            tbox_Cod_Escola.Text = obj_frm_Escola.obj_Escola_Atual.Cod_Escola.ToString();

            tbox_Cod_Escola_Leave(tbox_Cod_Escola, e);
        }
    }
}
