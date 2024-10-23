using AutoMapper;
using Barbearia._01_Service;
using Barbearia._03_Entidades;
using Barbearia._03_Entidades.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._00_Controller
{
    
        [ApiController]
        [Route("[controller]")]
        public class Agendamentocontroller : ControllerBase
        {
            private readonly AgendamentoService _service;
            private readonly IMapper _mapper;
            public Agendamentocontroller(IConfiguration config, IMapper mapper)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _service = new AgendamentoService(_config);
                _mapper = mapper;
            }
            [HttpPost("adicionar-Agendamento")]
            public void Adicionar(CreateAgendamentoDTO agendamentoDTO)
            {
                Agendamento agendamento = _mapper.Map<Agendamento>(agendamentoDTO);
                _service.Adicionar(agendamento);
            }
            [HttpGet("listar-agendamento")]
            public List<Agendamento> Listar()
            {
                return _service.Listar();
            }
            [HttpPut("editar-Agendamento")]
            public void Editar(Agendamento a)
            {
                _service.Editar(a);
            }
            [HttpDelete("deletar-Agendamento")]
            public void Deletar(int id)
            {
                _service.Remover(id);
            }
            [HttpGet("Buscar-Agendamento-por-Id")]
            public Agendamento BuscarPorId(int id)
            {
                return _service.BuscarPorId(id);
            }
        }
    }

