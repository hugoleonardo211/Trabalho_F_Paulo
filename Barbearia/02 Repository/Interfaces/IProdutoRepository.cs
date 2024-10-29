using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._02_Repository.Interfaces
{
    internal interface IProdutoRepository 
    {
        void Adicionar(Produtos produtos);

        void Remover(int id);

        void Editar(Produtos produtos);

        List<Produtos> Listar();
        Produtos BuscarPorId(int id);
      
    }
}

