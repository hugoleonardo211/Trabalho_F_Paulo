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
   
        public class MetodPagRepository
        {
            private readonly string ConnectionString;
            public MetodPagRepository(string connectioString)
            {
                ConnectionString = connectioString;
            }
            public void Adicionar(MetodPag mp)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Insert<MetodPag>(mp);
            }
            public void Remover(int id)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                MetodPag mp = BuscarPorId(id);
                connection.Delete<MetodPag>(mp);
            }
            public void Editar(MetodPag mp)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Update<MetodPag>(mp);
            }
            public List<MetodPag> Listar()
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.GetAll<MetodPag>().ToList();
            }
            public MetodPag BuscarPorId(int id)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.Get<MetodPag>(id);
            }
        }
    }

