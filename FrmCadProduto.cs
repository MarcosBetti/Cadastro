using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cadastro
{
    public partial class FrmCadProduto : Form
    {
        public FrmCadProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroProdutos cadastro = new CadastroProdutos(Convert.ToInt32(txbCodigoProduto.Text), txbNomeProduto.Text, Convert.ToSingle(txbValorProduto.Text), Convert.ToInt32(txbInserirQtde.Text));
        }

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroUsuárioDataSet.PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOSTableAdapter.Fill(this.cadastroUsuárioDataSet.PRODUTOS);

        }
    }
}
