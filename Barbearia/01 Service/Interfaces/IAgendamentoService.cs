using Barbearia._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._01_Service.Interfaces
{
    public interface IAgendamentoService
    {
        void Adicionar(Agendamento agendamento);
        void Remover(int id);
        List<Agendamento> Listar();
        Agendamento BuscarPorId(int id);
       void Editar(Agendamento editAgendamento);


    }
}
