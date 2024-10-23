using Barbearia._02_Repository;
using Barbearia._03_Entidades;
using Barbearia._03_Entidades.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._01_Service
{
    public class AgendamentoService
    {
        public AgendamentoRepository _repository { get; set; }
        public AgendamentoService(string _config)
        {
            _repository = new AgendamentoRepository(_config);
        }
        public void Adicionar(Agendamento agendamento)
        {
            _repository.Adicionar(agendamento);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }

        public List<Agendamento> Listar()
        {
            return _repository.Listar();
        }
        public Agendamento BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }
        public void Editar(Agendamento editAgendamento)
        {
            _repository.Editar(editAgendamento);
        }
    }
}
