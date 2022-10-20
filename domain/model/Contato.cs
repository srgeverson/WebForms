using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisContatos.domain.model
{
    public class Contato
    {

        private int id;
        private string nome;
        private string sobreNome;
        private string email;
        private string telefone;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string SobreNome { get => sobreNome; set => sobreNome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}