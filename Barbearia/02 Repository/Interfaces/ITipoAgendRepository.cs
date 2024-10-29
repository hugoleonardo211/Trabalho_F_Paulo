using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._02_Repository.Interfaces
{
    internal interface ITipoAgendRepository
    {
        void Adicionar(TipoAgend tipoAgend);


        public void Remover(int id);


        public void Editar(TipoAgend tp);


        public List<TipoAgend> Listar();


        public TipoAgend BuscarPorId(int id);
        
    }
}
