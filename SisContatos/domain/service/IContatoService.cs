using SisContatos.domain.model;
using System.Collections.Generic;

namespace SisContatos.domain.service
{
    interface IContatoService
    {
        void Adicionar(Contato contato);

        Contato Buscar(int id);

        List<Contato> Listar(Contato contato);
    }
}
