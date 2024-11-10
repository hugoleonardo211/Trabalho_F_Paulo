using Barbearia._01_Service.Interfaces;
using Barbearia._02_Repository;
using Barbearia._02_Repository.Interfaces;
using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._01_Service
{
    public class TipoAgendService : ITipoAgendService
    {
        public ITipoAgendRepository _repository { get; set; }
        public TipoAgendService(ITipoAgendRepository repository)
        {
            _repository = repository;
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
        public TipoAgend BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
        public void Editar(TipoAgend editTipoAgend)
        {
            _repository.Editar(editTipoAgend);
        }
    }
}
