using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSimples
{
    public partial class AgendaSimples : Form
    {
        public AgendaSimples()
        {
            InitializeComponent();
        }

        private void AgendaSimples_Load(object sender, EventArgs e)
        {

        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            Contato objetoContato= new Contato(txtNome.Text, txtSobrenome.Text, txtTelefone.Text, txtEmail.Text);
            lstContatos.Items.Add(objetoContato.ToString());
        }
    }
}
