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
using Barbearia._01_Service.Interfaces;

namespace Barbearia._00_Controller
{
    
        [ApiController]
        [Route("[controller]")]
        public class Clientecontroller : ControllerBase
        {
            private readonly IClienteService _service;
            private readonly IMapper _mapper;
            public Clientecontroller(IConfiguration config, IMapper mapper, IClienteService service)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _service = service;
                _mapper = mapper;
            }


            /// <summary>
            /// endpoint para adicionar um Cliente novo no banco de dados
            /// </summary>
            /// <returns></returns>
            [HttpPost("adicionar-Cliente")]
            public IActionResult Adicionar(Cliente agendamentoDTO)
            {
            try
            {
                Cliente cliente = _mapper.Map<Cliente>(agendamentoDTO);
                _service.Adicionar(cliente);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest($"erro ao adicionar {erro.Message}");
            }
            }


            /// <summary>
        /// endpoint para listar todos os Cliente do banco de dados
        /// </summary>
        /// <returns></returns>
            [HttpGet("listar-Cliente")]
            public List<Cliente> Listar()
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
        /// endpoint para editar uma Cliente novo no banco de dados
        /// </summary>
        /// <returns></returns>
            [HttpPut("editar-Cliente")]
            public IActionResult Editar(Cliente c)
            {
            try
            {
                _service.Editar(c);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"erro ao editar {erro.Message}");
            }
            }

            /// <summary>
        /// endpoint para deletar um Cliente no banco de dados
        /// </summary>
        /// <returns></returns>
            [HttpDelete("deletar-Cliente")]
            public IActionResult Deletar(int id)
            {
            try
            {
                _service.Remover(id);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"erro ao deletar {erro.Message}");
            }
                
            }

            /// <summary>
        /// endpoint para buscar um Cliente por id
        /// </summary>
        /// <returns></returns>
            [HttpGet("Buscar-Cliente-por-Id")]
            public Cliente BuscarPorId(int id)
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


