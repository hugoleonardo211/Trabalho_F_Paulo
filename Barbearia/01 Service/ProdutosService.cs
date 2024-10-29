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
    public class ProdutosService : IProdutosService
    {
        public ProdutoRepository _repository { get; set; }
        public ProdutosService(string _config)
        {
            _repository = new ProdutoRepository(_config);
        }
        public void Adicionar(Produtos p)
        {
            _repository.Adicionar(p);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Produtos> Listar()
        {
            return _repository.Listar();
        }
        public Produtos BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
        public void Editar(Produtos p)
        {
            _repository.Editar(p);
        }
    }
}

