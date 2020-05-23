using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Busca_Cliente : Form
    {
        public Busca_Cliente()
        {
            InitializeComponent();        

            desabilita_btn();


        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscaCliente(txt_pesq_nome.Text);
            desabilita_btn();
        }


        private void BuscaCliente(string nome)
        {
            Cliente cli = new Cliente();

            try
            {
                if (nome == string.Empty)
                {
                    throw new Exception("Por favor Informe um nome");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cli = ConnectionSQLite.getCliente(nome);

            text_nome.Text      = cli.nome;
            mask_txt_cpf.Text   = cli.cpf;
            date_atendi.Text    = cli.data;
            mask_txt_tel.Text   = cli.telefone;
            mask_txt_cell.Text  = cli.celular;
            mask_txt_hora.Text  = cli.hora;
            text_email.Text     = cli.email;
            text_end.Text       = cli.endereco;
            text_numero.Text    = cli.end_numero;
            text_bairro.Text    = cli.end_bairro;
  

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            ativar_btn();
           
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // ADD cliente
            ConnectionSQLite.alterar(getCliente_tela());           
            limpa_text();
            desabilita_btn();

        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            ConnectionSQLite.delete(mask_txt_cpf.Text);           
            limpa_text();
        }

        private Cliente getCliente_tela()
        {
            return new Cliente()
            {
                nome       = text_nome.Text,
                cpf        = mask_txt_cpf.Text,
                data       = date_atendi.Text,
                telefone   = mask_txt_tel.Text,
                celular    = mask_txt_cell.Text,
                hora       = mask_txt_hora.Text,
                email      = text_email.Text,
                endereco   = text_end.Text,
                end_bairro = text_bairro.Text,
                end_numero = text_numero.Text

            };

        }

        private void desabilita_btn()
        {
            text_bairro.Enabled   = false;
            text_end.Enabled      = false;
            text_numero.Enabled   = false;
            text_email.Enabled    = false;
            text_nome.Enabled     = false;
            mask_txt_cell.Enabled = false;
            mask_txt_cpf.Enabled  = false;
            mask_txt_hora.Enabled = false;
            mask_txt_tel.Enabled  = false;
            date_atendi.Enabled   = false;
        }

        private void ativar_btn()
        {
            text_bairro.Enabled    = true;
            text_end.Enabled       = true;
            text_numero.Enabled    = true;
            text_email.Enabled     = true;
            text_nome.Enabled      = true;
            mask_txt_cell.Enabled  = true;           
            mask_txt_hora.Enabled  = true;
            mask_txt_tel.Enabled   = true;
            date_atendi.Enabled    = true;
        }

        private void limpa_text()
        {
            text_bairro.Clear();
            text_end.Clear();
            text_numero.Clear();
            text_email.Clear();
            text_nome.Clear();
            txt_pesq_nome.Clear();
            mask_txt_cell.Clear();
            mask_txt_cpf.Clear();
            mask_txt_hora.Clear();
            mask_txt_tel.Clear();

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
