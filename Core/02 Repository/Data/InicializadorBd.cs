using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._02_Repository.Data
{
    public class InicializadorBd
    {
        private const string ConnectionString = "Data Source=Barbearia.db";

        public static void Inializador()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string commandoSQL = @" 
                CREATE TABLE IF NOT EXISTS Agendamentos(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                HORARIO INTEGER NOT NULL,
                DIA INTEGER  NOT NULL
                 );";

                commandoSQL = @" 
                CREATE TABLE IF NOT EXISTS Clientes(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                NOME TEXT NOT NULL,
                USUARIO TEXT  NOT NULL,
                SENHA INTEGER NOT NULL
                 );";

                commandoSQL = @" 
                CREATE TABLE IF NOT EXISTS Funcionarios(                
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                NOME TEXT NOT NULL,
                CONTATO INTEGER  NOT NULL,
                CARGO TEXT NOT NULL
                 );";

                commandoSQL = @" 
                CREATE TABLE IF NOT EXISTS MetodoPags(  
                PIX REAL NOT NULL,
                CREDITO REAL  NOT NULL,
                DEBITO REAL NOT NULL,
                DINHEIRO REAL NOT NULL
                 );";

                commandoSQL = @" 
                CREATE TABLE IF NOT EXISTS Produtos(  
                ID INTEGER PRIMARY KEY AUTOINCREMENT
                GEL TEXT NOT NULL,
                CREME TEXT  NOT NULL,
                PENTE TEXT NOT NULL
                 );";

                commandoSQL = @" 
                CREATE TABLE IF NOT EXISTS TipoAgendamento(  
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                NOME TEXT NOT NULL,
                TIPO TEXT  NOT NULL
                 );";

                connection.Execute(commandoSQL);

            }
        }
    }
}