using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Cadastro
{
    internal class CadastroVenda
    {

        Conexao conn = new Conexao();

        SqlCommand c = new SqlCommand();

        public CadastroVenda(int ID_VENDA, string NOMEPRODUTO, int ID_PRODUTOS, float VALORVENDA, string NOMECLIENTE)
        {
            c.CommandText = "Insert Into VENDAS(ID_VENDA,NOMEPRODUTO,VALORVENDA, ID_PRODUTOS,NOMECLIENTE) Values(@ID_VENDA,@NOMEPRODUTO,@VALORVENDA, @ID_PRODUTOS, @NOMECLIENTE)";
            c.Parameters.Add(new SqlParameter("@ID_VENDA", ID_VENDA));
            c.Parameters.Add(new SqlParameter("@NOMEPRODUTO", NOMEPRODUTO));
            c.Parameters.Add(new SqlParameter("@VALORVENDA", VALORVENDA.ToString("F2", CultureInfo.InvariantCulture)));
            c.Parameters.Add(new SqlParameter("@ID_PRODUTOS", ID_PRODUTOS));
            c.Parameters.Add(new SqlParameter("@NOMECLIENTE", NOMECLIENTE));

            try
            {
                c.Connection = conn.conectar();
                int ok = c.ExecuteNonQuery();
                if (ok == 1)
                {
                    MessageBox.Show(" Cliente cadastrado com sucesso");
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Ocorreu erro: " + erro.Message);
            }
            finally
            {
                conn.desconectar();
            }
        }
    }
}