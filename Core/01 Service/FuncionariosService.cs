﻿using Barbearia._01_Service.Interfaces;
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
    public class FuncionariosService : IFuncionariosService
    {
        public IFuncionariosRepository _repository { get; set; }
        public FuncionariosService(IFuncionariosRepository repository)
        {
            _repository = repository;
        }
        public void Adicionar(Funcionarios f)
        {
            _repository.Adicionar(f);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Funcionarios> Listar()
        {
            return _repository.Listar();
        }
        public Funcionarios BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
        public void Editar(Funcionarios editFuncionarios)
        {
            _repository.Editar(editFuncionarios);
        }

    }
}
