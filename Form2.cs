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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroUsuárioDataSet.VENDAS'. Você pode movê-la ou removê-la conforme necessário.
            this.vENDASTableAdapter.Fill(this.cadastroUsuárioDataSet.VENDAS);
        
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
