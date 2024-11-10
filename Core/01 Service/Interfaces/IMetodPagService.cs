using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._01_Service.Interfaces
{
    public interface IMetodPagService
    {
        void Adicionar(MetodPag metodpag);
        void Remover(int id);
        List<MetodPag> Listar();
        MetodPag BuscarPorId(int id);
        void Editar(MetodPag editMetodPag);


    }
}
