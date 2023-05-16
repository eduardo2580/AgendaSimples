using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSimples
{
    public partial class AgendaSimples : Form
    {
        // Cria um vetor para guardar os Contatos.
        private Contato[] listaDeContatos = new Contato[1];
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

        // Escreve o contato no arquivo de texto.
        private void Escrever(Contato contato)
        {
            StreamWriter escrevedorDeArquivos = new StreamWriter("Contatos.txt");
            escrevedorDeArquivos.WriteLine(listaDeContatos.Length + 1);
            escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
            escrevedorDeArquivos.WriteLine(contato.Sobrenome);
            escrevedorDeArquivos.WriteLine(contato.Telefone);
            escrevedorDeArquivos.WriteLine(contato.Email);

            //Copia os contatos já estão no arquivo, e re-escreve
            //eles depois, atualizados.
            for (int i = 0; i < listaDeContatos.Length; i++)
            {
                escrevedorDeArquivos.WriteLine(listaDeContatos.Length + 1);
                escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
                escrevedorDeArquivos.WriteLine(contato.Sobrenome);
                escrevedorDeArquivos.WriteLine(contato.Telefone);
                escrevedorDeArquivos.WriteLine(contato.Email);
            }
            escrevedorDeArquivos.Close();
        }

        //Método para ler os dados do arquivo de texto.
        private void Ler()
        {
            StreamReader leitorDeArquivos = new StreamReader("Contatos.txt");
            listaDeContatos = new Contato[Convert.ToInt32(leitorDeArquivos.ReadLine())];
            // Copia os dados do arquivo de texto para o vetor ListaDeContatos
            for (int i = 0; i < listaDeContatos.Length; i++)
            {
                listaDeContatos[i] = new Contato();
                listaDeContatos[i].PrimeiroNome = leitorDeArquivos.ReadLine();
                listaDeContatos[i].Sobrenome = leitorDeArquivos.ReadLine();
                listaDeContatos[i].Telefone = leitorDeArquivos.ReadLine();
                listaDeContatos[i].Email = leitorDeArquivos.ReadLine();
            }
            leitorDeArquivos.Close();
        }
    }
}
