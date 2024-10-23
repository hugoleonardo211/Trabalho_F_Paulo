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
    public class MetodPagController
    {
        [ApiController]
        [Route("[controller]")]
        public class MetodPagcontroller : ControllerBase
        {
            private readonly MetodPagService _service;
            private readonly IMapper _mapper;
            public MetodPagcontroller(IConfiguration config, IMapper mapper)
            {
                string _config = config.GetConnectionString("DefaultConnection");
                _service = new MetodPagService(_config);
                _mapper = mapper;
            }
            [HttpPost("adicionar-MetodPag")]
            public void Adicionar(CreateMetodPagDTO MetodPagDTO)
            {
                MetodPag mp = _mapper.Map<MetodPag>(MetodPagDTO);
                _service.Adicionar(mp);
            }
            [HttpGet("listar-MetodPag")]
            public List<MetodPag> Listar()
            {
                return _service.Listar();
            }
            [HttpPut("editar-MetodPag")]
            public void Editar(MetodPag mp)
            {
                _service.Editar(mp);
            }
            [HttpDelete("deletar-MetodPag")]
            public void Deletar(int id)
            {
                _service.Remover(id);
            }
            [HttpGet("Buscar-MetodPag-por-Id")]
            public MetodPag BuscarPorId(int id)
            {
                return _service.BuscarPorId(id);
            }
        }
    }
}
}
