﻿using Barbearia._02_Repository;
using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._01_Service
{
    public class MetodPagService
    {
        public MetodPagRepository _repository { get; set; }
        public MetodPagService(string _config)
        {
            _repository = new MetodPagRepository(_config);
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
