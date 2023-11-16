using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AplicacaoAgendamento.Shared
{
    public class Prontuario
    {
        [Key]
        public Guid IdProntuario { get; set; } 
        public int DescricaoProntuario { get; set; }
        public Paciente? Paciente { get; set; }
    }

}