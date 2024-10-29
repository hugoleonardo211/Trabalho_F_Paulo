using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._01_Service.Interfaces
{
    public interface IFuncionariosService
    {
        void Adicionar(Funcionarios f);
        void Remover(int id);
        List<Funcionarios> Listar();
    }
}
