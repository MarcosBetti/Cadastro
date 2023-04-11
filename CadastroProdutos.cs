using System;
using System.Globalization;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cadastro
{
    internal class CadastroProdutos
    {
        Conexao conn = new Conexao();

        SqlCommand c = new SqlCommand();

        public CadastroProdutos(int ID_PRODUTOS, string NOME, float VALOR, int ESTOQUE)
        {

            c.CommandText = "Insert Into PRODUTOS(ID_PRODUTOS,NOME,VALOR,ESTOQUE) Values(@ID_PRODUTOS,@NOME,@VALOR,@ESTOQUE)";
            c.Parameters.Add(new SqlParameter("@ID_PRODUTOS", ID_PRODUTOS));
            c.Parameters.Add(new SqlParameter("@NOME", NOME));
            c.Parameters.Add(new SqlParameter("@VALOR", VALOR));
            c.Parameters.Add(new SqlParameter("@ESTOQUE", ESTOQUE));

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

