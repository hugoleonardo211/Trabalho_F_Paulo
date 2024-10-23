using Barbearia._03_Entidades;
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
        public class AgendamentoRepository
        {
            private readonly string ConnectionString;
            public AgendamentoRepository(string connectioString)
            {
                ConnectionString = connectioString;
            }
            public void Adicionar(Agendamento agendamento)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Insert<TipoAgend>(agendamento);
            }
            public void Remover(int id)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                Produtos produtos = BuscarPorId(id);
                connection.Delete<TipoAgend>(agendamento);
            }
            public void Editar(Agendamento agendamento)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Update<Agendamento>(agendamento);
            }
            public List<Agendamento> Listar()
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.GetAll<Agendamento>().ToList();
            }
            public Produtos BuscarPorId(int id)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.Get<Agendamento>(id);
            }
        }
    }
}
