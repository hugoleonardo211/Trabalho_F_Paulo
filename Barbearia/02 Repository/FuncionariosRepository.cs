using Barbearia._02_Repository.Interfaces;
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
 
        public class FuncionariosRepository : IFuncionariosRepository
    {
            private readonly string ConnectionString;
            public FuncionariosRepository(string connectioString)
            {
                ConnectionString = connectioString;
            }
            public void Adicionar(Funcionarios funcionarios)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Insert<Funcionarios>(funcionarios);
            }
            public void Remover(int id)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                Funcionarios funcionarios = BuscarPorId(id);
                connection.Delete<Funcionarios>(funcionarios);
            }
            public void Editar(Funcionarios funcionarios)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Update<Funcionarios>(funcionarios);
            }
            public List<Funcionarios> Listar()
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.GetAll<Funcionarios>().ToList();
            }
            public Funcionarios BuscarPorId(int id)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.Get<Funcionarios>(id);
            }
        }
    }

