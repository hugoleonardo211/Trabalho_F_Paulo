using Barbearia._02_Repository;
using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._01_Service
{
    public class TipoAgendService
    {
        public TipoAgendRepository _repository { get; set; }
        public TipoAgendService(string _config)
        {
            _repository = new TipoAgendRepository(_config);
        }
        public void Adicionar(TipoAgend tipoagend)
        {
            _repository.Adicionar(tipoagend);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<TipoAgend> Listar()
        {
            return _repository.Listar();
        }
        public Produtos BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
        public void Editar(TipoAgend editTipoAgend)
        {
            _repository.Editar(editTipoAgend);
        }
    }
}
