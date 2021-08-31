using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisContatos
{
    public class Contato
    {

        public int Id { get; set; }
        public string Nome { get; set; }

        public static List<Contato> Contatos = new List<Contato>();
             
        public void Salvar()
        {
            Contatos.Add(this);
        }

        public List<Contato> Listar()
        {
            return Contatos;
        }
    }
}