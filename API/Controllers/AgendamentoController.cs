using AutoMapper;
using Barbearia._01_Service;
using Barbearia._01_Service.Interfaces;
using Barbearia._03_Entidades;
using Barbearia._03_Entidades.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Barbearia._00_Controller
{

    [ApiController]
        [Route("[controller]")]
        public class Agendamentocontroller : ControllerBase
        {
            private readonly IAgendamentoService _service;
            private readonly IMapper _mapper;
            public Agendamentocontroller(IConfiguration config, IMapper mapper, IAgendamentoService service)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _service = service;
                _mapper = mapper;
            }


            /// <summary>
            /// endpoint para adicionar um agendamento novo no banco de dados
            /// </summary>
            /// <returns></returns>

            [HttpPost("adicionar-Agendamento")]
                public IActionResult Adicionar(CreateAgendamentoDTO agendamentoDTO)
                {
                    try
                    {
                        Agendamento agendamento = _mapper.Map<Agendamento>(agendamentoDTO);
                        _service.Adicionar(agendamento);
                        return Ok();
                    }
                catch (Exception erro)
                    {
                    return BadRequest($"erro ao adicionar {erro.Message}");
                    }
                }

            /// <summary>
            /// endpoint para listar todos os agendamentos do banco de dados
            /// </summary>
            /// <returns></returns>

            [HttpGet("listar-agendamento")]
                public List<Agendamento> Listar()
                {
                try
                {
                    return _service.Listar();                
                }
                catch (Exception)
                {

                    throw new Exception("erro ao listar");
                }
                
                }

            /// <summary>
            /// endpoint para editar um agendamento por id
            /// </summary>
            /// <returns></returns>
            [HttpPut("editar-Agendamento")]
                public IActionResult Editar(Agendamento a)
                {
                    try
                    {
                        _service.Editar(a);
                        return Ok();
                    }
                    catch (Exception erro)
                    {
                        return BadRequest($"erro ao editar {erro.Message}");
                    }
                }

            /// <summary>
            /// endpoint para deletar um agendamento no banco de dados
            /// </summary>
            /// <returns></returns>
            [HttpDelete("deletar-Agendamento")]
                public IActionResult Deletar(int id)
                {
                try
                {
                    _service.Remover(id);
                    return Ok();
                }
                catch (Exception erro)
                {

                    return BadRequest($"erro ao deletar{erro.Message}");
                }
                }
                [HttpGet("Buscar-Agendamento-por-Id")]

            /// <summary>
            /// endpoint para buscar um agendamento por id
            /// </summary>
            /// <returns></returns>
            public Agendamento BuscarPorId(int id)
            {
                try
                {
                    return _service.BuscarPorId(id);
                }
                catch (Exception)
                {

                    throw new Exception("erro ao buscar");
                }
                
            }
        }
}

