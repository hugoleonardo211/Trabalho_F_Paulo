﻿using Barbearia._02_Repository.Interfaces;
using Barbearia._03_Entidades;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._02_Repository
{
    
        public class ClienteRepository : IClienteRepository
    {
            private readonly string ConnectionString;
            public ClienteRepository(IConfiguration config)
            {
                ConnectionString = config.GetConnectionString("DefaultConnection"); 
            }
            public void Adicionar(Cliente cliente)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Insert<Cliente>(cliente);
            }
            public void Remover(int id)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                Cliente cliente = BuscarPorId(id);
                connection.Delete<Cliente>(cliente);
            }
            public void Editar(Cliente cliente)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                connection.Update<Cliente>(cliente);
            }
            public List<Cliente> Listar()
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.GetAll<Cliente>().ToList();
            }
            public Cliente BuscarPorId(int id)
            {
                using var connection = new SQLiteConnection(ConnectionString);
                return connection.Get<Cliente>(id);
            }
        }
    }

