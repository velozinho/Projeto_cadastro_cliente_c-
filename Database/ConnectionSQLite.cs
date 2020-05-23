using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public class ConnectionSQLite
    {
        // Declarando um tipo conexao
        private static SQLiteConnection conn;

        // retorna a conexao 
        private static SQLiteConnection dadosConnection()
        {
            conn = new SQLiteConnection(@"Data Source=c:\tmp\dbcliente.sqlite");
            conn.Open();
            return conn;
        }

        // Criando banco de dados
        public static void createBancoSqlite(string dataBaseName)
        {
            try
            {
                if (!File.Exists(@"C:\tmp\" + dataBaseName))
                    SQLiteConnection.CreateFile(@"C:\tmp\" + dataBaseName);

            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void createTable(string tableName)
        {
            try
            {
                using (var cmd = dadosConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS " + tableName + "( nome varchar(60),cpf varchar(14) unique,data varchar(20),telefone varchar(10),celular varchar(12),hora varchar(12),email varchar(30),endereco varchar(50), numero varchar(5),bairro varchar(50) )";
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        // incluindo cliente no sqlite
        public static void add(Cliente cli)
        {
            try
            {
                using (var cmd = dadosConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Cliente (nome, cpf,data,telefone,celular,hora,email,endereco,numero,bairro) values (@nome,@cpf,@data,@telefone,@celular,@hora,@email,@endereco,@numero,@bairro)";
                    cmd.Parameters.AddWithValue("@nome", cli.nome);
                    cmd.Parameters.AddWithValue("@cpf", cli.cpf);
                    cmd.Parameters.AddWithValue("@data", cli.data);
                    cmd.Parameters.AddWithValue("@telefone", cli.telefone);
                    cmd.Parameters.AddWithValue("@celular", cli.celular);
                    cmd.Parameters.AddWithValue("@hora", cli.hora);
                    cmd.Parameters.AddWithValue("@email", cli.email);
                    cmd.Parameters.AddWithValue("@endereco", cli.endereco);
                    cmd.Parameters.AddWithValue("@numero", cli.end_numero);
                    cmd.Parameters.AddWithValue("@bairro", cli.end_bairro);
                    cmd.ExecuteNonQuery();

                }

                // Mensagem de Sucesso
                MessageBox.Show("Cadastro Realizado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Buscando todos os clientes
        public static DataTable getAll()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            using (var cmd = dadosConnection().CreateCommand())
            {
                cmd.CommandText = "select nome,cpf,data,telefone,celular,hora,email,endereco,numero,bairro from Cliente";
                da = new SQLiteDataAdapter(cmd.CommandText, dadosConnection());
                da.Fill(dt);
                return dt;
            }

        }

        // Buscando um unico cliente
        public static Cliente getCliente(string nome)
        {
            Cliente cliente = new Cliente();

            using (var cmd = dadosConnection().CreateCommand())
            {
                cmd.CommandText = "select nome,cpf,data,telefone,celular,hora,email,endereco,numero,bairro from Cliente where nome= @nome COLLATE NOCASE";
                cmd.Parameters.AddWithValue("@Nome", nome);


                SQLiteDataReader leitor = cmd.ExecuteReader();

                try
                {
                    if (leitor.HasRows == false)
                    {
                        throw new Exception("Este nome nao esta cadastrado");

                    }

                    leitor.Read();

                    cliente.nome        = leitor["nome"].ToString();
                    cliente.cpf         = leitor["cpf"].ToString();
                    cliente.data        = leitor["data"].ToString();
                    cliente.telefone    = leitor["telefone"].ToString();
                    cliente.celular     = leitor["celular"].ToString();
                    cliente.hora        = leitor["hora"].ToString();
                    cliente.email       = leitor["email"].ToString();
                    cliente.endereco    = leitor["endereco"].ToString();
                    cliente.end_numero  = leitor["numero"].ToString();
                    cliente.end_bairro  = leitor["bairro"].ToString();

                    leitor.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return cliente;

            }


        }

        // Alterando cliente no sqlite
        public static void alterar(Cliente cli)
        {
            try
            {
                using (var cmd = dadosConnection().CreateCommand())
                {
                    cmd.CommandText = "update Cliente set nome=@nome,data=@data,telefone=@telefone,celular=@celular,hora=@hora,email=@email,endereco=@endereco,numero=@numero,bairro=@bairro where cpf=@cpf";
                    cmd.Parameters.AddWithValue("@nome", cli.nome);
                    cmd.Parameters.AddWithValue("@cpf", cli.cpf);
                    cmd.Parameters.AddWithValue("@data", cli.data);
                    cmd.Parameters.AddWithValue("@telefone", cli.telefone);
                    cmd.Parameters.AddWithValue("@celular", cli.celular);
                    cmd.Parameters.AddWithValue("@hora", cli.hora);
                    cmd.Parameters.AddWithValue("@email", cli.email);
                    cmd.Parameters.AddWithValue("@endereco", cli.endereco);
                    cmd.Parameters.AddWithValue("@numero", cli.end_numero);
                    cmd.Parameters.AddWithValue("@bairro", cli.end_bairro);
                    cmd.ExecuteNonQuery();
                }

                // Mensagem de Sucesso
                MessageBox.Show("Cliente alterado com Sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void delete(string cpf)
        {
            try
            {
                using (var cmd = dadosConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Cliente Where cpf=@cpf";
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.ExecuteNonQuery();
                }

                // Mensagem de Sucesso
                MessageBox.Show("Cliente Excluido com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static DataTable Buscar_Agendamento(string data)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
               
                using (var cmd = dadosConnection().CreateCommand())
                {
                    cmd.CommandText = "select nome,data, hora,telefone,celular from Cliente";                    
                    da = new SQLiteDataAdapter(cmd.CommandText, dadosConnection());
                    da.Fill(dt);

                    for (int i = dt.Rows.Count - 1; i >= 0; i--)
                    {
                        DataRow dr = dt.Rows[i];
                        if (dr["data"].ToString() != data)
                            dr.Delete();
                    }
                    dt.AcceptChanges();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;


        }
    }
}
