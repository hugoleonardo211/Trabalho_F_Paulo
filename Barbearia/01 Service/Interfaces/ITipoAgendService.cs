using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._01_Service.Interfaces
{
    public interface ITipoAgendService
    {
        void Adicionar(TipoAgend tipoagend);


        void Remover(int id);


        List<TipoAgend> Listar();

        TipoAgend BuscarPorId(int id);

        void Editar(TipoAgend editTipoAgend);
      

    }
}
