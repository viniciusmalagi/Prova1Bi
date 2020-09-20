using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova1Bim
{
    public partial class Prod : Form
    {
        public Prod()
        {
            InitializeComponent();
        }
        
        SqlConnection sqlConn = null;
        private string strConn = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProvaBim;Data Source=LAPTOP-FCIGCC9H";
        private string strSql = string.Empty;


        private void Prod_Load(object sender, EventArgs e)
        {

        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            strSql = "Insert into ProdTab(idproduto,produto,valor)values(@idproduto,@produto,@valor)";

            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            comando.Parameters.Add("@idproduto", SqlDbType.Int).Value = int.Parse(txt_id.Text);
            comando.Parameters.Add("@produto", SqlDbType.VarChar).Value =(txt_produto.Text);
            comando.Parameters.Add("@valor", SqlDbType.Int).Value = decimal.Parse(txt_valor.Text);

            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro concluído!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            txt_id.Enabled = true;

            txt_produto.Clear();
            txt_valor.Clear();
        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
           
            

        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            btn_Incluir.Enabled = false;
            strSql = "select*from ProdTab where idproduto =@idproduto";
            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            comando.Parameters.Add("@idproduto", SqlDbType.Int).Value = int.Parse(txt_id.Text);

            try
            {
                sqlConn.Open();
                SqlDataReader dr = comando.ExecuteReader();

                if(dr.HasRows == false)
                {
                    throw new Exception("Este produto não está cadastrado!");
                }
                dr.Read();
                txt_id.Text = Convert.ToString(dr["idproduto"]);
                txt_produto.Text = Convert.ToString(dr["produto"]);
                txt_valor.Text = Convert.ToString(dr["valor"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            

            
            //txt_produto.Clear();
            //txt_valor.Clear();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_produto.Clear();
            txt_valor.Clear();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            strSql = "update ProdTab set idproduto =@idproduto, produto=@produto,valor=@valor";
            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            comando.Parameters.Add("@idproduto", SqlDbType.Int).Value = int.Parse(txt_id.Text);
            comando.Parameters.Add("@produto", SqlDbType.VarChar).Value = (txt_produto.Text);
            comando.Parameters.Add("@valor", SqlDbType.Int).Value = decimal.Parse(txt_valor.Text);


            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro alterado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            txt_id.Enabled = true;

            txt_produto.Clear();
            txt_valor.Clear();
            txt_id.Clear();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente excluir este produto?", "Cuidado", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!");
            }
            strSql = "delete from ProdTab where idproduto=@idproduto";
            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            comando.Parameters.Add("@idproduto", SqlDbType.Int).Value = int.Parse(txt_id.Text);
            


            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto excluído!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }

            txt_produto.Clear();
            txt_valor.Clear();
            txt_id.Clear();
        }

        private void txt_produto_TextChanged(object sender, EventArgs e)
        {
            btn_Incluir.Enabled = true;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja sair de Cadastro? ", "Mensage do sistema ",

               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                Close();
            }
        }
    }
    }

