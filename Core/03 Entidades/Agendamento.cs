using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia._03_Entidades
{
    [Table("Agendamentos")]
    public class Agendamento
    {
        public int Horario { get; set; }
        public int dia { get; set;}
    }
}
