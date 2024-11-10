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
        public class MetodPagcontroller : ControllerBase
        {
            private readonly IMetodPagService _service;
            private readonly IMapper _mapper;
            public MetodPagcontroller(IConfiguration config, IMapper mapper, IMetodPagService service)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _service = service;
                _mapper = mapper;
            }

            /// <summary>
            /// endpoint para adicionar um MetodPag novo no banco de dados
            /// </summary>
            /// <returns></returns>
            [HttpPost("adicionar-MetodPag")]
            public IActionResult Adicionar(CreateMetodPagDTO MetodPagDTO)
            {
            try
            {
                MetodPag mp = _mapper.Map<MetodPag>(MetodPagDTO);
                _service.Adicionar(mp);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"erro ao adiconar {erro.Message}");
            }
            }

            /// <summary>
            /// endpoint para listar todos os MetodPag do banco de dados
            /// </summary>
            /// <returns></returns>      
            [HttpGet("listar-MetodPag")]
            public List<MetodPag> Listar()
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
            /// endpoint para editar um MetodPag no banco de dados
            /// </summary>
            /// <returns></returns>
            [HttpPut("editar-MetodPag")]
            public IActionResult Editar(MetodPag mp)
            {
            try
            {
                _service.Editar(mp);
                return Ok();
            }
            catch (Exception erro )
            {

                return BadRequest($"erro ao editar {erro.Message}");
            }
            }

            /// <summary>
            /// endpoint para deletar um MetodPag no banco de dados
            /// </summary>
            /// <returns></returns>
            [HttpDelete("deletar-MetodPag")]
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
            /// endpoint para buscar um MetodPag por id
            /// </summary>
            /// <returns></returns>
            [HttpGet("Buscar-MetodPag-por-Id")]
            public MetodPag BuscarPorId(int id)
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



