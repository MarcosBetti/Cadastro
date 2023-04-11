using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(DataGrid produto)
        {
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void relatórioVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmCadCliente frm = new FrmCadCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmCadProduto frm = new FrmCadProduto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cadVendaRelVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadVenda frm1 = new FrmCadVenda();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}