using System;
using System.Collections.Generic;
using System.Text;

namespace provaPaulo
{
    class Cliente
    {
        private string nome;
        private string cpf;
        private string telefone;
        private string email;

        public Cliente() { }
        public Cliente(string n, string c, string t, string e) {
            nome = n;
            cpf = c;
            telefone = t;
            email = e;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Tele
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }



        public override string ToString()
        {
            return "Seu Nome: " + nome + ", Seu número de Cpf: " + cpf + ", Seu número de Telefone: " + telefone + ", Seu email: " + email;
        }

    }
}
