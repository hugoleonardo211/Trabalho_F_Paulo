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
        public class TipoAgendcontroller : ControllerBase
        {
            private readonly ITipoAgendService _service;
            private readonly IMapper _mapper;
            public TipoAgendcontroller(IConfiguration config, IMapper mapper, ITipoAgendService service)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _service = service;
                _mapper = mapper;
            }

            /// <summary>
        /// endpoint para adicionar um Funcionario novo no banco de dados
        /// </summary>
        /// <returns></returns>
            [HttpPost("adicionar-TipoAgend")]
            public IActionResult Adicionar(CreateTipoAgendDTO TipoAgendDTO)
            {
            try
            {
                TipoAgend tp = _mapper.Map<TipoAgend>(TipoAgendDTO);
                _service.Adicionar(tp);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest($"erro ao adicionar {erro.Message}");
            }
            }

            /// <summary>
        /// endpoint para listar todos os TipoAgend do banco de dados
        /// </summary>
        /// <returns></returns>
            [HttpGet("listar-TipoAgend")]
            public List<TipoAgend> Listar()
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
        /// endpoint para editar um TipoAgend no banco de dados
        /// </summary>
        /// <returns></returns>
            [HttpPut("editar-TipoAgend")]
            public IActionResult Editar(TipoAgend tp)
            {
            try
            {
                _service.Editar(tp);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"erro ao editar {erro.Message}");
            }
            }

            /// <summary>
        /// endpoint para deletar um TipoAgend no banco de dados
        /// </summary>
        /// <returns></returns>
            [HttpDelete("deletar-TipoAgend")]
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
        /// endpoint para buscar um TipoAgend por id
        /// </summary>
        /// <returns></returns>
            [HttpGet("Buscar-TipoAgend-por-Id")]
            public TipoAgend BuscarPorId(int id)
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
