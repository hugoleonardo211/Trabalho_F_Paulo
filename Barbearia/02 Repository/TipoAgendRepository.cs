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
        public class TipoAgendRepository : ITipoAgendRepository
    {
            private readonly string ConnectionString;
            public TipoAgendRepository(string connectioString)
            {
                ConnectionString = connectioString;
            }
            public void Adicionar(TipoAgend tipoAgend)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Insert<TipoAgend>(tipoAgend);
            }
            public void Remover(int id)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                TipoAgend tp = BuscarPorId(id);
                connection.Delete<TipoAgend>(tp);
            }
            public void Editar(TipoAgend tp)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Update<TipoAgend>(tp);
            }
            public List<TipoAgend> Listar()
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.GetAll<TipoAgend>().ToList();
            }
            public TipoAgend BuscarPorId(int id)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.Get<TipoAgend>(id);
            }
        }
    }

