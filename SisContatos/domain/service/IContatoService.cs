using SisContatos.domain.model;
using System.Collections.Generic;

namespace SisContatos.domain.service
{
    interface IContatoService
    {
        void Adicionar(Contato contato);

        List<Contato> Listar(Contato contato);
    }
}
