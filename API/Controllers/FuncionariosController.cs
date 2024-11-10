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
        public class Funcinarioscontroller : ControllerBase
        {
            private readonly IFuncionariosService _service;
            private readonly IMapper _mapper;
            public Funcinarioscontroller(IConfiguration config, IMapper mapper, IFuncionariosService service)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _service = service;
                _mapper = mapper;
            }

            /// <summary>
        /// endpoint para adicionar um Funcionario novo no banco de dados
        /// </summary>
        /// <returns></returns>
            [HttpPost("adicionar-Funcionarios")]
            public IActionResult Adicionar(CreateFuncionariosDTO funcionariosDTO)
            {
            try
            {
                Funcionarios funcionarios = _mapper.Map<Funcionarios>(funcionariosDTO);
                _service.Adicionar(funcionarios);
                return Ok();
            }
            catch (Exception erro)
            {
               return BadRequest($"erro ao adicionar {erro.Message}");
            }
            }

            /// <summary>
        /// endpoint para listar todos os Funcionario do banco de dados
        /// </summary>
        /// <returns></returns>        
            [HttpGet("listar-Funcionarios")]
            public List<Funcionarios> Listar()
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
        /// endpoint para editar um Funcionario no banco de dados
        /// </summary>
        /// <returns></returns>
            [HttpPut("editar-Funcionarios")]
            public IActionResult Editar(Funcionarios f)
            {
            try
            {
                _service.Editar(f);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"erro ao editar {erro.Message}");
            }
            }

            /// <summary>
        /// endpoint para deletar um Funcionario no banco de dados
        /// </summary>
        /// <returns></returns>
            [HttpDelete("deletar-Funcionarios")]
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
        /// endpoint para buscar um Funcionario por id
        /// </summary>
        /// <returns></returns>
            [HttpGet("Buscar-Funcionarios-por-Id")]
            public Funcionarios BuscarPorId(int id)
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


