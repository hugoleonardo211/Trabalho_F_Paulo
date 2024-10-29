using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._02_Repository.Interfaces
{
    public interface IAgendamentoRepository
    {
        void Adicionar(Agendamento agendamento);


         void Remover(int id);

        void Editar(Agendamento agendamento);

        List<Agendamento> Listar();

        Agendamento BuscarPorId(int id);
       
    }
}
