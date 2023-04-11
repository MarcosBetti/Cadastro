namespace Cadastro
{
    partial class FrmCadVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GridViewCadastro = new System.Windows.Forms.DataGridView();
            this.iDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRODUTOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMECLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroUsuárioDataSet = new Cadastro.CadastroUsuárioDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.labtotal = new System.Windows.Forms.Label();
            this.Cadastro = new System.Windows.Forms.Label();
            this.btnClienteCad = new System.Windows.Forms.Button();
            this.BtnProdutoCad = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxValorVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxCodigoVenda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCodigoProduto = new System.Windows.Forms.TextBox();
            this.tbxNomeProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNomeCliente = new System.Windows.Forms.TextBox();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.vENDASTableAdapter = new Cadastro.CadastroUsuárioDataSetTableAdapters.VENDASTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuárioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridViewCadastro);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.labtotal);
            this.groupBox1.Controls.Add(this.Cadastro);
            this.groupBox1.Controls.Add(this.btnClienteCad);
            this.groupBox1.Controls.Add(this.BtnProdutoCad);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.tbxValorVenda);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxCodigoVenda);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxCodigoProduto);
            this.groupBox1.Controls.Add(this.tbxNomeProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbNomeCliente);
            this.groupBox1.Controls.Add(this.tbxQuantidade);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 697);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GridViewCadastro
            // 
            this.GridViewCadastro.AutoGenerateColumns = false;
            this.GridViewCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDVENDADataGridViewTextBoxColumn,
            this.nOMEPRODUTODataGridViewTextBoxColumn,
            this.iDPRODUTOSDataGridViewTextBoxColumn,
            this.vALORVENDADataGridViewTextBoxColumn,
            this.nOMECLIENTEDataGridViewTextBoxColumn,
            this.iDCLIENTEDataGridViewTextBoxColumn});
            this.GridViewCadastro.DataSource = this.vENDASBindingSource;
            this.GridViewCadastro.Location = new System.Drawing.Point(62, 303);
            this.GridViewCadastro.Name = "GridViewCadastro";
            this.GridViewCadastro.RowHeadersWidth = 51;
            this.GridViewCadastro.RowTemplate.Height = 24;
            this.GridViewCadastro.Size = new System.Drawing.Size(748, 318);
            this.GridViewCadastro.TabIndex = 80;
            // 
            // iDVENDADataGridViewTextBoxColumn
            // 
            this.iDVENDADataGridViewTextBoxColumn.DataPropertyName = "ID_VENDA";
            this.iDVENDADataGridViewTextBoxColumn.HeaderText = "ID_VENDA";
            this.iDVENDADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDVENDADataGridViewTextBoxColumn.Name = "iDVENDADataGridViewTextBoxColumn";
            this.iDVENDADataGridViewTextBoxColumn.Width = 125;
            // 
            // nOMEPRODUTODataGridViewTextBoxColumn
            // 
            this.nOMEPRODUTODataGridViewTextBoxColumn.DataPropertyName = "NOMEPRODUTO";
            this.nOMEPRODUTODataGridViewTextBoxColumn.HeaderText = "NOMEPRODUTO";
            this.nOMEPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOMEPRODUTODataGridViewTextBoxColumn.Name = "nOMEPRODUTODataGridViewTextBoxColumn";
            this.nOMEPRODUTODataGridViewTextBoxColumn.Width = 125;
            // 
            // iDPRODUTOSDataGridViewTextBoxColumn
            // 
            this.iDPRODUTOSDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUTOS";
            this.iDPRODUTOSDataGridViewTextBoxColumn.HeaderText = "ID_PRODUTOS";
            this.iDPRODUTOSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPRODUTOSDataGridViewTextBoxColumn.Name = "iDPRODUTOSDataGridViewTextBoxColumn";
            this.iDPRODUTOSDataGridViewTextBoxColumn.Width = 125;
            // 
            // vALORVENDADataGridViewTextBoxColumn
            // 
            this.vALORVENDADataGridViewTextBoxColumn.DataPropertyName = "VALORVENDA";
            this.vALORVENDADataGridViewTextBoxColumn.HeaderText = "VALORVENDA";
            this.vALORVENDADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vALORVENDADataGridViewTextBoxColumn.Name = "vALORVENDADataGridViewTextBoxColumn";
            this.vALORVENDADataGridViewTextBoxColumn.Width = 125;
            // 
            // nOMECLIENTEDataGridViewTextBoxColumn
            // 
            this.nOMECLIENTEDataGridViewTextBoxColumn.DataPropertyName = "NOMECLIENTE";
            this.nOMECLIENTEDataGridViewTextBoxColumn.HeaderText = "NOMECLIENTE";
            this.nOMECLIENTEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOMECLIENTEDataGridViewTextBoxColumn.Name = "nOMECLIENTEDataGridViewTextBoxColumn";
            this.nOMECLIENTEDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCLIENTEDataGridViewTextBoxColumn
            // 
            this.iDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.HeaderText = "ID_CLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCLIENTEDataGridViewTextBoxColumn.Name = "iDCLIENTEDataGridViewTextBoxColumn";
            this.iDCLIENTEDataGridViewTextBoxColumn.Width = 125;
            // 
            // vENDASBindingSource
            // 
            this.vENDASBindingSource.DataMember = "VENDAS";
            this.vENDASBindingSource.DataSource = this.cadastroUsuárioDataSet;
            // 
            // cadastroUsuárioDataSet
            // 
            this.cadastroUsuárioDataSet.DataSetName = "CadastroUsuárioDataSet";
            this.cadastroUsuárioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(630, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 31);
            this.button3.TabIndex = 79;
            this.button3.Text = "Total Venda:";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labtotal
            // 
            this.labtotal.AutoSize = true;
            this.labtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtotal.Location = new System.Drawing.Point(791, 266);
            this.labtotal.Name = "labtotal";
            this.labtotal.Size = new System.Drawing.Size(19, 20);
            this.labtotal.TabIndex = 78;
            this.labtotal.Text = "0";
            // 
            // Cadastro
            // 
            this.Cadastro.AutoEllipsis = true;
            this.Cadastro.AutoSize = true;
            this.Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cadastro.Location = new System.Drawing.Point(10, 18);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(236, 29);
            this.Cadastro.TabIndex = 76;
            this.Cadastro.Text = "Cadastro de Venda";
            this.Cadastro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClienteCad
            // 
            this.btnClienteCad.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClienteCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteCad.Location = new System.Drawing.Point(487, 112);
            this.btnClienteCad.Name = "btnClienteCad";
            this.btnClienteCad.Size = new System.Drawing.Size(133, 24);
            this.btnClienteCad.TabIndex = 75;
            this.btnClienteCad.Text = "Busc.Cliente";
            this.btnClienteCad.UseVisualStyleBackColor = false;
            this.btnClienteCad.Click += new System.EventHandler(this.btnClienteCad_Click);
            // 
            // BtnProdutoCad
            // 
            this.BtnProdutoCad.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnProdutoCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProdutoCad.Location = new System.Drawing.Point(823, 157);
            this.BtnProdutoCad.Name = "BtnProdutoCad";
            this.BtnProdutoCad.Size = new System.Drawing.Size(132, 26);
            this.BtnProdutoCad.TabIndex = 74;
            this.BtnProdutoCad.Text = "Busc.Produto";
            this.BtnProdutoCad.UseVisualStyleBackColor = false;
            this.BtnProdutoCad.Click += new System.EventHandler(this.BtnProdutoCad_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(79, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 31);
            this.button2.TabIndex = 72;
            this.button2.Text = "Listagem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxValorVenda
            // 
            this.tbxValorVenda.Location = new System.Drawing.Point(197, 217);
            this.tbxValorVenda.Name = "tbxValorVenda";
            this.tbxValorVenda.Size = new System.Drawing.Size(275, 22);
            this.tbxValorVenda.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(626, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 70;
            this.label6.Text = "Nº Venda:";
            // 
            // tbxCodigoVenda
            // 
            this.tbxCodigoVenda.Location = new System.Drawing.Point(733, 111);
            this.tbxCodigoVenda.Name = "tbxCodigoVenda";
            this.tbxCodigoVenda.Size = new System.Drawing.Size(176, 22);
            this.tbxCodigoVenda.TabIndex = 69;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(823, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 68;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(546, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 22);
            this.label5.TabIndex = 67;
            this.label5.Text = "Código Produto:";
            // 
            // tbxCodigoProduto
            // 
            this.tbxCodigoProduto.Location = new System.Drawing.Point(720, 161);
            this.tbxCodigoProduto.Name = "tbxCodigoProduto";
            this.tbxCodigoProduto.Size = new System.Drawing.Size(90, 22);
            this.tbxCodigoProduto.TabIndex = 66;
            // 
            // tbxNomeProduto
            // 
            this.tbxNomeProduto.Location = new System.Drawing.Point(197, 165);
            this.tbxNomeProduto.Name = "tbxNomeProduto";
            this.tbxNomeProduto.Size = new System.Drawing.Size(275, 22);
            this.tbxNomeProduto.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 64;
            this.label4.Text = "Nome Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 22);
            this.label3.TabIndex = 63;
            this.label3.Text = "Valor Total Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(582, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 62;
            this.label2.Text = "Quantidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nome do Produto:";
            // 
            // txbNomeCliente
            // 
            this.txbNomeCliente.Location = new System.Drawing.Point(197, 111);
            this.txbNomeCliente.Name = "txbNomeCliente";
            this.txbNomeCliente.Size = new System.Drawing.Size(284, 22);
            this.txbNomeCliente.TabIndex = 60;
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Location = new System.Drawing.Point(720, 217);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(90, 22);
            this.tbxQuantidade.TabIndex = 59;
            // 
            // vENDASTableAdapter
            // 
            this.vENDASTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCadVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 706);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCadVenda";
            this.Text = "FrmCadVenda";
            this.Load += new System.EventHandler(this.FrmCadVenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuárioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridViewCadastro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labtotal;
        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.Button btnClienteCad;
        private System.Windows.Forms.Button BtnProdutoCad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbxValorVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxCodigoVenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCodigoProduto;
        private System.Windows.Forms.TextBox tbxNomeProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNomeCliente;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private CadastroUsuárioDataSet cadastroUsuárioDataSet;
        private System.Windows.Forms.BindingSource vENDASBindingSource;
        private CadastroUsuárioDataSetTableAdapters.VENDASTableAdapter vENDASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUTOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMECLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTEDataGridViewTextBoxColumn;
    }
}