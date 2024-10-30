using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._03_Entidades.DTO
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {

            CreateMap<CreateAgendamentoDTO, Agendamento>().ReverseMap();
            CreateMap<CreateProdutosDTO, Produtos>().ReverseMap();
            CreateMap<CreateTipoAgendDTO, TipoAgend>().ReverseMap();
            CreateMap<CreateFuncionariosDTO, Funcionarios>().ReverseMap();
            CreateMap<CreateMetodPagDTO, MetodPag>().ReverseMap();
            CreateMap<CreateClienteDTO, Cliente>().ReverseMap();

        }
    }
}
