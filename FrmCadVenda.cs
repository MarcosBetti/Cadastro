using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class FrmCadVenda : Form
    {
        public FrmCadVenda()
        {
            InitializeComponent();
        }

        private void FrmCadVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroUsuárioDataSet.VENDAS'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDASTableAdapter.Fill(this.cadastroUsuárioDataSet.VENDAS);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CadastroVenda cadastro = new CadastroVenda(Convert.ToInt32(tbxCodigoVenda.Text), tbxNomeProduto.Text, Convert.ToInt32(tbxCodigoProduto.Text), Convert.ToSingle(tbxValorVenda.Text), txbNomeCliente.Text);
        }
        private void BtnProdutoCad_Click(object sender, EventArgs e)
        {
            FrmCadProduto frm = new FrmCadProduto();
            frm.Show();
        }

        private void btnClienteCad_Click(object sender, EventArgs e)
        {
            FrmCadCliente frm = new FrmCadCliente();
            frm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            labtotal.Text = "0";
            for (int i = 0; i < GridViewCadastro.Rows.Count; i++)
            {
                labtotal.Text = Convert.ToString(float.Parse(labtotal.Text) + float.Parse(GridViewCadastro.Rows[i].Cells[3].ToString()));
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

            // TODO: esta linha de código carrega dados na tabela 'cadastroUsuárioDataSet.VENDAS'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDASTableAdapter.Fill(this.cadastroUsuárioDataSet.VENDAS);


        }
    }
}
