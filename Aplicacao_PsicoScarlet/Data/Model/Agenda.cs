using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AplicacaoAgendamento.Shared
{
    public class Agenda
    {
        [Key]
        public Guid IdAgendamento { get; set; }
        public DateTime Data { get; set; }
        public String Horario { get; set; }
        public static Atendimento Atendimento { get; set; }
    }
}