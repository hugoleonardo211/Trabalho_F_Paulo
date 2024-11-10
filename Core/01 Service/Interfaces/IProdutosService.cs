using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._01_Service.Interfaces
{
    public interface IProdutosService
    {
        void Adicionar(Produtos p);



         void Remover(int id);



         List<Produtos> Listar();


         Produtos BuscarPorId(int id);


         void Editar(Produtos p);
       
    }
}
