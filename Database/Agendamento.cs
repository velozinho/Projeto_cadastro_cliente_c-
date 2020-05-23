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
    public partial class Agendamento : Form
    {
        public Agendamento()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
          dataGrid_Agend.DataSource =  ConnectionSQLite.Buscar_Agendamento(dateTime_Agend.Text);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
