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
    public class MetodPagService : IMetodPagService
    {
        public IMetodPagRepository _repository { get; set; }
        public MetodPagService(IMetodPagRepository repository)
        {
            _repository = repository;
        }
        public void Adicionar(MetodPag metodpag)
        {
            _repository.Adicionar(metodpag);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<MetodPag> Listar()
        {
            return _repository.Listar();
        }
        public MetodPag BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
        public void Editar(MetodPag editMetodPag)
        {
            _repository.Editar(editMetodPag);
        }

    }
}

