using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSimples
{
    internal class Contato
    {
        // Variaveis locais da classe Contato.
        // Acessiveis apenas pela classe Contato.
        private string primeiroNome;
        private string sobrenome;
        private string telefone;
        private string email;
        // PROPRIEDADES da classe Contato.
        // Acessíveis por qualquer parte desse programa.
        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set 
            { 
                primeiroNome = value;
                if (value.Length > 0)
                {
                    primeiroNome = value;
                }
                else
                {
                    primeiroNome = "?";
                }
            }
        }
        public string Sobrenome
        { 
            get { return sobrenome; } 
            set 
            { 
                if (value.Length > 0)
                {
                    sobrenome = value;
                }
                else
                {
                    sobrenome = "?";
                }
            }
        }
        public string Telefone
        {
            get { return telefone; } 
            set 
            { 
                if (value.Length == 11)
                {
                  telefone = value;
                }
                else
                {
                    telefone = "00000000000";
                }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value.Length > 0)
                {
                    email = value;
                }
                else
                {
                    email = "example@example.com";
                }
            }

        }


        // Construtor da classe.
        public Contato()
        {
            PrimeiroNome = "João";
            Sobrenome = "Da Silva";
            Telefone = "11988888776";
            Email = "example@example.com";
        }
        // Sobrecarga de método.
        public Contato(string primeiroNome, string sobrenome, string telefone, string email)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Email = email;
        }

        // Sobreescrita do método ToString()
        public override string ToString()
        {
            // Melhor utilizar String.Empty invés de "".
            string saida = String.Empty;
            saida += String.Format("{0} {1}", PrimeiroNome, Sobrenome);
            saida += " ";
            saida += String.Format("{0}-{1}-{2}", Telefone.Substring(0,2), Telefone.Substring(2, 5), Telefone.Substring(7, 4));
            saida += " "; // Apenas um espaço entre o telefone e o e-mail.
            saida += String.Format("{0}", Email);
            return saida;
        }
    }
}
