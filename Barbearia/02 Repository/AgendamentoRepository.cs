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
    public class AgendamentoRepository : IAgendamentoRepository
    {
        private readonly string ConnectionString;
        public AgendamentoRepository(string connectioString)
        {
            ConnectionString = connectioString;
        }
        public void Adicionar(Agendamento agendamento)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Agendamento>(agendamento);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Agendamento agendamento = BuscarPorId(id);
            connection.Delete<Agendamento>(agendamento);
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
        public Agendamento BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Agendamento>(id);
        }
    }
}
