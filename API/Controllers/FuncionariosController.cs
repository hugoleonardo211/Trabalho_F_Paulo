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
            public Funcinarioscontroller(IConfiguration config, IMapper mapper)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _service = new FuncionariosService(_config);
                _mapper = mapper;
            }
            [HttpPost("adicionar-Funcionarios")]
            public void Adicionar(CreateFuncionariosDTO funcionariosDTO)
            {
                Funcionarios funcionarios = _mapper.Map<Funcionarios>(funcionariosDTO);
                _service.Adicionar(funcionarios);
            }
            [HttpGet("listar-Funcionarios")]
            public List<Funcionarios> Listar()
            {
                return _service.Listar();
            }
            [HttpPut("editar-Funcionarios")]
            public void Editar(Funcionarios f)
            {
                _service.Editar(f);
            }
            [HttpDelete("deletar-Funcionarios")]
            public void Deletar(int id)
            {
                _service.Remover(id);
            }
            [HttpGet("Buscar-Funcionarios-por-Id")]
            public Funcionarios BuscarPorId(int id)
            {
                return _service.BuscarPorId(id);
            }
        }
    }


