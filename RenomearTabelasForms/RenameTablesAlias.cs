using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenomearTabelasForms
{
    public partial class RenameTablesAlias : Form
    {
        string sqlCommand = "select * from mensalidades_previa t1 inner join empresa t2 on t1.cd_associado_empresa = t2.cd_empresa and t1.tp_associado_empresa = 2 inner join associados t3 on t3.cd_empresa = t2.cd_empresa inner join dependentes t4 on t3.cd_associado = t4.cd_associado";
        public RenameTablesAlias()
        {
            InitializeComponent();
            Lbl_Alias.Text = "Alias das tabelas";
            Lbl_Numbers.Text = "Numeros Tabelas: ";
            Lbl_Start.Text = "Inicial";
            Lbl_End.Text = "Final";
            Lbl_Command.Text = "Comando SQL";
            Lbl_Result.Text = "Resultado";

            Txt_Alias.Text = "";
            Txt_Command.Text = "";
            Txt_Result.Text = "";

            Btn_Replace.Text = "Subistituir";
            Btn_Example.Text = "Exemplo";
        }

        private void Btn_Replace_Click(object sender, EventArgs e)
        {
            string messageError = "Falha a Subistituir";
            if (Txt_Alias.Text == "")
            {
                MessageBox.Show("Por favor, preencha o Alias.", messageError, MessageBoxButtons.OK);
                return;
            }
            else if(Mtx_Start.Text == "") 
            {
                MessageBox.Show("Por favor, preencha o Numero Inicial.", messageError, MessageBoxButtons.OK);
                return; 
            }
            else if(Mtx_End.Text == "") 
            {
                MessageBox.Show("Por favor, preencha o Numero Final.", messageError, MessageBoxButtons.OK);
                return; 
            }
            else if (Txt_Command.Text == "")
            {
                MessageBox.Show("Por favor, preencha o Comando SQL.", messageError, MessageBoxButtons.OK);
                return;
            }
            else if (Convert.ToInt32(Mtx_Start.Text) >= Convert.ToInt32(Mtx_End.Text))
            {
                MessageBox.Show("Valor Final não pode ser igual ou menor que o Valor Inicial.", messageError, MessageBoxButtons.OK);
                return;
            }
            string expression = Txt_Command.Text;
            string alias = Txt_Alias.Text;
            int startNumber = Convert.ToInt32(Mtx_Start.Text);
            int endNumber = Convert.ToInt32(Mtx_End.Text);
            for (int i = endNumber; i >= startNumber; i--)
            {
                string oldValue = alias + i;
                string newValue = alias + (i + 1);
                expression = expression.ToUpper().Replace(oldValue.ToUpper(), newValue.ToUpper());
            }
            Txt_Result.Text = expression;
        }

        private void Btn_Example_Click(object sender, EventArgs e)
        {
            Mtx_Start.Text = "2";
            Mtx_End.Text = "4";
            Txt_Alias.Text = "T";
            Txt_Command.Text = sqlCommand;
        }
    }
}
