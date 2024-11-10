using AutoMapper;
using Barbearia._01_Service;
using Barbearia._01_Service.Interfaces;
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
        public class Produtocontroller : ControllerBase
        {
            private readonly IProdutosService _service;
            private readonly IMapper _mapper;
            public Produtocontroller(IConfiguration config, IMapper mapper, IProdutosService service)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _service = service;
                _mapper = mapper;
            }

            /// <summary>
        /// endpoint para adicionar um Produto novo no banco de dados
        /// </summary>
        /// <returns></returns>
            [HttpPost("adicionar-Produto")]
            public IActionResult Adicionar(CreateProdutosDTO produtoDTO)
            {
            try
            {
                Produtos produto = _mapper.Map<Produtos>(produtoDTO);
                _service.Adicionar(produto);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"erro ao adicionar {erro.Message}");
            }
            }

            /// <summary>
        /// endpoint para listar todos os Produto do banco de dados
        /// </summary>
        /// <returns></returns>
            [HttpGet("listar-produto")]
            public List<Produtos> Listar()
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
        /// endpoint para editar um Produto no banco de dados
        /// </summary>
        /// <returns></returns>
            [HttpPut("editar-Produto")]
            public IActionResult Editar(Produtos p)
            {
            try
            {
                _service.Editar(p);
                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest($"erro ao editar {erro.Message}");
            }
            }

            /// <summary>
        /// endpoint para deletar um Produto no banco de dados
        /// </summary>
        /// <returns></returns>
            [HttpDelete("deletar-Produto")]
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
        /// endpoint para buscar um Produto por id
        /// </summary>
        /// <returns></returns>
            [HttpGet("Buscar-Produto-por-Id")]
            public Produtos BuscarPorId(int id)
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

