using Barbearia._03_Entidades;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._02_Repository
{
    public class ProdutoRepository
    {
        
            private readonly string ConnectionString;
            public ProdutosRepository(string connectioString)
            {
                ConnectionString = connectioString;
            }
            public void Adicionar(Produtos produtos)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Insert<Produtos>(produtos);
            }
            public void Remover(int id)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                Produtos produtos = BuscarPorId(id);
                connection.Delete<Produtos>(produtos);
            }
            public void Editar(Produtos produtos)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Update<Produtos>(produtos);
            }
            public List<Produtos> Listar()
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.GetAll<Produtos>().ToList();
            }
            public Produtos BuscarPorId(int id)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.Get<Produtos>(id);
            }
        }
    }

