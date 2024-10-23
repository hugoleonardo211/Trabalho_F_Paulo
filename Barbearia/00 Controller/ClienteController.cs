using AutoMapper;
using Barbearia._01_Service;
using Barbearia._03_Entidades.DTO;
using Barbearia._03_Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._00_Controller
{
    public class ClienteController
    {
        [ApiController]
        [Route("[controller]")]
        public class Clientecontroller : ControllerBase
        {
            private readonly ClienteService _service;
            private readonly IMapper _mapper;
            public Clientecontroller(IConfiguration config, IMapper mapper)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _service = new ClienteService(_config);
                _mapper = mapper;
            }
            [HttpPost("adicionar-Cliente")]
            public void Adicionar(Cliente agendamentoDTO)
            {
                Cliente cliente = _mapper.Map<Cliente>(agendamentoDTO);
                _service.Adicionar(cliente);
            }
            [HttpGet("listar-agendamento")]
            public List<Cliente> Listar()
            {
                return _service.Listar();
            }
            [HttpPut("editar-Agendamento")]
            public void Editar(Cliente c)
            {
                _service.Editar(c);
            }
            [HttpDelete("deletar-Cliente")]
            public void Deletar(int id)
            {
                _service.Remover(id);
            }
            [HttpGet("Buscar-Cliente-por-Id")]
            public Cliente BuscarPorId(int id)
            {
                return _service.BuscarPorId(id);
            }
        }
    }
}

