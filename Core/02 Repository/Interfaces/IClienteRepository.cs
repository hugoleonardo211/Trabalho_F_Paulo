using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._02_Repository.Interfaces
{
    public interface IClienteRepository
    {
        void Adicionar(Cliente cliente);

        void Remover(int id);

        void Editar(Cliente cliente);

        List<Cliente> Listar();

        Cliente BuscarPorId(int id);

    }
}
