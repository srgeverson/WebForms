using SisContatos.domain.model;
using System.Collections.Generic;

namespace SisContatos.domain.service
{
    interface IContatoService
    {
        void Adicionar(Contato contato);
        void Alterar(Contato contato);
        Contato Buscar(int id);
        List<Contato> Listar(Contato contato);
    }
}
