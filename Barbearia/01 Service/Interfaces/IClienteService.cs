using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._01_Service.Interfaces
{
    public interface IClienteService
    {
        void Adicionar(Cliente cliente);
        void Remover(int id);
        List<Cliente> Listar();
        Cliente BuscarPorId(int id);
        void Editar(Cliente editCliente);



    }
}
