using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AplicacaoAgendamento.Shared
{
    public class Atendimento
    {
        [Key] public Guid IdAtendimento { get; set; }
        public  DateTime Data { get; set; }
        public  string? HoraInicio { get; set; }
        public  string? HoraEncerramento { get; set; }
        public required Paciente Paciente { get; set; }
        public Prontuario? Prontuario { get; set; }  
    }
}