using Barbearia._01_Service;
using Barbearia._01_Service.Interfaces;
using Barbearia._02_Repository;
using Barbearia._02_Repository.Data;
using Barbearia._02_Repository.Interfaces;
using Barbearia._03_Entidades.DTO;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    // Informa ao Swagger para incluir o arquivo XML gerado
    var xmlFile = "API.xml"; // Nome do arquivo XML gerado
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);

    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Teste Api barber",
        Version = "v1",
        Description = "Testando descrição"
    });
});
InicializadorBd.Inializador();
builder.Services.AddAutoMapper(typeof(MappingProfile)); //adicionando o Mapper
//Agendamento
builder.Services.AddScoped<IAgendamentoService, AgendamentoService>(); 
builder.Services.AddScoped<IAgendamentoRepository, AgendamentoRepository>();

//Clientes
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

//Funcionarios
builder.Services.AddScoped<IFuncionariosService, FuncionariosService>();
builder.Services.AddScoped<IFuncionariosRepository, FuncionariosRepository>();


//MetodoPag
builder.Services.AddScoped<IMetodPagService, MetodPagService>();
builder.Services.AddScoped<IMetodPagRepository, MetodPagRepository>();

//Produto
builder.Services.AddScoped<IProdutosService, ProdutosService>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

//TipoAgend
builder.Services.AddScoped<ITipoAgendService, TipoAgendService>();
builder.Services.AddScoped<ITipoAgendRepository, TipoAgendRepository>();
var app = builder.Build();

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Minha API v1");
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
