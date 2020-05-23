using Database;
using Model;
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

namespace Projeto_Cadastro_Clientes
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ConnectionSQLite.createBancoSqlite("dbcliente.sqlite");
            ConnectionSQLite.createTable("Cliente");            
       

            // ADD cliente
            ConnectionSQLite.add(getCliente_tela());           
            limpa_text(); 

        }
        private Cliente getCliente_tela()
        {
            return new Cliente()
            {
                nome     = text_nome.Text,
                cpf      = mask_txt_cpf.Text,
                data     = date_atendi.Text,
                telefone = mask_txt_tel.Text,
                celular  = mask_txt_cell.Text,
                hora     = mask_txt_hora.Text,
                email    = text_email.Text,
                endereco = text_end.Text,
                end_bairro = text_bairro.Text,
                end_numero = text_numero.Text

            };

        }

        private void limpa_text()
        {
            text_bairro.Clear();
            text_end.Clear();
            text_numero.Clear();
            text_email.Clear();
            text_nome.Clear();
            mask_txt_cell.Clear();
            mask_txt_cpf.Clear();
            mask_txt_hora.Clear();
            mask_txt_tel.Clear();

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        //VALIDAR EMAIL
        public static bool ValidarEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
