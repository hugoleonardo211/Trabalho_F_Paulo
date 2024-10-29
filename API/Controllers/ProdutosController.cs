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
            public Produtocontroller(IConfiguration config, IMapper mapper)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _service = new ProdutosService(_config);
                _mapper = mapper;
            }
            [HttpPost("adicionar-Produto")]
            public void Adicionar(CreateProdutosDTO produtoDTO)
            {
                Produtos produto = _mapper.Map<Produtos>(produtoDTO);
                _service.Adicionar(produto);
            }
            [HttpGet("listar-produto")]
            public List<Produtos> Listar()
            {
                return _service.Listar();
            }
            [HttpPut("editar-Produto")]
            public void Editar(Produtos p)
            {
                _service.Editar(p);
            }
            [HttpDelete("deletar-Produto")]
            public void Deletar(int id)
            {
                _service.Remover(id);
            }
            [HttpGet("Buscar-Produto-por-Id")]
            public Produtos BuscarPorId(int id)
            {
                return _service.BuscarPorId(id);
            }
        }
    }

