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
            public TipoAgendcontroller(IConfiguration config, IMapper mapper)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _service = new TipoAgendService(_config);
                _mapper = mapper;
            }
            [HttpPost("adicionar-TipoAgend")]
            public void Adicionar(CreateTipoAgendDTO TipoAgendDTO)
            {
                TipoAgend tp = _mapper.Map<TipoAgend>(TipoAgendDTO);
                _service.Adicionar(tp);
            }
            [HttpGet("listar-TipoAgend")]
            public List<TipoAgend> Listar()
            {
                return _service.Listar();
            }
            [HttpPut("editar-TipoAgend")]
            public void Editar(TipoAgend tp)
            {
                _service.Editar(tp);
            }
            [HttpDelete("deletar-TipoAgend")]
            public void Deletar(int id)
            {
                _service.Remover(id);
            }
            [HttpGet("Buscar-TipoAgend-por-Id")]
            public TipoAgend BuscarPorId(int id)
            {
                return _service.BuscarPorId(id);
            }
        }
    }
