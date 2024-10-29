using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._02_Repository.Interfaces
{
    internal interface IFuncionariosRepository
    {
        void Adicionar(Funcionarios funcionarios);


         void Remover(int id);


         void Editar(Funcionarios funcionarios);


         List<Funcionarios> Listar();

        Funcionarios BuscarPorId(int id);
      
    }
}
