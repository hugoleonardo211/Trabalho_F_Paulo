using Barbearia._01_Service.Interfaces;
using Barbearia._02_Repository;
using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._01_Service
{
    public class ClienteService : IClienteService
    {
        public IClienteService _repository { get; set; }
        public ClienteService(string _config)
        {
            _repository = new ClienteService(_config);
        }
        public void Adicionar(Cliente cliente)
        {
            _repository.Adicionar(cliente);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Cliente> Listar()
        {
            return _repository.Listar();
        }
        public Cliente BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
        public void Editar(Cliente editCliente)
        {
            _repository.Editar(editCliente);
        }

    }
}
