using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Cadastro
{
    public partial class FrmCadCliente : Form
    {   
        public FrmCadCliente()
        {          
            InitializeComponent();
        }
        private void Cadastrar(object sender, EventArgs e)
        {
            CadastrosClientes cadastro = new CadastrosClientes(Convert.ToInt32(txbCodigo.Text), txbNome.Text, txbEmail.Text, txbTelefone.Text, txbEndereco.Text, Convert.ToDateTime(txbData.Text));
        }
        private void AtualizarGrid_Click(object sender, EventArgs e)
        {
            FrmCadCliente frm = new FrmCadCliente();
            frm.ShowDialog();
        }
        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroUsuárioDataSet.CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTESTableAdapter.Fill(this.cadastroUsuárioDataSet.CLIENTES);

        }
    }

}

