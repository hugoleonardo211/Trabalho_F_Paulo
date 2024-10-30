using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._02_Repository.Interfaces
{
    public interface IMetodPagRepository
    {
        void Adicionar(MetodPag mp);


        public void Remover(int id);


        public void Editar(MetodPag mp);


        public List<MetodPag> Listar();


        public MetodPag BuscarPorId(int id);
     
    }
}
