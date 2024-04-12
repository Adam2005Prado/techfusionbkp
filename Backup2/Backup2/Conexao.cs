using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace Csharp_and_Database
{
    public class Connection
    {
        //local host
        static private string servidor = "127.0.0.1";
        static private string bd = "DataBase_TechFusion";
        static private string usuario = "root";
        static private string senha = "";
        public MySqlConnection connection = null;
        static private string strcon = "server=" + servidor + ";database=" + bd + ";user id=" + usuario + ";password=" + senha;


        public MySqlConnection getconexao()
        {
            connection = new MySqlConnection(strcon);
            return connection;
        }

        public int produto(string nome, float preco)
        {
            //delcara o registro do cadastro;
            int registro = 0;
            try
            {
                //pega a conexão;
                connection = getconexao();

                connection.Open(); //abre-se a conexão com o banco de dados;

                string Sql = "Insert into produto(Nome_prod, preco_prod) values ('" + nome + "','" + preco + "')";



                MySqlCommand cmd = new MySqlCommand(Sql, connection);

                //executa a instrução;
                registro = cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro." + ex.Message);
            }
            return registro;
        }

        public DataTable obterdados(string Sql)
        {
            //cria a tabela de dados
            DataTable dt = new DataTable();
            connection = getconexao();//obtenho a conexão
            connection.Open();//abro a conexão
            //prepara o script para o Sql
            MySqlCommand cmd = new MySqlCommand(Sql, connection);
            //executa as informações na tabela
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}